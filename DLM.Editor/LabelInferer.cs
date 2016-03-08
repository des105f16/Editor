using DLM.Editor.Analysis;
using DLM.Inference;
using SablePP.Tools;
using SablePP.Tools.Error;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Editor
{
  public  class LabelInferer : DepthFirstAdapter
    {
        private List<Constraint> constraints;

        private ErrorManager errorManager;
        private ScopedDictionary<string, PType> types;

        private LabelStack basicBlock;
        private int blockNameCount = 1;
        
        public LabelInferer(ErrorManager errorManager)
        {
            this.errorManager = errorManager;

            constraints = new List<Constraint>();

            types = new ScopedDictionary<string, PType>();
            basicBlock = new LabelStack(true);
        }

        public Constraint[] Constraints => constraints.ToArray();

        private void Add(Label left, Label right)
        {
            constraints.Add(new Constraint(left + basicBlock, right));
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
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
                ExpressionLabeler.GetLabel(node.Expression, types) :
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
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, types);

            var type = types[node.Identifier.Text];

            Add(lbl, type.DeclaredLabel);
        }
        protected override void HandleAActsForStatement(AActsForStatement node)
        {
            Visit(node.Statements);
            //throw new System.NotImplementedException();
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, types), lbl);

            basicBlock.Push(lbl);
            Visit(node.Statements);
            basicBlock.Pop();
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, types), lbl);

            basicBlock.Push(lbl);
            Visit(node.IfStatements);
            Visit(node.ElseStatements);
            basicBlock.Pop();
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            Label lbl = new VariableLabel("L" + blockNameCount++);
            Add(ExpressionLabeler.GetLabel(node.Expression, types), lbl);

            basicBlock.Push(lbl);
            Visit(node.Statements);
            basicBlock.Pop();
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            Label lbl = ExpressionLabeler.GetLabel(node.Expression, types);

            var type = node.GetFirstParent<AFunctionDeclarationStatement>().Type;

            Add(lbl, type.DeclaredLabel);
        }

        private class ExpressionLabeler : ReturnAnalysisAdapter<Label>
        {
            private ScopedDictionary<string, PType> types;

            private ExpressionLabeler(ScopedDictionary<string, PType> types)
            {
                this.types = types;
            }

            public static Label GetLabel(PExpression expression, ScopedDictionary<string, PType> types)
            {
                return new ExpressionLabeler(types).Visit(expression);
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
                return new VariableLabel("Ld");
            }
            protected override Label HandleADivideExpression(ADivideExpression node) => Visit(node.Left) + Visit(node.Right);
            protected override Label HandleAElementExpression(AElementExpression node)
            {
                return Visit(node.Expression);
            }
            protected override Label HandleAFunctionCallExpression(AFunctionCallExpression node)
            {
                Label lbl = Label.LowerBound;

                foreach (var a in node.Arguments)
                    lbl += Visit(a);

                return lbl;
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
