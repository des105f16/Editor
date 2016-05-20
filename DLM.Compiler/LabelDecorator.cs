using DLM.Compiler.Analysis;
using System.Collections.Generic;
using System.Linq;
using DLM.Compiler.Nodes;
using DLM.Inference;
using SablePP.Tools.Error;
using SablePP.Tools;

namespace DLM.Compiler
{
    public class LabelDecorator : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private Dictionary<string, Principal> principals;
        private ScopedDictionary<string, Label> namedLabels;

        private Dictionary<string, PStruct> structTypedefs;
        private ScopedDictionary<string, PStruct> structDeclarations;

        public LabelDecorator(ErrorManager errorManager, Dictionary<string, Principal> principals)
        {
            this.errorManager = errorManager;
            this.principals = principals;
            this.namedLabels = new ScopedDictionary<string, Label>();

            this.structTypedefs = new Dictionary<string, PStruct>();
            this.structDeclarations = new ScopedDictionary<string, PStruct>();
        }

        protected override void HandlePRoot(PRoot node)
        {
            Visit(node.Structs);
            Visit(node.Statements);
        }

        protected override void HandlePStruct(PStruct node)
        {
            foreach (var field in node.Fields)
            {
                Visit(field.Type);

                if (field.Type.DeclaredLabel == null)
                    field.Type.DeclaredLabel = Label.LowerBound;
            }

            structTypedefs.Add(node.Name.Text, node);
        }

        private AType getType(PType type)
        {
            while (type is APointerType)
                type = (type as APointerType).Type;
            return type as AType;
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            namedLabels.OpenScope();
            structDeclarations.OpenScope();

            foreach (var r in node.Readers)
                Visit(r);

            Visit(node.Parameters);

            Visit(node.Type);
            if (node.Type.DeclaredLabel == null)
            {
                var funcLabel = Label.LowerBound;
                foreach (var p in node.Parameters)
                    funcLabel += p.Type.DeclaredLabel;

                node.Type.DeclaredLabel = funcLabel;
            }

            if (errorManager.Errors.Count > 0)
            {
                namedLabels.CloseScope();
                return;
            }

            Visit(node.Statements);

            namedLabels.CloseScope();
            structDeclarations.CloseScope();
        }
        protected override void HandleAFunctionParameter(AFunctionParameter node)
        {
            Visit(node.Type);

            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = new ConstantLabel(node.Identifier.Text);

            namedLabels.Add(node.Identifier.Text, node.Type.DeclaredLabel);

            var type = getType(node.Type);
            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }
        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            Visit(node.Type);

            if (node.HasExpression)
                Visit(node.Expression);

            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = new VariableLabel(node.Identifier.Text);

            namedLabels.Add(node.Identifier.Text, node.Type.DeclaredLabel);

            var type = getType(node.Type);
            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            Visit(node.Type);

            if (node.Type.DeclaredLabel == null)
                node.Type.DeclaredLabel = new VariableLabel(node.Identifier.Text);

            namedLabels.Add(node.Identifier.Text, node.Type.DeclaredLabel);

            var type = getType(node.Type);
            if (structTypedefs.ContainsKey(type.Name.Text))
                structDeclarations.Add(node.Identifier.Text, structTypedefs[type.Name.Text]);
        }

        protected override void HandleAElementExpression(AElementExpression node)
        {
            var expr = (node.Expression as AIndexExpression)?.Expression ?? node.Expression;

            if (expr is AIdentifierExpression)
            {
                var identExpr = expr as AIdentifierExpression;
                node.FieldTypeDecl = structDeclarations[identExpr.Identifier.Text].Fields.First(x => x.Identifier.Text == node.Element.Identifier.Text);
            }
            else
                errorManager.Register(node.Expression, "Struct field access must be of form id.id or id[exp].id.");
        }

        protected override void HandleAType(AType node)
        {
            if (node.HasLabel)
                Visit(node.Label);

            node.DeclaredLabel = node.Label?.LabelValue;
        }
        protected override void HandleAPointerType(APointerType node)
        {
            Visit(node.Type);

            node.DeclaredLabel = node.Type.DeclaredLabel;
        }

        protected override void HandlePLabel(PLabel node)
        {
            Label lbl = Label.LowerBound;

            foreach (var p in node.Policys)
            {
                Visit(p);
                Label plbl = Output[p] as Label;

                if (plbl != null)
                    lbl += plbl;
            }

            node.LabelValue = lbl;
        }
        protected override void HandleAVariablePolicy(AVariablePolicy node)
        {
            Label lbl;
            if (!namedLabels.TryGetValue(node.Identifier.Text, out lbl, false))
            {
                errorManager.Register(node, $"Unknown variable reference \"{node.Identifier.Text}\".");
                Output[node] = null;
            }
            else
                Output[node] = lbl;
        }
        protected override void HandleAPrincipalPolicy(APrincipalPolicy node)
        {
            Visit(node.Owner);
            var owner = node.Owner.DeclaredPrincipal;

            List<Principal> readers = new List<Principal>();
            foreach (var reader in node.Readers)
            {
                Visit(reader);
                if (reader.DeclaredPrincipal != null)
                    readers.Add(reader.DeclaredPrincipal);
            }

            if (errorManager.Errors.Count == 0)
                Output[node] = new PolicyLabel(new Policy(owner, readers));
        }
        protected override void HandleALowerPolicy(ALowerPolicy node)
        {
            Output[node] = Label.LowerBound;
        }
        protected override void HandleAUpperPolicy(AUpperPolicy node)
        {
            Output[node] = Label.UpperBound;
        }

        protected override void HandlePPrincipal(PPrincipal node)
        {
            Principal principal;
            string name = node.Identifier.Text;

            if (!principals.TryGetValue(name, out principal))
                errorManager.Register(node, $"Use of undeclared principal {name}.");
            else
                node.DeclaredPrincipal = principal;
        }
    }
}
