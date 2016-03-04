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

        protected override string HandleARoot(ARoot node)
        {
            string res = "";

            foreach (var i in node.Includes)
                res += Visit(i) + "\r\n";
            foreach (var s in node.Statements)
                res += Visit(s) + "\r\n";

            return res;
        }

        protected override string HandleAInclude(AInclude node) => "#include " + node.File.Text;

        protected override string HandleAAssignmentStatement(AAssignmentStatement node) => $"{Visit(node.Identifier)} = {Visit(node.Expression)};";

        protected override string HandleADeclarationStatement(ADeclarationStatement node)
        {
            if (node.HasExpression)
                return $"{Visit(node.Type)} {node.Identifier} = {Visit(node.Expression)};";
            else
                return $"{Visit(node.Type)} {node.Identifier};";
        }
        protected override string HandleAIfStatement(AIfStatement node)
        {
            string ret = $"if ({Visit(node.Expression)}) {{";
            foreach (var s in node.Statements)
                ret += "\r\n" + Visit(s);
            ret += "\r\n}";
            return ret;
        }
        protected override string HandleAIfElseStatement(AIfElseStatement node)
        {
            string ret = $"if ({Visit(node.Expression)}) {{";
            foreach (var s in node.IfStatements)
                ret += "\r\n" + Visit(s);
            ret += "\r\n} else {";
            foreach (var s in node.ElseStatements)
                ret += "\r\n" + Visit(s);
            ret += "\r\n}";
            return ret;
        }
        protected override string HandleAWhileStatement(AWhileStatement node)
        {
            string ret = $"while ({Visit(node.Expression)}) {{";
            foreach (var s in node.Statements)
                ret += "\r\n" + Visit(s);
            ret += "\r\n}";
            return ret;
        }
        protected override string HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            string res = $"{Visit(node.Type)} {Visit(node.Identifier)}(";

            foreach (var e in node.Parameters)
                res += Visit(e);
            res += ") {";

            foreach (var s in node.Statements)
                res += "\r\n" + Visit(s);
            res += "\r\n}";

            return res;
        }
        protected override string HandleAFunctionParameter(AFunctionParameter node) => $"{Visit(node.Type)} {Visit(node.Identifier)}";
        protected override string HandleAReturnStatement(AReturnStatement node)
        {
            if (node.HasExpression)
                return "return " + Visit(node.Expression) + ";";
            else
                return "return;";
        }

        protected override string HandleAPointerType(APointerType node) => $"{Visit(node.Type)} *";
        protected override string HandleAType(AType node) => node.Name.Text;

        protected override string HandleAAndExpression(AAndExpression node) => $"{Visit(node.Left)} && {Visit(node.Right)}";
        protected override string HandleAOrExpression(AOrExpression node) => $"{Visit(node.Left)} || {Visit(node.Right)}";
        protected override string HandleANotExpression(ANotExpression node) => $"!{Visit(node.Expression)}";
        protected override string HandleAComparisonExpression(AComparisonExpression node) => $"{Visit(node.Left)} {node.Compare.Text} {Visit(node.Right)}";

        protected override string HandleAElementExpression(AElementExpression node) => Visit(node.Expression) + Visit(node.Element);
        protected override string HandleAIndexExpression(AIndexExpression node) => $"{Visit(node.Expression)}[{node.Index}]";

        protected override string HandleAPlusExpression(APlusExpression node) => $"{Visit(node.Left)} + {Visit(node.Right)}";
        protected override string HandleAMinusExpression(AMinusExpression node) => $"{Visit(node.Left)} - {Visit(node.Right)}";
        protected override string HandleAMultiplyExpression(AMultiplyExpression node) => $"{Visit(node.Left)} * {Visit(node.Right)}";
        protected override string HandleADivideExpression(ADivideExpression node) => $"{Visit(node.Left)} / {Visit(node.Right)}";
        protected override string HandleAModuloExpression(AModuloExpression node) => $"{Visit(node.Left)} % {Visit(node.Right)}";
        protected override string HandleANegateExpression(ANegateExpression node) => $"-{Visit(node.Expression)}";

        protected override string HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            string res = node.Function.Text + "(";
            foreach (var e in node.Arguments)
                res += Visit(e);
            res += ")";
            return res;
        }

        protected override string HandleAParenthesisExpression(AParenthesisExpression node) => $"({Visit(node.Expression)})";
        protected override string HandleAIdentifierExpression(AIdentifierExpression node) => node.Identifier.Text;
        protected override string HandleANumberExpression(ANumberExpression node) => node.Number.Text;
        protected override string HandleABooleanExpression(ABooleanExpression node) => node.Bool.Text;

        protected override string HandleAElement(AElement node) => "." + node.Identifier.Text;
        protected override string HandleAPointerElement(APointerElement node) => "->" + node.Identifier.Text;
    }
}
