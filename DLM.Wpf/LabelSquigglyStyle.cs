using DLM.Inference;
using System.Collections.Concurrent;
using FastColoredTextBoxNS;
using System.Drawing;

namespace DLM.Wpf
{
    public class LabelSquigglyStyle : SablePP.Tools.Editor.SquigglyStyle
    {
        private ConcurrentDictionary<int, Label> labels;

        public LabelSquigglyStyle() : base(System.Drawing.Pens.Orange)
        {
            this.labels = new ConcurrentDictionary<int, Label>();
        }

        public void Add(int line, Label label)
        {
            this.labels.TryAdd(line, label);
        }
        public void Clear()
        {
            labels.Clear();
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            base.Draw(gr, position, range);

            int iLine = range.Start.iLine;
            var line = range.tb.GetLine(range.Start.iLine);

            position.X += (line.End.iChar - range.Start.iChar + 1) * range.tb.CharWidth;

            Label label;
            if (labels.TryGetValue(iLine, out label))
            {
                var str = label.NoVariables.ToString();
                gr.DrawString(str, range.tb.Font, Brushes.Orange, position);
            }
        }
    }
}
