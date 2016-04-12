using DLM.Compiler;
using DLM.Inference;
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

        private LabelSquigglyStyle labelSquiggly = new LabelSquigglyStyle();

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
                BackColor = backcolor,
                ServiceLinesColor = backcolor,
                IndentBackColor = backcolor,
                LineNumberColor = linenumbers,
                CaretColor = forecolor,
                ForeColor = forecolor,
                CurrentLineColor = currentline,
                Font = font,
                DisabledColor = disabledbackcolor,
                Enabled = false,
                WordWrap = true,
                WordWrapMode = WordWrapMode.WordWrapControlWidth
            };
            this.codeTextBox.Executer = new DLM.Compiler.CompilerExecuter();

            constraintList.Items.Clear();

            codeTextBox.TextChanged += codeTextBox_TextChanged;
            codeTextBox.SelectionChanged += codeTextBox_SelectionChanged;
            codeTextBox.ErrorAdded += (s, e) => errorListBox.Items.Add(ErrorViewTypes.Wrap(e.Error));
            codeTextBox.ErrorsCleared += (s, e) => errorListBox.Items.Clear();
            codeTextBox.CompilationCompleted += CodeTextBox_CompilationCompleted;

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

        private System.Windows.GridLength? errorHeight = null;

        private void CodeTextBox_CompilationCompleted(object sender, EventArgs e)
        {
            var comp = codeTextBox.Executer as Compiler.CompilerExecuter;
            var result = comp.Result;

            if (codeTextBox.LastResult.Errors.Length > 0)
            {
                if (errorHeight.HasValue)
                {
                    errorRow.Height = errorHeight.Value;
                    splitterRow.Height = new System.Windows.GridLength(2);
                    errorHeight = null;
                }
            }
            else
            {
                if (!errorHeight.HasValue)
                {
                    errorHeight = errorRow.Height;
                    errorRow.Height = new System.Windows.GridLength(0);
                    splitterRow.Height = new System.Windows.GridLength(0);
                }
            }

            codeTextBox.Range.ClearStyle(labelSquiggly);
            labelSquiggly.Clear();

            if (result == null)
                return;

            if (result.Succes)
            {
                foreach (var c in result.OriginalConstraints)
                {
                    if (!(c.OriginType == NodeConstraint.OriginTypes.Declaration ||
                          c.OriginType == NodeConstraint.OriginTypes.IfBlock ||
                          c.OriginType == NodeConstraint.OriginTypes.WhileBlock))
                        continue;

                    if (!(c.Right is VariableLabel))
                        continue;

                    var variable = c.Right as VariableLabel;
                    var id = c.MarkedOrigin;

                    if (id != null)
                    {
                        var range = new Range(codeTextBox,
                            id.Position - 1, id.Line - 1, id.Position + id.Text.Length - 1, id.Line - 1);

                        range.SetStyle(labelSquiggly);
                        labelSquiggly.Add(id.Line - 1, variable);
                    }
                }
            }

            constraintList.Items.Clear();
            foreach (var c in result.ResolveSteps)
                if (c.Success)
                    constraintList.Items.Add(new InferenceStepView(c));
                else
                    constraintList.Items.Add(new InferenceStepErrorView(c));
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
