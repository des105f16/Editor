using DLM.Compiler.Analysis;
using DLM.Compiler.Nodes;
using DLM.Inference;
using SablePP.Tools.Error;
using System.Collections.Generic;
using System.Linq;

namespace DLM.Compiler
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
                    Principal principal;
                    if (principals.TryGetValue(name, out principal))
                    {
                        if (principal is FunctionPrincipal)
                            errorManager.Register(p, $"The principal {principal.Name} is already defined through a function of the same name.");
                        else
                            errorManager.Register(p, $"The principal {principal.Name} has already been defined.");
                    }
                    else
                        principals.Add(name, new Principal(name));
                }
            }
            
            Visit(node.PrincipalHierarchyDeclarations);
        }

        protected override void HandlePPrincipalHierarchyDeclaration(PPrincipalHierarchyDeclaration node)
        {
            var dName = node.Principal.Identifier.Text;
            Principal dominant;

            if (!principals.TryGetValue(dName, out dominant))
            {
                errorManager.Register(node.Principal, $"Use of undeclared principal {dName}.");
                return;
            }

            foreach (var s in node.Subordinates)
            {
                var sName = s.Identifier.Text;
                Principal subordinate;
                if (!principals.TryGetValue(sName, out subordinate))
                {
                    errorManager.Register(s, $"Use of undeclared principal {sName}.");
                    return;
                }
                else if (dominant == subordinate)
                {
                    errorManager.Register(s, $"Principal {dominant.Name} cannot be its own subordinate.");
                    return;
                }
                else if (dominant.Subordinates.Contains(subordinate))
                {
                    errorManager.Register(s, $"Principal {subordinate.Name} is already a subordinate of {dominant.Name}.");
                    return;
                }
                else if (subordinate.ActualSubordinates.Contains(dominant))
                {
                    errorManager.Register(s, $"Circular hierarchy: {subordinate.Name} is its own subordinate.");
                    return;
                }
                else
                    dominant.AddSubordinate(subordinate);
            }
        }

        private class FunctionPrincipal : Principal
        {
            public FunctionPrincipal(string name) : base(name) { }
        }
    }
}
