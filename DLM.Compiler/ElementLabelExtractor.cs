using DLM.Compiler.Analysis;
using DLM.Compiler.Nodes;
using SablePP.Tools;
using SablePP.Tools.Error;
using System.Collections.Generic;
using System.Linq;

namespace DLM.Compiler
{
    public class ElementLabelExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;

        public ElementLabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
        }

        protected override void HandleAFunctionParameter(AFunctionParameter node)
        {
            var type = getType(node.Type);

            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }
        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            var type = getType(node.Type);

            if (node.HasExpression)
                Visit(node.Expression);

            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            var type = getType(node.Type);

            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }

        private AType getType(PType type)
        {
            while (type is APointerType)
                type = (type as APointerType).Type;
            return type as AType;
        }

        protected override void HandlePStruct(PStruct node)
        {
            structTypedefs.Add(node.Name.Text, node);
        }

        protected override void HandleAElementExpression(AElementExpression node)
        {
            var expr = node.Expression;

            if (expr is AIndexExpression)
                expr = (expr as AIndexExpression).Expression;

            if(expr is AIdentifierExpression)
            {
                var identExpr = expr as AIdentifierExpression;
                node.FieldTypeDecl = structDeclarations[identExpr.Identifier.Text].Fields.First(x => x.Identifier.Text == node.Element.Identifier.Text);
            }
            else
                errorManager.Register(node.Expression, "Struct field access must be of form id.id or id[exp].id.");
        }
    }
}
