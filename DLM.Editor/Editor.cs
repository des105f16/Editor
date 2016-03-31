using DLM.Compiler;
using DLM.Inference;
using FastColoredTextBoxNS;
using SablePP.Tools.Editor;
using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DLM.Editor
{
    public partial class Editor : SablePP.Tools.Editor.EditorForm
    {
        private Font titleFont = new Font("Segoe UI", 10f, FontStyle.Regular);
        private Font titleStateFont = new Font("Segoe UI", 10.5f, FontStyle.Bold);
        private Font titleVariableFont = new Font("Consolas", 12f, FontStyle.Bold);

        private Font infoFont = new Font("Segoe UI Symbol", 10.5f, FontStyle.Regular);

        private SquigglyStyle labelSquiggly = new SquigglyStyle(Pens.Orange);

        public Editor()
        {
            InitializeComponent();

            codeTextBox1.Executer = new CompilerExecuter();
            FileExtension = ".ncif";
            Text = "Not CIF";

            HookEditToTextBox(codeTextBox1);

            codeTextBox1.CompilationCompleted += CodeTextBox_CompilationCompleted;
            codeTextBox1.TextChanged += (s, e) => base.MarkFileAsChanged();
            codeTextBox1.ToolTipNeeded += CodeTextBox1_ToolTipNeeded;
        }

        private Dictionary<Range, string> labelTooltips = new Dictionary<Range, string>();
        private void CodeTextBox1_ToolTipNeeded(object sender, ToolTipNeededEventArgs e)
        {
            foreach (var r in labelTooltips.Keys)
                if (r.Contains(e.Place))
                {
                    e.ToolTipText = labelTooltips[r];
                    break;
                }
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

            codeTextBox1.Range.ClearStyle(labelSquiggly);
            labelTooltips.Clear();
            listBox1.Items.Clear();

            if (result == null)
                return;

            if (result.Succes)
            {
                foreach (var c in result.OriginalConstraints)
                {
                    if (!(c.Right is VariableLabel && c.OriginType == NodeConstraint.OriginTypes.Declaration))
                        continue;

                    var variable = c.Right as VariableLabel;
                    
                    if (c.Origin is Compiler.Nodes.ADeclarationStatement)
                    {
                        var id = (c.Origin as Compiler.Nodes.ADeclarationStatement).Identifier;
                        var range = new Range(codeTextBox1,
                            id.Position - 1, id.Line - 1, id.Position + id.Text.Length - 1, id.Line - 1);

                        range.SetStyle(labelSquiggly);
                        labelTooltips.Add(range, variable.CurrentUpperBound.NoVariables.ToString());
                    }
                    else
                        throw new NotImplementedException();
                }


                foreach (var v in result.Variables)
                    listBox1.Items.Add(v);
            }

            foreach (var v in result.ResolveSteps)
                listBox1.Items.Add(v);
        }

        private void measureItem(object sender, MeasureItemEventArgs e)
        {
            var item = listBox1.Items[e.Index];

            if (item is NodeConstraint)
                MeasureConstraint(item as NodeConstraint, e);
            if (item is VariableLabel)
                MeasureVariable(item as VariableLabel, e);
        }
        private void drawItem(object sender, DrawItemEventArgs e)
        {
            var item = listBox1.Items[e.Index];

            if (item is NodeConstraint)
                DrawConstraint(item as NodeConstraint, e.State.HasFlag(DrawItemState.Focus), e);
            if (item is VariableLabel)
                DrawVariable(item as VariableLabel, e.State.HasFlag(DrawItemState.Focus), e);
        }

        private Color ok = Color.FromArgb(0xcaf0c2 + (0xff << 24));
        private Color okFocus = Color.FromArgb(0x79d966 + (0xff << 24));
        private Color error = Color.FromArgb(0xf5cccc + (0xff << 24));
        private Color errorFocus = Color.FromArgb(0xe06666 + (0xff << 24));

        private void MeasureConstraint(NodeConstraint constraint, MeasureItemEventArgs e)
        {
            e.ItemHeight = 68 + 17;
        }
        private void DrawConstraint(NodeConstraint constraint, bool selected, DrawItemEventArgs e)
        {
            var bounds = e.Bounds; bounds.Height -= 2;

            var valid = constraint.Left <= constraint.Right;
            var isVariable = constraint.Left is VariableLabel;

            using (var brush = new SolidBrush(valid ? (selected ? okFocus : ok) : (selected ? errorFocus : error)))
                e.Graphics.FillRectangle(brush, bounds);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (var brush = new SolidBrush(Color.FromArgb(204, Color.Black)))
                e.Graphics.DrawString("Constraint:", titleFont, brush, bounds.X + 5, bounds.Y + 4);

            e.Graphics.DrawString(
                valid ? "OK" : "Error" + (!isVariable ? " (non-variable)" : "")
                , titleStateFont, Brushes.Black, bounds.X + 70, bounds.Y + 3);

            var point = new PointF(bounds.X + 14, bounds.Y + 23);

            e.Graphics.DrawString($"{constraint.Left} ⊑ {constraint.Right}", infoFont, Brushes.Black, point);
            point.Y += 15;
            if (constraint.Left is VariableLabel)
                e.Graphics.DrawString($"{constraint.Left} = {constraint.Left.NoVariables}", infoFont, Brushes.Black, point);
            else
                e.Graphics.DrawString($"{constraint.Left.NoVariables} ⊑ {constraint.Right.NoVariables}", infoFont, Brushes.Black, point);

            point.Y += 17;
            var first = FirstToken.Find(constraint.Origin);
            var type = constraint.OriginType.ToString().ToLower();
            e.Graphics.DrawString($"Line: {first.Line} (from {type})", infoFont, Brushes.Black, point);
        }

        private class FirstToken : SablePP.Tools.Analysis.DepthFirstTreeWalker
        {
            private Token token = null;

            public static Token Find(Node node)
            {
                var finder = new FirstToken();
                finder.Visit(node);
                return finder.token;
            }
            public static Token Find(IEnumerable<Node> nodes)
            {
                return Find(nodes.First());
            }

            private FirstToken() { }

            public override void Visit(Production production)
            {
                if (this.token == null)
                    base.Visit(production);
            }
            public override void Visit(Token token)
            {
                if (this.token == null)
                    this.token = token;
            }
        }

        private Color var = Color.FromArgb(0xcee8ef + (0xff << 24));
        private Color varFocus = Color.FromArgb(0x84c5d8 + (0xff << 24));

        private void MeasureVariable(VariableLabel label, MeasureItemEventArgs e)
        {
            e.ItemHeight = 53;
        }
        private void DrawVariable(VariableLabel label, bool selected, DrawItemEventArgs e)
        {
            var bounds = e.Bounds; bounds.Height -= 2;

            using (var brush = new SolidBrush(selected ? varFocus : var))
                e.Graphics.FillRectangle(brush, bounds);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (var brush = new SolidBrush(Color.FromArgb(204, Color.Black)))
                e.Graphics.DrawString("Variable:", titleFont, brush, bounds.X + 5, bounds.Y + 4);
            e.Graphics.DrawString(label.Name, titleVariableFont, Brushes.Black, bounds.X + 57, bounds.Y + 3);

            var point = new PointF(bounds.X + 14, bounds.Y + 23);

            e.Graphics.DrawString(label.NoVariables.ToString(), infoFont, Brushes.Black, point);
        }

        private float measureWidth(Graphics graphics, string text)
        {
            StringFormat format = new StringFormat();
            format.SetMeasurableCharacterRanges(new CharacterRange[] { new CharacterRange(0, text.Length) });
            var rectangle = graphics.MeasureCharacterRanges(text, infoFont, new RectangleF(0, 0, 1000, 1000), format)[0].GetBounds(graphics);
            return rectangle.Width;
        }
    }
}
