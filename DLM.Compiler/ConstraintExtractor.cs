using DLM.Compiler.Analysis;
using DLM.Inference;
using SablePP.Tools;
using SablePP.Tools.Error;
using System.Collections.Generic;
using DLM.Compiler.Nodes;
using SablePP.Tools.Nodes;
using System.Linq;
using System;

namespace DLM.Compiler
{
    public class ConstraintExtractor : DepthFirstAdapter
    {
        private List<NodeConstraint> constraints;

        private ErrorManager errorManager;
        private ScopedDictionary<string, PType> types;
        private Dictionary<string, AFunctionDeclarationStatement> functionLabels;

        private AuthorityLabel authority;
        private Label basicBlock;
        private SafeNameDictionary<VariableLabel> namedLabels;
        private IEnumerable<string> variableNameGenerator(string name)
        {
            int i = 1;

            while (true) yield return $"[{name}{i++}]";
        }
        private VariableLabel getVariableLabel(string name)
        {
            name = namedLabels.Add(name);
            var Ld = new VariableLabel(name);
            namedLabels.AddItem(Ld, name);

            return Ld;
        }

        public ConstraintExtractor(ErrorManager errorManager)
        {
            constraints = new List<NodeConstraint>();

            this.errorManager = errorManager;
            types = new ScopedDictionary<string, PType>();
            functionLabels = new Dictionary<string, AFunctionDeclarationStatement>();

            authority = new AuthorityLabel();
            basicBlock = Label.LowerBound;
            namedLabels = new SafeNameDictionary<VariableLabel>(variableNameGenerator);
        }

        public NodeConstraint[] Constraints => constraints.ToArray();

        private void Add(Label left, Label right, Node marked, Node node, NodeConstraint.OriginTypes originType)
        {
            constraints.Add(new NodeConstraint(left + basicBlock, right, marked, node, originType));
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            var fName = node.Identifier.Text;
            functionLabels.Add(fName, node);

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

            Add(lbl, node.Type.DeclaredLabel, node.Identifier, node, NodeConstraint.OriginTypes.Declaration);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            types.Add(node.Identifier.Text, node.Type);

            Add(Label.LowerBound, node.Type.DeclaredLabel, node.Identifier, node, NodeConstraint.OriginTypes.Declaration);
        }
        protected override void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, this);

            var type = types[node.Identifier.Text];

