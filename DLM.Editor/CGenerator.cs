using System;
using System.Linq;
using SablePP.Tools.Nodes;
using DLM.Editor.Nodes;

namespace DLM.Editor
{
    public class CGenerator : Analysis.ReturnAnalysisAdapter<string>
    {
        private CGenerator()
        {
        }

        public static string GenerateC(Node node)
        {
            CGenerator gen = new CGenerator();

            return gen.Visit((dynamic)node);
        }

        protected override string HandleDefault(Node node)
        {
            if (node is Token)
                return (node as Token).Text;
            else
                throw new NotImplementedException();
        }

        protected override string HandleAAndExpression(AAndExpression node) => $"{Visit(node.Left)} && {Visit(node.Right)}";
        protected override string HandleABooleanExpression(ABooleanExpression node) => node.Bool.Text;
        protected override string HandleAComparisonExpression(AComparisonExpression node) => $"{Visit(node.Left)} {node.Compare.Text} {Visit(node.Right)}";
        protected override string HandleADeclarationStatement(ADeclarationStatement node)
        {
            if (node.HasExpression)
                return $"{Visit(node.Type)} {node.Identifier} = {Visit(node.Expression)};";
            else
                return $"{Visit(node.Type)} {node.Identifier};";
        }
        protected override string HandleADivideExpression(ADivideExpression node) => $"{Visit(node.Left)} / {Visit(node.Right)}";
        protected override string HandleAElement(AElement node) => "." + node.Identifier.Text;
        protected override string HandleAPointerElement(APointerElement node) => "->" + node.Identifier.Text;
        protected override string HandleAElementExpression(AElementExpression node) => Visit(node.Expression) + Visit(node.Element);
        protected override string HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            string res = node.Function.Text + "(";
            foreach (var e in node.Arguments)
                res += Visit(e);
            res += ")";
            return res;
        }
        protected override string HandleAIdentifierExpression(AIdentifierExpression node) => node.Identifier.Text;
        protected override string HandleAIndexExpression(AIndexExpression node) => $"{Visit(node.Expression)}[{node.Index}]";
        protected override string HandleAMinusExpression(AMinusExpression node) => $"{Visit(node.Left)} - {Visit(node.Right)}";
        protected override string HandleAModuloExpression(AModuloExpression node) => $"{Visit(node.Left)} % {Visit(node.Right)}";
        protected override string HandleAMultiplyExpression(AMultiplyExpression node) => $"{Visit(node.Left)} * {Visit(node.Right)}";
        protected override string HandleANegateExpression(ANegateExpression node) => $"-{Visit(node.Expression)}";
        protected override string HandleANotExpression(ANotExpression node) => $"!{Visit(node.Expression)}";
        protected override string HandleANumberExpression(ANumberExpression node) => node.Number.Text;
        protected override string HandleAOrExpression(AOrExpression node) => $"{Visit(node.Left)} || {Visit(node.Right)}";
        protected override string HandleAParenthesisExpression(AParenthesisExpression node) => $"({Visit(node.Expression)})";
        protected override string HandleAPlusExpression(APlusExpression node) => $"{Visit(node.Left)} + {Visit(node.Right)}";
        protected override string HandleAPointerType(APointerType node) => $"{Visit(node.Type)} *";
        protected override string HandleAType(AType node) => node.Name.Text;
    }
}
