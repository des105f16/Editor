using DLM.Inference;

namespace DLM.Compiler.Nodes
{
    public partial class PType
    {
        private Label label;

        public Label DeclaredLabel
        {
            get { return label; }
            set { label = value; }
        }
    }
}
