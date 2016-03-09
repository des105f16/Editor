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
            AIdentifierExpression identExpr;
            if (node.Expression is AIndexExpression)
            {
                var indexExpr = ((AIndexExpression)node.Expression);

                if (!(indexExpr.Expression is AIdentifierExpression))
                    errorManager.Register(indexExpr, "Array access (on struct fields) must be of form id[exp].");
                if (!(indexExpr.Expression is AIdentifierExpression))
                    return;

                identExpr = ((AIdentifierExpression)indexExpr.Expression);
            }
            else if (node.Expression is AIdentifierExpression)
            {
                identExpr = ((AIdentifierExpression)node.Expression);
            }
            else
            {
                errorManager.Register(node.Expression, "Struct field access must be of form id.id or id[exp].id.");
                return;
            }

            node.FieldTypeDecl = structDeclarations[identExpr.Identifier.Text].Fields.First(x => x.Identifier.Text == node.Element.Identifier.Text);
        }
    }
}
