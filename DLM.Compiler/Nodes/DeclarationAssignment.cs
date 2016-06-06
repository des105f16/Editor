using DLM.Inference;

namespace DLM.Compiler.Nodes
{
    public partial class ADeclarationStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
    public partial class AArrayDeclarationStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
    public partial class AAssignmentStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
}
