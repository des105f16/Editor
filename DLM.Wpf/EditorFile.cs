using DLM.Wpf.Properties;
using Microsoft.Win32;
using SablePP.Tools.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
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
        private RecentFilesHandler recentFiles;

        public EditorFile(Window window, MenuItem recentFilesMenuItem, CommandBindingCollection bindings)
        {
            this.window = window;
            this.recentFilesMenuItem = recentFilesMenuItem;
            this.filepath = null;
            this.recentFiles = new RecentFilesHandler();

            this.openFileDialog1 = new OpenFileDialog();
            this.saveFileDialog1 = new SaveFileDialog();

            this.FileExtension = null;

            bindings.Add(new CommandBinding(ApplicationCommands.New, null, enabled));

            bindings.Add(new CommandBinding(ApplicationCommands.Open, null, enabled));
            bindings.Add(new CommandBinding(CustomCommands.OpenRecent, null, recentFiles_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Save, null, fileLoaded_CanExecute));
            bindings.Add(new CommandBinding(ApplicationCommands.SaveAs, null, fileLoaded_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Close, null, fileLoaded_CanExecute));
            bindings.Add(new CommandBinding(CustomCommands.Exit, (s, e) => window.Close(), enabled));

            window.Closing += (s, e) => windowClosing(e);
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

            source.Items.Clear();
            int i = 1;
            foreach (var file in recentFiles.TakeExisting(recentfilesCount))
            {
                string filepath = file;
                MenuItem newMenuItem2 = new MenuItem() { Header = $"_{i} {file}" };
                newMenuItem2.Click += (s, ee) => OpenFile(filepath);
                source.Items.Add(newMenuItem2);
                i++;
            }

            e.CanExecute = i > 1;
        }

        #region File extension

        private string extension = null;
        /// <summary>
        /// Gets or sets the file extension used by the editor.
        /// </summary>
        public string FileExtension
        {
            get { return extension; }
            set
            {
                extension = value?.TrimStart('.');
                openFileDialog1.Filter = string.Format(Settings.Default.FileDescription, Text) + "|*." + (extension ?? Settings.Default.DefaultExtension);
                saveFileDialog1.Filter = string.Format(Settings.Default.FileDescription, Text) + "|*." + (extension ?? Settings.Default.DefaultExtension);
            }
        }

        #endregion

        #region FileHandle fields

        private Encoding encoding;

        private FileInfo _file = null;
        /// <summary>
        /// Gets a <see cref="FileInfo"/> object representing the currently opened file.
        /// </summary>
        public FileInfo File
        {
            get { return _file; }
            private set
            {
                _file = value;
                if (_file == null)
                    _changed = false;

                updateTitle();

                OnFileChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Occurs when the <see cref="EditorForm.File"/> property changes. Note that this property can be <c>null</c>.
        /// </summary>
        public event EventHandler FileChanged;

        /// <summary>
        /// Raises the <see cref="EditorForm.FileChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnFileChanged(EventArgs e)
        {
            if (FileChanged != null)
                FileChanged(this, e);
        }

        /// <summary>
        /// Gets a value indicating whether a file is currently open.
        /// </summary>
        /// <value>
        ///   <c>true</c> if a file is currently open; otherwise, <c>false</c>.
        /// </value>
        public bool FileIsOpen
        {
            get { return File != null; }
        }
        private bool _changed = false;
        private bool changed
        {
            get { return _changed; }
            set { _changed = value; updateTitle(); }
        }

        /// <summary>
        /// Marks the current file as changed. This will make the <see cref="EditorForm"/> ask if the file should be saved when it is closed.
        /// </summary>
        protected void MarkFileAsChanged()
        {
            this.changed = true;
        }

        #endregion

        #region FileHandle events and methods

        private void windowClosing(CancelEventArgs e)
        {
            if (CloseFile() != MessageBoxResult.OK)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        public MessageBoxResult NewFile()
        {
            MessageBoxResult res = CloseFile();
            if (res != MessageBoxResult.OK)
                return res;

            File = new FileInfo(Settings.Default.Untitled + "." + (extension ?? Settings.Default.DefaultExtension));

            encoding = Encoding.UTF8;
            NewFileCreated?.Invoke(this, EventArgs.Empty);
            changed = false;

            return MessageBoxResult.OK;
        }

        public event EventHandler NewFileCreated;

        public MessageBoxResult OpenFile()
        {
            MessageBoxResult res;
            if (FileIsOpen)
            {
                res = CloseFile();
                if (res != MessageBoxResult.OK)
                    return res;
            }

            openFileDialog1.FileName = "";
            var open = openFileDialog1.ShowDialog();
            res = open == true ? MessageBoxResult.OK : MessageBoxResult.Cancel;
            if (res != MessageBoxResult.OK)
                return res;

            FileOpeningEventArgs fo = new FileOpeningEventArgs(openFileDialog1.FileName, this.FileExtension);
            FileOpening?.Invoke(this, fo);
            if (!fo.AllowFile)
                return MessageBoxResult.Cancel;

            return OpenFile(openFileDialog1.FileName);
        }
        public MessageBoxResult OpenFile(string filepath)
        {
            if (FileIsOpen)
            {
                MessageBoxResult res = CloseFile();
                if (res != MessageBoxResult.OK)
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

            return MessageBoxResult.OK;
        }

        public event EventHandler<FileOpeningEventArgs> FileOpening;
        public event EventHandler<FileOpenedEventArgs> FileOpened;

        public MessageBoxResult SaveFile()
        {
            if (!FileIsOpen)
                return MessageBoxResult.Cancel;

            if (!File.Exists)
                return SaveFileAs();

            FileSavingEventArgs e = new FileSavingEventArgs();
            FileSaving?.Invoke(this, e);
            using (FileStream fs = new FileStream(File.FullName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs, encoding))
                writer.Write(e.Content);
            changed = false;

            recentFiles.AddRecent(File.FullName);

            return MessageBoxResult.OK;
        }
        public MessageBoxResult SaveFileAs()
        {
            if (!FileIsOpen)
                return MessageBoxResult.Cancel;

            var res = saveFileDialog1.ShowDialog();
            if (res != true)
                return MessageBoxResult.Cancel;

            FileInfo f = new FileInfo(saveFileDialog1.FileName);

            FileSavingEventArgs e = new FileSavingEventArgs();
            FileSaving?.Invoke(this, e);
            using (FileStream fs = new FileStream(f.FullName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(fs, encoding))
                writer.Write(e.Content);

            File = f;
            changed = false;

            recentFiles.AddRecent(File.FullName);

            return MessageBoxResult.OK;
        }
        public event EventHandler<FileSavingEventArgs> FileSaving;

        public MessageBoxResult CloseFile()
        {
            if (!FileIsOpen)
                return MessageBoxResult.OK;

            if (changed)
            {
                MessageBoxResult res = MessageBox.Show(
                    "It seems you have made changes to your file \"" + File.Name + "\", would you like to save it before closing?",
                    "File changed",
                    MessageBoxButton.YesNoCancel);
                if (res == MessageBoxResult.Yes)
                    res = SaveFile();

                if (res == MessageBoxResult.Cancel)
                    return res;
            }

            encoding = null;
            File = null;

            FileClosed?.Invoke(this, EventArgs.Empty);
            return MessageBoxResult.OK;
        }
        public event EventHandler FileClosed;

        #endregion

        private int recentfilesCount = 9;
        public int RecentFilesCount
        {
            get { return recentfilesCount; }
            set
            {
                if (value < 0)
                    value = 0;
                this.recentfilesCount = value;
            }
        }

        private class RecentFilesHandler
        {
            /// <summary>
            /// Defines the maximum number of elements in the list
            /// </summary>
            private const int MAXLISTSIZE = 50;
            private List<string> files;

            public RecentFilesHandler()
            {
                this.files = new List<string>(getPropertyFiles());
            }

            private IEnumerable<string> getPropertyFiles()
            {
                if (Settings.Default.RecentFiles == null || Settings.Default.RecentFiles.Length == 0)
                    yield break;

                foreach (var s in Settings.Default.RecentFiles.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries))
                    yield return s;
            }

            public void AddRecent(string filepath)
            {
                if (filepath == null)
                    throw new ArgumentNullException("filepath");

                filepath = Path.GetFullPath(filepath);

                if (filepath.EndsWith("/") || filepath.EndsWith("\\"))
                    throw new ArgumentException("File path cannot end in / or \\ - it must be the path of a file.", "filepath");

                if (!isValid(filepath))
                    throw new ArgumentException("File path is not valid.", "filepath");

                files.Insert(0, filepath);

                string filesString = filepath;
                filepath = filepath.ToLower();
                foreach (var f in getPropertyFiles().Take(MAXLISTSIZE))
                    if (f.ToLower() != filepath)
                        filesString += "?" + f;

                Settings.Default.RecentFiles = filesString;
                Settings.Default.Save();
            }

            private bool isValid(string filepath)
            {
                string filename = Path.GetFileName(filepath);
                filepath = filepath.Substring(0, filepath.Length - filename.Length);

                foreach (var c in Path.GetInvalidFileNameChars())
                    if (filename.Contains(c))
                        return false;

                foreach (var c in Path.GetInvalidPathChars())
                    if (filepath.Contains(c))
                        return false;

                return true;
            }

            public IEnumerable<string> Take(int count)
            {
                return getPropertyFiles().Take(count);
            }

            public IEnumerable<string> TakeExisting(int count)
            {
                int c = 0;
                foreach (var f in getPropertyFiles())
                {
                    if (new FileInfo(f).Exists)
                        yield return f;

                    if (c++ == count)
                        break;
                }
            }
        }
    }
}
