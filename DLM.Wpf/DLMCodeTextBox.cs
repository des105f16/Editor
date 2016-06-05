using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastColoredTextBoxNS;

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
    }
}