            Add(lbl, type.DeclaredLabel, node.Identifier, node, NodeConstraint.OriginTypes.Assignment);
        }
        protected override void HandleAExpressionStatement(AExpressionStatement node)
        {
            ExpressionLabeler.GetLabel(node.Expression, this);
        }
        protected override void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            if (node.Claimant is ACallerClaimant)
                errorManager.Register(node.Claimant, ErrorType.Message, "'caller' keyword not yet implemented.");
            else if (node.Claimant is AThisClaimant)
                errorManager.Register(node.Claimant, ErrorType.Message, "'this' keyword not yet implemented.");

            foreach (var p in node.Principals)
                authority.Push(p.DeclaredPrincipal);

            Visit(node.Statements);

            for (int i = 0; i < node.Principals.Count; i++)
                authority.Pop();
        }
        protected override void HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            if (node.Claimant is ACallerClaimant)
                errorManager.Register(node.Claimant, ErrorType.Message, "'caller' keyword not yet implemented.");
            else if (node.Claimant is AThisClaimant)
                errorManager.Register(node.Claimant, ErrorType.Message, "'this' keyword not yet implemented.");

            foreach (var p in node.Principals)
                authority.Push(p.DeclaredPrincipal);

            Visit(node.IfStatements);
            Visit(node.ElseStatements);

            for (int i = 0; i < node.Principals.Count; i++)
                authority.Pop();
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            Label lbl = getVariableLabel("if");
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl, node.If, node, NodeConstraint.OriginTypes.IfBlock);

            var old = basicBlock;
            basicBlock = lbl;
            Visit(node.Statements);
            basicBlock = old;
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            Label lbl = getVariableLabel("if");
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl, node.If, node, NodeConstraint.OriginTypes.IfBlock);

            var old = basicBlock;
            basicBlock = lbl;
            Visit(node.IfStatements);
            Visit(node.ElseStatements);
            basicBlock = old;
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            Label lbl = getVariableLabel("while");
            Add(ExpressionLabeler.GetLabel(node.Expression, this), lbl, node.While, node, NodeConstraint.OriginTypes.WhileBlock);

            var old = basicBlock;
            basicBlock = lbl;
            Visit(node.Statements);
            basicBlock = old;
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, this);

            var type = node.GetFirstParent<AFunctionDeclarationStatement>().Type;

            Add(lbl, type.DeclaredLabel, node.Return, node.Expression, NodeConstraint.OriginTypes.Return);
        }

        private class ExpressionLabeler : ReturnAnalysisAdapter<Label>
        {
            private ConstraintExtractor owner;
            private ScopedDictionary<string, PType> types => owner.types;
            private ErrorManager errorManager => owner.errorManager;
            private AuthorityLabel authority => owner.authority;

            private ExpressionLabeler(ConstraintExtractor owner)
            {
                this.owner = owner;
            }

            public static Label GetLabel(PExpression expression, ConstraintExtractor owner)
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
                    var L1 = Visit(node.Expression);
                    var L2 = node.Label.LabelValue;

                    if (L1 <= L2 + authority)
                        return L2;
                    else
                    {
                        errorManager.Register(node, $"Unable to declassify, as {L1} \u2290 {L2} \u2294 {authority.Label}.");
                        return Label.LowerBound;
                    }
                }
                else
                {
                    var Ld = owner.getVariableLabel("dec");
                    var Lvar = Visit(node.Expression);

                    owner.Add(Lvar, Ld + authority, node.Expression, node, NodeConstraint.OriginTypes.Declassify);

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

                AFunctionDeclarationStatement funcDecl;
                Label fcLabel;

                if (owner.functionLabels.TryGetValue(fcName, out funcDecl))
                {
                    fcLabel = funcDecl.Type.DeclaredLabel;
                    checkArgumentLabels(node.Arguments, funcDecl);

                    for (int i = 0; i < funcDecl.Parameters.Count; i++)
                        if (funcDecl.Parameters[i].Type.DeclaredLabel is ConstantLabel)
                        {
                            var constant = funcDecl.Parameters[i].Type.DeclaredLabel as ConstantLabel;
                            fcLabel = fcLabel.ReplaceConstant(constant, Visit(node.Arguments[i]));
                        }
                        else
                            Visit(node.Arguments[i]);
                }
                else
                {
                    if (node.Authorities.Count > 0)
                        errorManager.Register(node, ErrorType.Warning, $"Caller authority has no effect on library function {fcName}.");

                    fcLabel = Label.LowerBound;
                    foreach (var a in node.Arguments)
                        fcLabel += Visit(a);
                }

                foreach (var p in node.Authorities)
                {
                    if (!authority.Contains(p.DeclaredPrincipal))
                        errorManager.Register(p, $"Principal {p.DeclaredPrincipal.Name} is not in the effective authority.");
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
            protected override Label HandleANullExpression(ANullExpression node) => Label.LowerBound;
            protected override Label HandleANumberExpression(ANumberExpression node) => Label.LowerBound;
            protected override Label HandleAOrExpression(AOrExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAParenthesisExpression(AParenthesisExpression node) => Visit(node.Expression);
            protected override Label HandleAPlusExpression(APlusExpression node) => Visit(node.Left) + Visit(node.Right);

            private void checkArgumentLabels(Production.NodeList<PExpression> arguments, AFunctionDeclarationStatement functionDeclaration)
            {
                for (int i = 0; i < arguments.Count; i++)
                {
                    var argLabel = Visit(arguments[i]);
                    var paramLabel = functionDeclaration.Parameters[i].Type.DeclaredLabel;

                    if (paramLabel is PolicyLabel && argLabel is PolicyLabel)
                    {
                        if (!(argLabel <= paramLabel))
                            errorManager.Register(arguments[i], $"Parameter label is less restrictive than argument label: {argLabel} \u228f {paramLabel}");
                    }
                    else if (!(paramLabel is ConstantLabel))
                    {
                        owner.Add(argLabel, paramLabel, arguments[i], arguments[i], NodeConstraint.OriginTypes.Argument);
                    }
                }
            }
        }
    }
}
