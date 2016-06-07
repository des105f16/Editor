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
        private readonly SolidBrush toolTipLabelBrush;
        private readonly SolidBrush toolTipVarLabelBrush;

        private readonly Color forecolor = Color.FromArgb(220, 220, 220);
        private readonly Color backcolor = Color.FromArgb(30, 30, 30);
        private readonly Color disabledbackcolor = Color.FromArgb(35, 35, 35);
        private readonly Color linenumbers = Color.FromArgb(36, 126, 175);

        private readonly Color selectionColor = Color.FromArgb(50, 0, 142, 183);
        private readonly Color currentline = Color.FromArgb(12, 12, 12);

        private readonly Font font = new Font("Consolas", 10f, FontStyle.Regular);

        private readonly LabelState state;
        private LabelDrawer draw;
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

            toolTipLabelBrush = new SolidBrush(forecolor);
            toolTipVarLabelBrush = new SolidBrush(Color.FromArgb(180, forecolor));

            state = new LabelState(this);
            draw = new LabelDrawer(this, new Size(CharWidth, CharHeight));
            mark = new SelectionStyle(new SolidBrush(Color.FromArgb(90, 0, 142, 183)));

            this.Paint += DLMCodeTextBox_Paint;
        }

        private void DLMCodeTextBox_Paint(object sender, PaintEventArgs e)
        {
            if (state.Label != null)
            {
                var lbl = state.Label;
                var noVar = lbl.NoVariables;

                var equal = lbl.Equals(noVar);

                float width;

                if (equal)
                    width = draw.GetWidth(noVar);
                else
                    width = draw.GetWidth(lbl) + CharWidth * 3 + draw.GetWidth(noVar);

                var pos = Cursor.Position - new Size((int)width / 2, 35);
                pos = PointToClient(pos);

                Rectangle box = new Rectangle(pos.X, pos.Y, (int)width, CharHeight);
                var b2 = box;
                box.Inflate(10, 5);

                drawBox(e.Graphics, box);

                pos = pos - new Size(1, 1);

                if (equal)
                    draw.DrawLabel(e.Graphics, toolTipLabelBrush, noVar, pos);
                else
                {
                    draw.DrawLabel(e.Graphics, toolTipVarLabelBrush, lbl, pos);
                    pos.X += (int)draw.GetWidth(lbl);
                    e.Graphics.DrawString(" = ", Font, toolTipVarLabelBrush, pos);
                    pos.X += CharWidth * 3;
                    draw.DrawLabel(e.Graphics, toolTipLabelBrush, noVar, pos);
                }
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
                        Label = value.GetFirstLabelValue();

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
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y - 3, 14, 15), new Rectangle(0, 0, 14, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y - 3, 14, 15), new Rectangle(15, 0, 14, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y + box.Height - 5, 14, 15), new Rectangle(0, 16, 14, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y + box.Height - 5, 14, 15), new Rectangle(15, 16, 14, 15), GraphicsUnit.Pixel);

            //T; B; L; R
            graphics.DrawImage(img, new Rectangle(box.X + 11, box.Y - 3, box.Width - 16, 15), new Rectangle(14, 0, 1, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + 11, box.Y + box.Height - 5, box.Width - 16, 15), new Rectangle(14, 16, 1, 15), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X - 3, box.Y + 12, 14, box.Height - 17), new Rectangle(0, 15, 14, 1), GraphicsUnit.Pixel);
            graphics.DrawImage(img, new Rectangle(box.X + box.Width - 5, box.Y + 12, 14, box.Height - 17), new Rectangle(15, 15, 14, 1), GraphicsUnit.Pixel);

            graphics.DrawImage(img, new Rectangle(box.X + 11, box.Y + 12, box.Width - 16, box.Height - 17), new Rectangle(14, 15, 1, 1), GraphicsUnit.Pixel);
        }
    }
}
