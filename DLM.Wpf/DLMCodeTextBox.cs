using System.Drawing;
using FastColoredTextBoxNS;
using System.Windows.Forms;
using SablePP.Tools.Nodes;
using DLM.Compiler.Nodes;
using DLMLabel = DLM.Inference.Label;

namespace DLM.Wpf
{
    public class DLMCodeTextBox : SablePP.Tools.Editor.CodeTextBox
    {
        private readonly Color forecolor = Color.FromArgb(220, 220, 220);
        private readonly Color backcolor = Color.FromArgb(30, 30, 30);
        private readonly Color disabledbackcolor = Color.FromArgb(35, 35, 35);
        private readonly Color linenumbers = Color.FromArgb(36, 126, 175);

        private readonly Color selectionColor = Color.FromArgb(50, 0, 142, 183);
        private readonly Color currentline = Color.FromArgb(12, 12, 12);

        private readonly Font font = new Font("Consolas", 10f, FontStyle.Regular);

        private readonly LabelState state;
        private readonly SelectionStyle mark;

        public DLMCodeTextBox()
            : base()
        {
            BackColor = backcolor;
            ServiceLinesColor = backcolor;
            IndentBackColor = backcolor;
            LineNumberColor = linenumbers;
            CaretColor = forecolor;
            ForeColor = forecolor;
            SelectionColor = selectionColor;
            Font = font;
            DisabledColor = disabledbackcolor;

            state = new LabelState(this);
            mark = new SelectionStyle(new SolidBrush(Color.FromArgb(90, 0, 142, 183)));

            this.Paint += DLMCodeTextBox_Paint;
        }

        private void DLMCodeTextBox_Paint(object sender, PaintEventArgs e)
        {
            if (state.Label != null)
            {
                var pos = Cursor.Position + new Size(5, -30);
                pos = PointToClient(pos);

                var str = state.Label.ToString();

                var size = e.Graphics.MeasureString(str, font);
                Rectangle box = new Rectangle(pos.X, pos.Y, (int)size.Width, (int)size.Height);
                box.Inflate(10, 3);

                drawBox(e.Graphics, box);
                e.Graphics.DrawString(str, font, Brushes.White, pos);
            }
        }

        private class LabelState
        {
            private readonly DLMCodeTextBox o;

            private Token token;
            private Node node;
            private DLMLabel label;

            public LabelState(DLMCodeTextBox owner)
            {
                this.o = owner;
            }

            private Node getLabelNode(Token token)
            {
                var parent = token.GetParent();

                var expr = token.GetFirstParent<PExpression>();
                if (expr != null)
                    return expr;

                if (parent is ADeclarationStatement ||
                    parent is AArrayDeclarationStatement ||
                    parent is AAssignmentStatement)
                    return token;

                if (token is TIf || token is TWhile)
                    return token;

                return null;
            }

            public Token Token
            {
                get { return token; }
                set
                {
                    if (value == token)
                        return;

                    token = value;

                    if (value == null)
                        Node = null;
                    else
                        Node = getLabelNode(value);
                }
            }
            public Node Node
            {
                get { return node; }
                private set
                {
                    if (value == node)
                        return;

                    if (node != null)
                        o.RangeFromNode(node).ClearStyle(o.mark);
                    if (value != null)
                        o.RangeFromNode(value).SetStyle(o.mark);

                    node = value;

                    if (value == null)
                        Label = null;
                    else
                        Label = value.GetFirstLabelValue().NoVariables;

                    o.Invalidate();
                }
            }
            public DLMLabel Label
            {
                get { return label; }
                private set
                {
                    label = value;

                    o.Invalidate();
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var place = PointToPlace(e.Location);
            place.iChar += place.iChar <= 0 ? 0 : 1;

            var token = TokenFromPlace(place);

            state.Token = token;

            base.OnMouseMove(e);
        }

        protected override void OnPaintLine(PaintLineEventArgs e)
        {
            base.OnPaintLine(e);

            if (SelectionLength == 0 && Selection.Start.iLine == e.LineIndex)
            {
                var rect = e.LineRect;
                rect.X -= 5;
                rect.Height++;

                var mode = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                using (SolidBrush b = new SolidBrush(Color.FromArgb(255, 40, 40, 40)))
                    e.Graphics.FillRectangle(b, rect);

                rect.Inflate(-2, -2);

                using (SolidBrush b = new SolidBrush(Color.FromArgb(255, 15, 15, 15)))
                    e.Graphics.FillRectangle(b, rect);

                e.Graphics.SmoothingMode = mode;
            }
        }

        private void drawBox(Graphics graphics, Rectangle box)
        {
            var img = Properties.Resources.labeltooltip;

            //TL; TR; BL; BR
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y - 3, 13, 14), new Rectangle(0, 0, 13, 14), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y - 3, 14, 14), new Rectangle(14, 0, 14, 14), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y + box.Height - 5, 13, 15), new Rectangle(0, 15, 13, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y + box.Height - 5, 14, 15), new Rectangle(14, 15, 14, 15), GraphicsUnit.Pixel);

            //T; B; L; R
            graphics.DrawImage(img, new Rectangle(box.X + 10, box.Y - 3, box.Width - 15, 14), new Rectangle(13, 0, 1, 14), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + 10, box.Y + box.Height - 5, box.Width - 15, 15), new Rectangle(13, 15, 1, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y + 11, 13, box.Height - 16), new Rectangle(0, 14, 13, 1), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y + 11, 14, box.Height - 16), new Rectangle(14, 14, 14, 1), GraphicsUnit.Pixel);

            graphics.DrawImage(img, new Rectangle(box.X + 10, box.Y + 11, box.Width - 15, box.Height - 16), new Rectangle(13, 14, 1, 1), GraphicsUnit.Pixel);
        }
    }
}
