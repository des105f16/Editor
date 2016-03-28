using DLM.Compiler;
using DLM.Inference;
using SablePP.Tools.Editor;
using System;
using System.IO;
using System.Windows.Forms;

namespace DLM.Editor
{
    public partial class Editor : SablePP.Tools.Editor.EditorForm
    {
        public Editor()
        {
            InitializeComponent();

            codeTextBox1.Executer = new CompilerExecuter();
            FileExtension = ".ncif";
            Text = "Not CIF";

            HookEditToTextBox(codeTextBox1);

            codeTextBox1.CompilationCompleted += CodeTextBox_CompilationCompleted;
            codeTextBox1.TextChanged += (s, e) => base.MarkFileAsChanged();
        }

        protected override void OnNewFileCreated(EventArgs e)
        {
            splitContainer1.Enabled = true;

            codeTextBox1.Text = DefaultCode;
            codeTextBox1.Focus();
            codeTextBox1.SelectionLength = 0;
            codeTextBox1.SelectionStart = 0;

            if (codeTextBox1.Text == string.Empty)
                codeTextBox1.OnTextChangedDelayed(codeTextBox1.Range);

            codeTextBox1.ClearUndo();

            base.OnNewFileCreated(e);
        }
        protected override void OnFileOpened(FileOpenedEventArgs e)
        {
            splitContainer1.Enabled = true;

            codeTextBox1.Text = e.Content;
            codeTextBox1.ClearUndo();

            codeTextBox1.Focus();

            if (codeTextBox1.Text == string.Empty)
                codeTextBox1.OnTextChangedDelayed(codeTextBox1.Range);

            base.OnFileOpened(e);
        }
        protected override void OnFileSaving(FileSavingEventArgs e)
        {
            e.Content = codeTextBox1.Text;

            base.OnFileSaving(e);
        }
        protected override void OnFileClosed(EventArgs e)
        {
            splitContainer1.Enabled = false;
            codeTextBox1.Text = "";
            listBox1.Items.Clear();

            base.OnFileClosed(e);
        }
        
        private void EditorForm_DragEnter(object sender, DragEventArgs e)
        {
            var files = GetDraggedFiles(e);
            if (files.Length != 1)
                e.Effect = DragDropEffects.None;
            else
            {
                FileOpeningEventArgs fdea = new FileOpeningEventArgs(files[0], Path.GetExtension(files[0]) == "." + this.FileExtension);
                OnFileOpening(fdea);
                e.Effect = fdea.AllowFile ? DragDropEffects.Move : DragDropEffects.None;
            }
        }
        private void EditorForm_DragDrop(object sender, DragEventArgs e)
        {
            OpenFile(GetDraggedFiles(e)[0]);
        }

        private void CodeTextBox_CompilationCompleted(object sender, EventArgs e)
        {
            var comp = codeTextBox1.Executer as CompilerExecuter;
            var result = comp.Result;

            listBox1.Items.Clear();

            if (result == null)
                return;

            if (result.Succes)
                foreach (var v in result.Variables)
                    listBox1.Items.Add(getString(v));
            else
                listBox1.Items.Add("ERROR");
        }

        private string getString(VariableLabel label)
        {
            return label.Name + " \u2248 " + label.NoVariables.ToString();
        }
    }
}
