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

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            structDeclarations.OpenScope();

            Visit(node.Parameters);
            Visit(node.Statements);

            structDeclarations.CloseScope();
        }

        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            var type = node.Type;
            while (type is APointerType)
            {
                type = (type as APointerType).Type;
            }
            var newType = (AType)type;

            if (node.HasExpression)
                Visit(node.Expression);

            if (structTypedefs.ContainsKey(newType.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[newType.Name.Text]);
        }

        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            var type = node.Type;
            while (type is APointerType)
                type = (type as APointerType).Type;

            var newType = (AType)type;

            if (structTypedefs.ContainsKey(newType.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[newType.Name.Text]);
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
