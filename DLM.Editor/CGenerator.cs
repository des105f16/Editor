using System.Linq;
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
    }
}
