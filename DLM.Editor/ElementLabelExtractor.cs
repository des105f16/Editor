using DLM.Editor.Analysis;
using DLM.Editor.Nodes;
using SablePP.Tools;
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
        private Dictionary<string, PStruct> structTypedefs;
        private ScopedDictionary<string, PStruct> structDeclarations;

        public ElementLabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
            this.structTypedefs = new Dictionary<string, PStruct>();
            this.structDeclarations = new ScopedDictionary<string, PStruct>();
        }

        protected override void HandlePStruct(PStruct node)
        {
            structTypedefs.Add(node.Name.Text, node);
        }

        protected override void HandleAElementExpression(AElementExpression node)
        {
            if (!(node.Expression is AIndexExpression))
                errorManager.Register(node.Expression, "Struct array field access must be of form id[exp].id");
        }

        protected override void HandleAIndexExpression(AIndexExpression node)
        {
            if (!(node.Expression is AIdentifierExpression))
                errorManager.Register(node.Expression, "Array access must be of form id[exp]");
        }
    }
}
