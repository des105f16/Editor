﻿using System.Linq;
using SablePP.Tools.Nodes;
using DLM.Compiler.Nodes;
using System.Collections.Generic;

namespace DLM.Compiler
{
    public class CGenerator : Analysis.DepthFirstAdapter
    {
        private readonly SearchableString text;

        private CGenerator(string source)
        {
            this.text = new SearchableString(source, "\r\n");
        }

        public static string GenerateC(Node node, string source)
        {
            CGenerator gen = new CGenerator(source);

            gen.Visit((dynamic)node);

            return gen.text.ToString();
        }

        #region Token Locater classes

        private class FirstToken : SablePP.Tools.Analysis.DepthFirstTreeWalker
        {
            private Token token = null;

            public static Token Find(Node node)
            {
                var finder = new FirstToken();
                finder.Visit(node);
                return finder.token;
            }
            public static Token Find(IEnumerable<Node> nodes)
            {
                return Find(nodes.First());
            }

            private FirstToken() { }

            public override void Visit(Production production)
            {
                if (this.token == null)
                    base.Visit(production);
            }
            public override void Visit(Token token)
            {
                if (this.token == null)
                    this.token = token;
            }
        }
        private class LastToken : SablePP.Tools.Analysis.DepthFirstReversedTreeWalker
        {
            private Token token = null;

            public static Token Find(Node node)
            {
                var finder = new LastToken();
                finder.Visit(node);
                return finder.token;
            }
            public static Token Find(IEnumerable<Node> nodes)
            {
                return Find(nodes.Last());
            }

            private LastToken() { }

            public override void Visit(Production production)
            {
                if (this.token == null)
                    base.Visit(production);
            }
            public override void Visit(Token token)
            {
                if (this.token == null)
                    this.token = token;
            }
        }

        #endregion

        private void ClearRange(Node node, string before = null, string after = null)
        {
            ClearRange(FirstToken.Find(node), FirstToken.Find(node), before, after);
        }
        private void ClearRange(Token from, Token to, string before = null, string after = null)
        {
            var start = text.TokenStart(from);
            var end = text.TokenEnd(to);

            if (before != null && before.Length > 0)
                start = text.SearchBackwards(start, before);

            if (after != null && after.Length > 0)
                end = text.SearchForwards(end, after) + (after.Length - 1);

            text.ReplaceRange(start, end, ' ');
        }
        private void ClearRange(Token token)
        {
            var start = text.TokenStart(token);
            var end = text.TokenEnd(token);

            text.ReplaceRange(start, end, ' ');
        }

        protected override void HandlePPrincipalDeclaration(PPrincipalDeclaration node)
        {
            ClearRange(node, "principal", ";");
        }

        protected override void HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node)
        {
            ClearRange(node, after: ";");
        }

        protected override void HandlePLabel(PLabel node)
        {
            ClearRange(node, "{{", "}}");
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            if (node.Readers.Count > 0)
                ClearRange(node, after: "<-");

            Visit(node.Type);
            Visit(node.Parameters);
            Visit(node.Statements);
        }

        protected override void HandleAIfActsForStatement(AIfActsForStatement node)
        {
            var first = FirstToken.Find(node);
            var last = LastToken.Find(node.Principals);

            ClearRange(first, last);

            var start = text.TokenStart(first);
            start++.Character = 'i';
            start++.Character = 'f';
            start++.Character = '(';
            start++.Character = '0';
            start++.Character = ')';

            Visit(node.Statements);
        }
        protected override void HandleAIfActsForElseStatement(AIfActsForElseStatement node)
        {
            var first = FirstToken.Find(node);
            var last = LastToken.Find(node.Principals);

            ClearRange(first, last);

            var start = text.TokenStart(first);
            start++.Character = 'i';
            start++.Character = 'f';
            start++.Character = '(';
            start++.Character = '0';
            start++.Character = ')';

            Visit(node.IfStatements);
            Visit(node.ElseStatements);
        }

        protected override void HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            var first = text.TokenStart(node.DeclassifyStart);
            var last = text.TokenStart(node.DeclassifyEnd);
            
            text.ReplaceRange(first, first + 1, ' ');
            text.ReplaceRange(last, last + 1, ' ');

            if (node.HasLabel)
            {
                var comma = text.SearchBackwards(text.TokenStart(FirstToken.Find(node.Label)), ",");
                text.ReplaceRange(comma, comma, ' ');
                Visit(node.Label);
            }
        }

        protected override void HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            var first = text.TokenStart(node.TimeCheck);
            var last = text.TokenEnd(node.Function);
            text.ReplaceRange(first, last, ' ');
            first.Character = '1';
        }

        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            if (node.HasTimeCall)
                text.ReplaceRange(text.TokenStart(node.TimeCall), text.TokenEnd(node.TimeCall), ' ');

            if (node.Authorities.Count > 0)
            {
                var first = text.TokenStart(FirstToken.Find(node.Authorities));
                var last = text.TokenEnd(LastToken.Find(node.Authorities));

                first = text.SearchBackwards(first, "<<<");
                last = text.SearchForwards(last, ">>>");

                text.ReplaceRange(first, last + 2, ' ');
            }
            Visit(node.Arguments);
        }

    }
}
