using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DLM.Compiler
{
    public static class NodeExtension
    {
        public static Token FirstToken(this Node node) => Tokens(node).First();
        public static Token LastToken(this Node node) => TokensReversed(node).First();

        public static IEnumerable<Token> Tokens(Node node)
        {
            return new Enumerable(node, false);
        }
        public static IEnumerable<Token> TokensReversed(Node node)
        {
            return new Enumerable(node, true);
        }

        private static Node[] GetChildren(Production prod)
        {
            var m = typeof(Production).GetMethod("GetChildren",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic);

            return (m.Invoke(prod, null) as IEnumerable<Node>).ToArray();
        }

        private class Enumerable : IEnumerable<Token>
        {
            private bool reverse;
            private Node root;

            public Enumerable(Node root, bool reverse)
            {
                this.root = root;
                this.reverse = reverse;
            }

            public IEnumerator<Token> GetEnumerator()
            {
                if (reverse)
                    return new ReverseTokenEnumerator(root);
                else
                    return new TokenEnumerator(root);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        private class TokenEnumerator : IEnumerator<Token>
        {
            private Token current;
            private List<Node> elements;

            public TokenEnumerator(Node root)
            {
                this.current = null;

                this.elements = new List<Node>();
                this.elements.Add(root);
            }

            public Token Current => current;
            object IEnumerator.Current => current;

            public void Dispose() { }

            public bool MoveNext()
            {
                if (elements.Count == 0)
                    return false;

                while (elements[0] is Production)
                {
                    var p = elements[0] as Production;
                    elements.RemoveAt(0);
                    var children = GetChildren(p);
                    elements.InsertRange(0, children);
                }

                current = elements[0] as Token;
                elements.RemoveAt(0);
                return true;
            }

            public void Reset() { }
        }
        private class ReverseTokenEnumerator : IEnumerator<Token>
        {
            private Token current;
            private List<Node> elements;

            public ReverseTokenEnumerator(Node root)
            {
                this.current = null;

                this.elements = new List<Node>();
                this.elements.Add(root);
            }

            public Token Current => current;
            object IEnumerator.Current => current;

            public void Dispose() { }

            public bool MoveNext()
            {
                if (elements.Count == 0)
                    return false;

                while (elements[0] is Production)
                {
                    var p = elements[0] as Production;
                    elements.RemoveAt(0);
                    var children = GetChildren(p);
                    elements.InsertRange(0, children.Reverse());
                }

                current = elements[0] as Token;
                elements.RemoveAt(0);
                return true;
            }

            public void Reset() { }
        }
    }
}
