using DLM.Inference;
using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Compiler
{
    public class NodeConstraint : Constraint
    {
        public enum OriginTypes
        {
            Declaration,
            Assignment,
            IfBlock,
            WhileBlock,
            Return,
            Declassify,
            Argument
        }

        private readonly Node origin;
        private readonly OriginTypes originType;

        public NodeConstraint(Label left, Label right, Node origin, OriginTypes originType) : base(left, right)
        {
            this.origin = origin;
            this.originType = originType;
        }

        public Node Origin => origin;
        public OriginTypes OriginType => originType;
    }
}
