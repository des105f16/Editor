using DLM.Inference;
using System.Drawing;

namespace DLM.Wpf
{
    public class LabelDrawer
    {
        private readonly FastColoredTextBoxNS.FastColoredTextBox textBox;
        private readonly Size charSize;

        public LabelDrawer(FastColoredTextBoxNS.FastColoredTextBox textBox, Size charSize)
        {
            this.textBox = textBox;
            this.charSize = charSize;
        }

        public void DrawLabel(Graphics graphics, Brush brush, Label label, PointF location)
        {
            Context ct = new Context(this, brush, graphics, location);
            ct.Draw((dynamic)label);
        }

        public float GetWidth(Label label)
        {
            return getWidth((dynamic)label);
        }

        private float getWidth(string s) => (s?.Length ?? 0) * charSize.Width;

        private float getWidth(JoinLabel label)
        {
            float w = charSize.Width + 12;

            w += getWidth((dynamic)label.Label1);
            w += getWidth((dynamic)label.Label2);

            return w;
        }
        private float getWidth(MeetLabel label)
        {
            float w = charSize.Width + 12;

            w += getWidth((dynamic)label.Label1);
            w += getWidth((dynamic)label.Label2);

            return w;
        }

        private float getWidth(VariableLabel label) => getWidth(label.Name);
        private float getWidth(ConstantLabel label) => getWidth(label.Name);

        private float getWidth(PolicyLabel label)
        {
            int count = 2;
            for (int i = 0; i < label.Count; i++)
            {
                var p = label[i];
                count += p.Owner.Name.Length + 2;

                if (p.ReaderCount > 0)
                {
                    count += p[0].Name.Length;
                    for (int j = 1; j < label[i].ReaderCount; j++)
                        count += p[j].Name.Length + 1;
                }
                else
                    count++;

                if (i < label.Count - 1)
                    count += 2;
            }
            count += 2;

            return count * charSize.Width;
        }

        private float getWidth(UpperBoundLabel label) => 1 * charSize.Width;
        private float getWidth(LowerBoundLabel label) => 1 * charSize.Width;

        private class Context
        {
            private readonly Font font;
            private readonly Brush brush;
            private readonly Size charSize;

            private readonly Graphics g;
            private float x;
            private readonly float y;
            private PointF position => new PointF(x, y);

            public Context(LabelDrawer drawer, Brush brush, Graphics graphics, PointF point)
            {
                font = drawer.textBox.Font;
                this.brush = brush;
                charSize = drawer.charSize;

                g = graphics;
                x = point.X;
                y = point.Y;
            }

            public void DrawString(string str, Brush brush = null, Font font = null, Size? offset = null)
            {
                var p = position;
                if (offset.HasValue)
                    p += offset.Value;

                g.DrawString(str, font ?? this.font, brush ?? this.brush, p);
                x += charSize.Width * str.Length;
            }

            public void Draw(JoinLabel label)
            {
                Draw((dynamic)label.Label1);

                x += 6;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                using (var pen = new Pen(brush))
                {
                    g.DrawLines(pen, new PointF[]
                    {
                        new PointF(position.X, position.Y + 2),
                        new PointF(position.X, position.Y + charSize.Height - 2),
                        new PointF(position.X + charSize.Width, position.Y + charSize.Height - 2),
                        new PointF(position.X + charSize.Width, position.Y + 2)
                    });
                    g.DrawLines(pen, new PointF[]
                    {
                        new PointF(position.X + 1, position.Y + 2),
                        new PointF(position.X + 1, position.Y + charSize.Height - 3),
                        new PointF(position.X + charSize.Width - 1, position.Y + charSize.Height - 3),
                        new PointF(position.X + charSize.Width - 1, position.Y + 2)
                    });
                }
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                x += 14;

                Draw((dynamic)label.Label2);
            }
            public void Draw(MeetLabel label)
            {
                Draw((dynamic)label.Label1);

                x += 6;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                using (var pen = new Pen(brush))
                {
                    g.DrawLines(pen, new PointF[]
                    {
                        new PointF(position.X, position.Y + charSize.Height - 2),
                        new PointF(position.X, position.Y + 2),
                        new PointF(position.X + charSize.Width, position.Y + 2 ),
                        new PointF(position.X + charSize.Width, position.Y + charSize.Height - 2)
                    });
                    g.DrawLines(pen, new PointF[]
                    {
                        new PointF(position.X + 1, position.Y + charSize.Height - 3),
                        new PointF(position.X + 1, position.Y + 2),
                        new PointF(position.X + charSize.Width - 1, position.Y + 2),
                        new PointF(position.X + charSize.Width - 1, position.Y + charSize.Height - 3)
                    });
                }
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                x += 14;

                Draw((dynamic)label.Label2);
            }

            public void Draw(VariableLabel label)
            {
                using (Pen pen = new Pen(brush))
                    g.DrawLine(pen, x, y + charSize.Height - 1, x + label.Name.Length * charSize.Width, y + charSize.Height - 1);

                DrawString(label.Name);
            }
            public void Draw(ConstantLabel label)
            {
                using (Pen pen = new Pen(brush))
                    g.DrawLine(pen, x, y + 3, x + label.Name.Length * charSize.Width, y + 3);

                DrawString(label.Name);
            }

            public void Draw(PolicyLabel label)
            {
                DrawString("{ ");
                for (int i = 0; i < label.Count; i++)
                {
                    var p = label[i];
                    DrawString(p.Owner.Name + "->");

                    if (p.ReaderCount > 0)
                    {
                        DrawString(p[0].Name);
                        for (int j = 1; j < label[i].ReaderCount; j++)
                            DrawString("," + p[j].Name);
                    }
                    else
                        DrawString("Ø");

                    if (i < label.Count - 1)
                        DrawString("; ");
                }
                DrawString(" }");
            }

            public void Draw(UpperBoundLabel label)
            {
                DrawString(label.ToString(), offset: new Size(-3, 2));
            }
            public void Draw(LowerBoundLabel label)
            {
                DrawString(label.ToString(), offset: new Size(-3, 2));
            }
        }
    }
}
