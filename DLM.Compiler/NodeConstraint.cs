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
        private Node origin;

        public NodeConstraint(Label left, Label right, Node origin) : base(left, right)
        {
            this.origin = origin;
        }

        public Node Origin => origin;
    }
}
