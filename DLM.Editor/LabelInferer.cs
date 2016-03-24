using DLM.Editor.Analysis;
using DLM.Inference;
using SablePP.Tools;
using SablePP.Tools.Error;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;
using System.Linq;

namespace DLM.Editor
{
    public class LabelInferer : DepthFirstAdapter
    {
        private List<Constraint> constraints;

        private ErrorManager errorManager;
        private ScopedDictionary<string, PType> types;
        private Dictionary<string, Label> functionLabels;

        private LabelStack authority;
        private LabelStack basicBlock;
        private int blockNameCount;

        public LabelInferer(ErrorManager errorManager)
        {
            constraints = new List<Constraint>();

            this.errorManager = errorManager;
            types = new ScopedDictionary<string, PType>();
            functionLabels = new Dictionary<string, Label>();

            authority = new LabelStack(true);
            basicBlock = new LabelStack(true);
            blockNameCount = 1;
        }

        public Constraint[] Constraints => constraints.ToArray();

        private void Add(Label left, Label right)
        {
            constraints.Add(new Constraint(left + basicBlock, right));
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            var fName = node.Identifier.Text;
            functionLabels.Add(fName, node.Type.DeclaredLabel);

            types.OpenScope();

            foreach (var p in node.Parameters)
                types.Add(p.Identifier.Text, p.Type);

            Visit(node.Statements);

            types.CloseScope();
        }

        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            types.Add(node.Identifier.Text, node.Type);

            Label lbl = node.HasExpression ?
                ExpressionLabeler.GetLabel(node.Expression, this) :
                Label.LowerBound;

            Add(lbl, node.Type.DeclaredLabel);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            types.Add(node.Identifier.Text, node.Type);

            Add(Label.LowerBound, node.Type.DeclaredLabel);
        }
        protected override void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, this);

            var type = types[node.Identifier.Text];

            Add(lbl, type.DeclaredLabel);
        }
        protected override void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            if (node.Claimant is ACallerClaimant)
                errorManager.Register(node.Claimant, ErrorType.Warning, "'caller' keyword not yet implemented.");
            else if (node.Claimant is AThisClaimant)
                errorManager.Register(node.Claimant, ErrorType.Warning, "'this' keyword not yet implemented.");

            foreach (var p in node.Principals)
            {
                var label = new PolicyLabel(
                    new Policy(p.DeclaredPrincipal));
                authority.Push(label);
            }
            Visit(node.Statements);
            authority.Pop();
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl);

            basicBlock.Push(lbl);
            Visit(node.Statements);
            basicBlock.Pop();
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl);

            basicBlock.Push(lbl);
            Visit(node.IfStatements);
            Visit(node.ElseStatements);
            basicBlock.Pop();
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl);

            basicBlock.Push(lbl);
            Visit(node.Statements);
            basicBlock.Pop();
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, this);

            var type = node.GetFirstParent<AFunctionDeclarationStatement>().Type;

            Add(lbl, type.DeclaredLabel);
        }

        private class ExpressionLabeler : ReturnAnalysisAdapter<Label>
        {
            private LabelInferer owner;
            private ScopedDictionary<string, PType> types => owner.types;
            private ErrorManager errorManager => owner.errorManager;
            private Label authority => owner.authority;

            private ExpressionLabeler(LabelInferer owner)
            {
                this.owner = owner;
            }

            public static Label GetLabel(PExpression expression, LabelInferer owner)
            {
                return new ExpressionLabeler(owner).Visit(expression);
            }

            protected override Label HandleDefault(Node node)
            {
                throw new System.NotImplementedException();
            }

            protected override Label HandleAAndExpression(AAndExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleABooleanExpression(ABooleanExpression node) => Label.LowerBound;
            protected override Label HandleAComparisonExpression(AComparisonExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleADeclassifyExpression(ADeclassifyExpression node)
            {
                if (node.HasLabel)
                {
                    var L1 = types[node.Identifier.Text].DeclaredLabel;
                    var L2 = node.Label.LabelValue;

                    if (L1 <= L2 + authority)
                        return L2;
                    else
                    {
                        if (L1 is VariableLabel)
                            errorManager.Register(node, $"Unable to declassify, as {L1} \u2290 {L2} \u2294 {authority}. Consider removing the explicit declassification or adding an explicit label to {node.Identifier}.");
                        else
                            errorManager.Register(node, $"Unable to declassify, as {L1} \u2290 {L2} \u2294 {authority}.");
                        return Label.LowerBound;
                    }
                }
                else
                {
                    var Ld = new VariableLabel("d{" + node.Identifier.Text + "}");
                    var Lvar = types[node.Identifier.Text].DeclaredLabel;

                    owner.Add(Lvar, Ld + authority);

                    return Ld;
                }
            }
            protected override Label HandleADivideExpression(ADivideExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAElementExpression(AElementExpression node)
            {
                return Visit(node.Expression) + node.FieldTypeDecl.Type.DeclaredLabel;
            }
            protected override Label HandleAFunctionCallExpression(AFunctionCallExpression node)
            {
                var fcName = node.Function.Text;
                Label fcLabel;
                var hasCallerAuthority = node.Authorities.Count > 0;
                
                if (!owner.functionLabels.TryGetValue(fcName, out fcLabel))
                {
                    if (hasCallerAuthority)
                        errorManager.Register(node, ErrorType.Warning, $"Caller authority has no effect on library function {fcName}.");

                    fcLabel = Label.LowerBound;
                    foreach (var a in node.Arguments)
                        fcLabel += Visit(a);
                }

                if (hasCallerAuthority)
                {
                    IEnumerable<Principal> authorityOwners;
                    if (authority is LowerBoundLabel)
                        authorityOwners = new Principal[0];
                    else
                        authorityOwners = (authority as PolicyLabel).Owners();
                    foreach (var pn in node.Authorities)
                    {
                        if (!authorityOwners.Contains(pn.DeclaredPrincipal))
                            errorManager.Register(pn, $"Principal {pn.DeclaredPrincipal.Name} is not in the effective authority.");
                    }
                }

                return fcLabel;
            }
            protected override Label HandleAIdentifierExpression(AIdentifierExpression node)
            {
                var type = types[node.Identifier.Text];

                return type.DeclaredLabel;
            }
            protected override Label HandleAIndexExpression(AIndexExpression node)
            {
                return Visit(node.Expression) + Visit(node.Index);
            }
            protected override Label HandleAMinusExpression(AMinusExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAModuloExpression(AModuloExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAMultiplyExpression(AMultiplyExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleANegateExpression(ANegateExpression node) => Visit(node.Expression);
            protected override Label HandleANotExpression(ANotExpression node) => Visit(node.Expression);
            protected override Label HandleANumberExpression(ANumberExpression node) => Label.LowerBound;
            protected override Label HandleAOrExpression(AOrExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAParenthesisExpression(AParenthesisExpression node) => Visit(node.Expression);
            protected override Label HandleAPlusExpression(APlusExpression node) => Visit(node.Left) + Visit(node.Right);
        }
    }
}
