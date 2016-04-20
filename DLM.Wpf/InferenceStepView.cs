using DLM.Compiler;
using DLM.Inference;
using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Wpf
{
    public class InferenceStepView
    {
        private ConstraintResolver<NodeConstraint>.Step step;

        public InferenceStepView(ConstraintResolver<NodeConstraint>.Step step)
        {
            this.step = step;
        }

        public string VariableName => step.Constraint.Left.ToString();

        public Label CurrentUpper => step.Left.NoVariables;
        public Label MeetWith => step.Right;
        public Label Result => step.Result;

        public string SourceType => step.Constraint.OriginType.ToString().ToLowerInvariant();
        public int Line
        {
            get
            {
                return step.Constraint.MarkedOrigin.FirstToken().Line;
            }
        }
    }
}
