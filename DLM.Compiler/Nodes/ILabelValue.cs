using DLM.Inference;
using SablePP.Tools.Nodes;

namespace DLM.Compiler.Nodes
{
    public interface ILabelValue
    {
        Label LabelValue { get; }
    }

    public static class LabelValueExtension
    {
        public static Label GetFirstLabelValue(this Node node)
        {
            if (ReferenceEquals(node, null))
                return null;
            else if (node is ILabelValue)
                return (node as ILabelValue).LabelValue;
            else
                return GetFirstLabelValue(node.GetParent());
        }
    }
}
