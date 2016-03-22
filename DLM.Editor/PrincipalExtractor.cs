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
    public class PrincipalExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private Dictionary<string, Principal> principals;

        public Dictionary<string, Principal> Principals => principals;

        public PrincipalExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
            this.principals = new Dictionary<string, Principal>();
        }

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

            Visit(node.PrincipalHierarchyStmts);
        }

        protected override void HandlePPrincipalHierarchyStmt(PPrincipalHierarchyStmt node)
        {
            var principalName = node.Principal.Identifier.Text;
            Principal principal;

            if (!principals.TryGetValue(principalName, out principal))
            {
                errorManager.Register(node.Principal, $"Use of undeclared principal {principalName}.");
                return;
            }
        }
    }
}
