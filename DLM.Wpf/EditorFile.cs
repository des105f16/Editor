using Microsoft.Win32;
using SablePP.Tools.Editor;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DLM.Wpf
{
    public class EditorFile
    {
        private readonly OpenFileDialog openFileDialog1;
        private readonly SaveFileDialog saveFileDialog1;

        private readonly Window window;
        private readonly MenuItem recentFilesMenuItem;
        private string filepath;

        public EditorFile(Window window, MenuItem recentFilesMenuItem, CommandBindingCollection bindings)
        {
            this.window = window;
            this.recentFilesMenuItem = recentFilesMenuItem;
            this.filepath = null;

            this.openFileDialog1 = new OpenFileDialog();
            this.saveFileDialog1 = new SaveFileDialog();

            bindings.Add(new CommandBinding(ApplicationCommands.New, null, enabled));

            bindings.Add(new CommandBinding(ApplicationCommands.Open, null, enabled));
            bindings.Add(new CommandBinding(CustomCommands.OpenRecent, null, recentFiles_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Save, null, fileLoaded_CanExecute));
            bindings.Add(new CommandBinding(ApplicationCommands.SaveAs, null, fileLoaded_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Close, null, fileLoaded_CanExecute));
        }

        private void enabled(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void disabled(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = false;
        private void fileLoaded_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = filepath != null;

        private void recentFiles_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var source = recentFilesMenuItem as MenuItem;

            if (source.IsSubmenuOpen)
            {
                e.CanExecute = true;
                return;
            }

            string[] files = new string[] { "a", "b" };

            source.Items.Clear();
            foreach (var file in files)
            {
                MenuItem newMenuItem2 = new MenuItem();
                source.Items.Add(newMenuItem2);
                newMenuItem2.Header = file;
            }

            e.CanExecute = files.Length > 0;
        }

        #region FileHandle events and methods

#pragma warning disable 1591
        protected sealed override void OnClosing(CancelEventArgs e)
        {
            if (CloseFile() != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
#pragma warning restore

        public DialogResult NewFile()
        {
            DialogResult res = CloseFile();
            if (res != System.Windows.Forms.DialogResult.OK)
                return res;

            File = new FileInfo(EditorResources.Untitled + "." + (extension ?? EditorResources.DefaultExtension));

            encoding = Encoding.UTF8;
            NewFileCreated?.Invoke(this, EventArgs.Empty);
            changed = false;

            return DialogResult.OK;
        }

        public event EventHandler NewFileCreated;

        public DialogResult OpenFile()
        {
            DialogResult res;
            if (FileIsOpen)
            {
                res = CloseFile();
                if (res != System.Windows.Forms.DialogResult.OK)
                    return res;
            }

            openFileDialog1.FileName = "";
            res = openFileDialog1.ShowDialog();
            if (res != System.Windows.Forms.DialogResult.OK)
                return res;

            FileOpeningEventArgs fo = new FileOpeningEventArgs(openFileDialog1.FileName, this.FileExtension);
            FileOpening?.Invoke(this, fo);
            if (!fo.AllowFile)
                return System.Windows.Forms.DialogResult.Abort;

            return OpenFile(openFileDialog1.FileName);
        }
        public DialogResult OpenFile(string filepath)
        {
            if (FileIsOpen)
            {
                DialogResult res = CloseFile();
                if (res != System.Windows.Forms.DialogResult.OK)
                    return res;
            }

            string content;
            File = new FileInfo(filepath);
            using (StreamReader reader = new StreamReader(File.FullName, true))
            {
                content = reader.ReadToEnd();
                this.encoding = reader.CurrentEncoding;
            }
            FileOpened?.Invoke(this, new FileOpenedEventArgs(content));
            changed = false;

            recentFiles.AddRecent(filepath);

            return DialogResult.OK;
        }

        public event EventHandler<FileOpeningEventArgs> FileOpening;
        public event EventHandler<FileOpenedEventArgs> FileOpened;

        public DialogResult SaveFile()
        {
            if (!FileIsOpen)
                return System.Windows.Forms.DialogResult.Cancel;

            if (!File.Exists)
                return SaveFileAs();

            FileSavingEventArgs e = new FileSavingEventArgs();
            FileSaving?.Invoke(this, e);
            using (FileStream fs = new FileStream(File.FullName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs, encoding))
                writer.Write(e.Content);
            changed = false;

            recentFiles.AddRecent(File.FullName);

            return DialogResult.OK;
        }
        public DialogResult SaveFileAs()
        {
            if (!FileIsOpen)
                return System.Windows.Forms.DialogResult.Cancel;

            DialogResult res = saveFileDialog1.ShowDialog();
            if (res != System.Windows.Forms.DialogResult.OK)
                return res;

            FileInfo f = new FileInfo(saveFileDialog1.FileName);

            FileSavingEventArgs e = new FileSavingEventArgs();
            FileSaving?.Invoke(this, e);
            using (FileStream fs = new FileStream(f.FullName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs, encoding))
                writer.Write(e.Content);

            File = f;
            changed = false;

            recentFiles.AddRecent(File.FullName);

            return DialogResult.OK;
        }
        public event EventHandler<FileSavingEventArgs> FileSaving;

        public DialogResult CloseFile()
        {
            if (!FileIsOpen)
                return System.Windows.Forms.DialogResult.OK;

            if (changed)
            {
                DialogResult res = MessageBox.Show(
                    "It seems you have made changes to your file \"" + File.Name + "\", would you like to save it before closing?",
                    "File changed",
                    MessageBoxButtons.YesNoCancel);
                if (res == System.Windows.Forms.DialogResult.Yes)
                    res = SaveFile();

                if (res == System.Windows.Forms.DialogResult.Cancel)
                    return res;
            }

            encoding = null;
            File = null;

            FileClosed?.Invoke(this, EventArgs.Empty);
            return DialogResult.OK;
        }
        public event EventHandler FileClosed;

        #endregion
    }
}
