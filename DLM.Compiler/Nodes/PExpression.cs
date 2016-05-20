using DLM.Inference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Compiler.Nodes
{
    public partial class PExpression
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
}
