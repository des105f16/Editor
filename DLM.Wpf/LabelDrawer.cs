using DLM.Inference;
using System.Drawing;

namespace DLM.Wpf
{
    public class LabelDrawer
    {
        private readonly Font font;
        private readonly Font underlined;
        private readonly Brush defaultBrush;
        private readonly Size charSize;

        public LabelDrawer(Font font, Size charSize)
        {
            this.font = new Font(font, FontStyle.Regular);
            this.underlined = new Font(font, FontStyle.Underline);
            this.defaultBrush = new SolidBrush(Color.FromArgb(120, 175, 175, 10));
            this.charSize = charSize;
        }

        private class Context
        {
            private readonly Font font;
            private readonly Font underlined;
            private readonly Brush defaultBrush;
            private readonly Size charSize;

            private readonly Graphics g;
            private float x;
            private readonly float y;
            private PointF position => new PointF(x, y);

            public Context(LabelDrawer drawer, Graphics graphics, PointF point)
            {
                font = drawer.font;
                underlined = drawer.underlined;
                defaultBrush = drawer.defaultBrush;
                charSize = drawer.charSize;

                g = graphics;
                x = point.X;
                y = point.Y;
            }

            public void DrawString(string str, Brush brush = null, Font font = null)
            {
                g.DrawString(str, font ?? this.font, brush ?? defaultBrush, position);
                x += charSize.Width * str.Length;
            }

            public void Draw(VariableLabel label)
            {
                var name = label.Name;

                DrawString(name, font: underlined);
                DrawString(" = ");

                Draw((dynamic)label.NoVariables);
            }

            public void Draw(JoinLabel label)
            {
                Draw((dynamic)label.Label1);

                x += 6;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                using (var pen = new Pen(defaultBrush))
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
                using (var pen = new Pen(defaultBrush))
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

            public void Draw(ConstantLabel label)
            {
                DrawString(label.Name, font: underlined);
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
                DrawString(label.ToString());
            }
            public void Draw(LowerBoundLabel label)
            {
                DrawString(label.ToString());
            }
        }
    }
}
