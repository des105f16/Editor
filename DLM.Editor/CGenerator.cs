using System;
using System.Linq;
using SablePP.Tools.Nodes;
using DLM.Editor.Nodes;
using System.Collections.Generic;

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

            string temp = gen.Visit((dynamic)node);

            return temp;
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
            foreach (var i in node.Structs)
                res += Visit(i) + "\r\n";
            foreach (var s in node.Statements)
                res += Visit(s) + "\r\n";

            return res;
        }

        protected override string HandleAInclude(AInclude node) => "#include " + node.File.Text;

        protected override string HandleAStruct(AStruct node) => $"typedef struct {Visit(node.Identifier)} {{" + Visit(node.Fields, "\r\n") + $"}} {Visit(node.Name)};";
        protected override string HandleAField(AField node) => Visit(node.Type) + " " + Visit(node.Identifier) + ";";
        protected override string HandleAArrayField(AArrayField node) => $"{Visit(node.Type)} {Visit(node.Identifier)}[{Visit(node.Size)}];";

        protected override string HandleADeclarationStatement(ADeclarationStatement node)
        {
            if (node.HasExpression)
                return $"{Visit(node.Type)} {node.Identifier} = {Visit(node.Expression)};";
            else
                return $"{Visit(node.Type)} {node.Identifier};";
        }
        protected override string HandleAArrayDeclarationStatement(AArrayDeclarationStatement node) => $"{Visit(node.Type)} {Visit(node.Identifier)}[{Visit(node.Size)}];";
        protected override string HandleAAssignmentStatement(AAssignmentStatement node) => $"{Visit(node.Identifier)} = {Visit(node.Expression)};";
        protected override string HandleAActsForStatement(AActsForStatement node) => Visit(node.Statements);
        protected override string HandleAIfStatement(AIfStatement node) => $"if ({Visit(node.Expression)}) {Visit(node.Statements)}";
        protected override string HandleAIfElseStatement(AIfElseStatement node) => $"if ({Visit(node.Expression)}) {Visit(node.IfStatements)} else {Visit(node.ElseStatements)}";
        protected override string HandleAWhileStatement(AWhileStatement node) => $"while ({Visit(node.Expression)}) {Visit(node.Statements)}";
        protected override string HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node) => $"{Visit(node.Type)} {Visit(node.Identifier)}({Visit(node.Parameters)}) {Visit(node.Statements)}";
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
        protected override string HandleALabel(ALabel node) => string.Empty;
        protected override string HandleAVariablePolicy(AVariablePolicy node) => string.Empty;
        protected override string HandleAPrincipalPolicy(APrincipalPolicy node) => string.Empty;
        protected override string HandleAPrincipal(APrincipal node) => string.Empty;
        protected override string HandleALowerPrincipal(ALowerPrincipal node) => string.Empty;
        protected override string HandleAUpperPrincipal(AUpperPrincipal node) => string.Empty;

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

        protected override string HandleAFunctionCallExpression(AFunctionCallExpression node) => $"{node.Function.Text} ({Visit(node.Arguments, ", ")})";

        protected override string HandleAParenthesisExpression(AParenthesisExpression node) => $"({Visit(node.Expression)})";
        protected override string HandleADeclassifyExpression(ADeclassifyExpression node) => node.Identifier.Text;
        protected override string HandleAIdentifierExpression(AIdentifierExpression node) => node.Identifier.Text;
        protected override string HandleANumberExpression(ANumberExpression node) => node.Number.Text;
        protected override string HandleABooleanExpression(ABooleanExpression node) => node.Bool.Text;

        protected override string HandleAElement(AElement node) => "." + node.Identifier.Text;
        protected override string HandleAPointerElement(APointerElement node) => "->" + node.Identifier.Text;

        private string Visit(IEnumerable<PStatement> statements)
        {
            string ret = "{";
            foreach (var s in statements)
                ret += "\r\n" + Visit(s);
            ret += "\r\n}";
            return ret;
        }
        private string Visit(IEnumerable<PFunctionParameter> parameters) => string.Join(", ", parameters.Select(x => Visit(x)));
        private string Visit<T>(IEnumerable<T> parameters, string sep) where T : Node => string.Join(sep, parameters.Select(x => Visit((dynamic)x)));
    }
}
