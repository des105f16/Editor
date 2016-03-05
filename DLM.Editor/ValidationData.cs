using DLM.Inference;
using SablePP.Tools;

namespace DLM.Editor
{
    public class ValidationData
    {
        private ScopedDictionary<string, Principal> principals;
        private ScopedDictionary<string, Label> labels;

        public ValidationData()
        {
            this.principals = new ScopedDictionary<string, Principal>();
            this.labels = new ScopedDictionary<string, Label>();
        }

        public ScopedDictionary<string, Principal> Principals => principals;
        public ScopedDictionary<string, Label> Labels => labels;
    }
}
