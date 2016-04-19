using DLM.Compiler;
using DLM.Inference;

namespace DLM.Wpf
{
    public class InferenceStepErrorView : InferenceStepView
    {
        public InferenceStepErrorView(ConstraintResolver<NodeConstraint>.Step step) : base(step)
        {
        }
    }
}
