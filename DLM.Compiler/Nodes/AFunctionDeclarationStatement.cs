﻿using DLM.Inference;

namespace DLM.Compiler.Nodes
{
    public partial class AFunctionDeclarationStatement : ILabelValue
    {
        private Label labelValue;

        public Label LabelValue
        {
            get { return labelValue; }
            set { labelValue = value; }
        }
    }
}
