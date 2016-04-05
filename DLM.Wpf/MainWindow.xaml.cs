using FastColoredTextBoxNS;
using MahApps.Metro.Controls;
using SablePP.Tools.Editor;
using System;
using System.IO;
using System.Windows.Forms.Integration;

namespace DLM.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private CodeTextBox codeTextBox;
        private EditorFile file;

        public MainWindow()
        {
            InitializeComponent();

            var forecolor = System.Drawing.Color.FromArgb(220, 220, 220);
            var backcolor = System.Drawing.Color.FromArgb(30, 30, 30);
            var disabledbackcolor = System.Drawing.Color.FromArgb(12, 12, 12);
            var linenumbers = System.Drawing.Color.FromArgb(36, 126, 175);

            var currentline = System.Drawing.Color.FromArgb(12, 12, 12);

            var font = new System.Drawing.Font("Consolas", 10f, System.Drawing.FontStyle.Regular);

            this.codeTextBox = new CodeTextBox()
            {
                Executer = new DLM.Compiler.CompilerExecuter(),
                BackColor = backcolor,
                ServiceLinesColor = backcolor,
                IndentBackColor = backcolor,
                LineNumberColor = linenumbers,
                CaretColor = forecolor,
                ForeColor = forecolor,
                CurrentLineColor = currentline,
                Font = font,
                DisabledColor = disabledbackcolor,
                Enabled = false
            };

            codeTextBox.TextChanged += codeTextBox_TextChanged;
            codeTextBox.SelectionChanged += codeTextBox_SelectionChanged;

            Loaded += (s, e) => codegrid.Children.Add(new WindowsFormsHost() { Child = codeTextBox });

            file = new EditorFile(this, recentFilesMenuItem, CommandBindings)
            {
                FileExtension = ".ncif",
                Title = "ncif"
            };

            file.NewFileCreated += newFileCreated;
            file.FileOpening += fileOpening;
            file.FileOpened += fileOpened;
            file.FileSaving += fileSaving;
            file.FileClosed += fileClosed;
        }

        private void newFileCreated(object sender, EventArgs e)
        {
            codeTextBox.Enabled = true;

            codeTextBox.Text = "";
            codeTextBox.Focus();
            codeTextBox.SelectionLength = 0;
            codeTextBox.SelectionStart = 0;

            if (codeTextBox.Text == string.Empty)
                codeTextBox.OnTextChangedDelayed(codeTextBox.Range);

            codeTextBox.ClearUndo();
        }
        private void fileOpening(object sender, FileOpeningEventArgs e)
        {
            if (File.Exists(e.Filepath) && Path.GetExtension(e.Filepath) == "." + file.FileExtension)
                e.AllowFile = true;
        }
        private void fileOpened(object sender, FileOpenedEventArgs e)
        {
            codeTextBox.Enabled = true;

            codeTextBox.Text = e.Content;
            codeTextBox.ClearUndo();

            codeTextBox.Focus();

            if (codeTextBox.Text == string.Empty)
                codeTextBox.OnTextChangedDelayed(codeTextBox.Range);
        }
        private void fileSaving(object sender, FileSavingEventArgs e)
        {
            e.Content = codeTextBox.Text;
        }
        private void fileClosed(object sender, EventArgs e)
        {
            codeTextBox.Enabled = false;
            codeTextBox.Text = "";
        }

        private void codeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            file.MarkFileAsChanged();
        }
        private void codeTextBox_SelectionChanged(object sender, EventArgs e)
        {
            lineBlock.Text = (codeTextBox.Selection.Start.iLine + 1).ToString();
            charBlock.Text = (codeTextBox.Selection.Start.iChar + 1).ToString();
        }
    }
}
