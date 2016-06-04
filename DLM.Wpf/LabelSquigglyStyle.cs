using DLM.Inference;
using System.Collections.Concurrent;
using FastColoredTextBoxNS;
using System.Drawing;
using System;
using System.Text.RegularExpressions;

namespace DLM.Wpf
{
    public class LabelSquigglyStyle : Style
    {
        private ConcurrentDictionary<int, VariableLabel> labels;

        public LabelSquigglyStyle()
        {
            this.labels = new ConcurrentDictionary<int, VariableLabel>();
        }

        public void Add(int line, VariableLabel label)
        {
            this.labels.TryAdd(line, label);
        }
        public void Clear()
        {
            labels.Clear();
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            int iLine = range.Start.iLine;
            var line = range.tb.GetLine(range.Start.iLine);

            position.X += (line.End.iChar - range.Start.iChar + 1) * range.tb.CharWidth;

            VariableLabel label;
            if (labels.TryGetValue(iLine, out label))
            {
                using (var dc = new DrawContext(gr, range.tb.Font, new Size(range.tb.CharWidth, range.tb.CharHeight), position))
                    dc.Draw(label);
                return;
            }
        }

        public class DrawContext : IDisposable
        {
            private readonly Graphics g;
            private readonly Font font;
            private readonly Font underlined;
            private readonly Brush defaultBrush;
            private readonly Size charSize;
            private PointF position;

            public DrawContext(Graphics graphics, Font font, Size charSize, Point point)
            {
                this.g = graphics;
                this.font = new Font(font, FontStyle.Regular);
                this.underlined = new Font(font, FontStyle.Underline);
                this.defaultBrush = new SolidBrush(Color.FromArgb(120, 175, 175, 10));
                this.charSize = charSize;
                this.position = point;
            }

            public void DrawString(string str, Brush brush = null, Font font = null)
            {
                g.DrawString(str, font ?? this.font, brush ?? defaultBrush, position);
                position.X += charSize.Width * str.Length;
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

                position.X += 6;
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
                position.X += 14;

                Draw((dynamic)label.Label2);
            }
            public void Draw(MeetLabel label)
            {
                Draw((dynamic)label.Label1);

                position.X += 6;
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
                position.X += 14;

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

            public void Dispose()
            {
                font.Dispose();
                underlined.Dispose();
            }
        }
    }
}
