using DLM.Inference;

namespace DLM.Compiler.Nodes
{
    public partial class AIfStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
    public partial class AIfElseStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
    public partial class AWhileStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
}
