using DLM.Editor.Analysis;
using DLM.Editor.Nodes;
using SablePP.Tools.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor
{
    public class ElementLabelExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private Dictionary<string, PStruct> structs;

        public ElementLabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
            this.structs = new Dictionary<string, PStruct>();
        }

        protected override void HandleAElementExpression(AElementExpression node)
        {
            if (!(node.Expression is AIndexExpression))
                errorManager.Register(node.Expression, "Array accessor must be of form id[index]");
        }
    }
}
