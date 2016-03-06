using DLM.Editor.Analysis;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using DLM.Inference;
using SablePP.Tools.Error;

namespace DLM.Editor
{
    public class LabelExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private Dictionary<string, Principal> principals;

        public LabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
            this.principals = new Dictionary<string, Principal>();
        }

        protected override void HandlePRoot(PRoot node)
        {
            foreach (var p in node.PrincipalDeclarations)
            {
                string name = p.Name.Text;
                if (principals.ContainsKey(name))
                    errorManager.Register(p, $"The principal {name} has already been defined.");
                else
                    principals.Add(name, new Principal(name));
            }

            // Stop validation if there were errors
            if (errorManager.Errors.Count > 0)
                return;
        }
    }
}
