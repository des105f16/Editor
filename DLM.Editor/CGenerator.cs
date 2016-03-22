﻿using System.Linq;
using SablePP.Tools.Nodes;
using DLM.Editor.Nodes;
using System.Collections.Generic;

namespace DLM.Editor
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

        protected override void HandlePLabel(PLabel node)
        {
            ClearRange(node, "{{", "}}");
        }

        protected override void HandleAActsForStatement(AActsForStatement node)
        {
            var first = FirstToken.Find(node);
            var last = LastToken.Find(node.Principals);

            ClearRange(first, last);

            Visit(node.Statements);
        }

        protected override void HandleADeclassifyExpression(ADeclassifyExpression node)
        {
            var first = text.TokenStart(FirstToken.Find(node));
            var last = text.TokenEnd(LastToken.Find(node));

            first = text.SearchBackwards(first, "<|");
            last = text.SearchForwards(last, "|>");

            text.ReplaceRange(first, first + 1, ' ');
            text.ReplaceRange(last, last + 1, ' ');

            base.HandleADeclassifyExpression(node);

            var g = text.ToString();
        }
    }
}
