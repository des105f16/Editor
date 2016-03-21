using DLM.Editor.Analysis;
using DLM.Editor.Nodes;
using DLM.Inference;
using SablePP.Tools.Error;
using SablePP.Tools.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor
{
    public class PrincipalExtractor
    {
        private ErrorManager errorManager;
        public PrincipalExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
        }

        public Dictionary<string, Principal> Extract(Start<PRoot> root)
        {
            var pv = new PrincipalVisitor(errorManager);
            pv.Visit(root);
            return pv.Principals;
        }

        private class PrincipalVisitor : DepthFirstAdapter
        {
            private ErrorManager errorManager;
            private Dictionary<string, Principal> principals;

            public PrincipalVisitor(ErrorManager errorManager)
            {
                this.errorManager = errorManager;
                this.principals = new Dictionary<string, Principal>();
            }

            public Dictionary<string, Principal> Principals => principals;

            protected override void HandlePRoot(PRoot node)
            {

                foreach (var pd in node.PrincipalDeclarations)
                {
                    foreach (var p in pd.Principals)
                    {
                        string name = p.Identifier.Text;
                        if (principals.ContainsKey(name))
                            errorManager.Register(p, $"The principal {name} has already been defined.");
                        else
                            principals.Add(name, new Principal(name));
                    }
                }
            }
        }
    }
}
