using DLM.Compiler.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLM.Compiler.Nodes;
using SablePP.Tools;
using SablePP.Tools.Error;

namespace DLM.Compiler
{
    public class TimeChecker : DepthFirstAdapter
    {
        private ErrorManager errorManager;

        private ScopedDictionary<string, Dictionary<string, PTimePolicy>> time;

        public TimeChecker(ErrorManager errorManager)
        {
            this.errorManager = errorManager;

            this.time = new ScopedDictionary<string, Dictionary<string, PTimePolicy>>();
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            Visit(node.Type);
            Visit(node.Statements);
        }

        protected override void HandlePLabel(PLabel node)
        {
            base.HandlePLabel(node);

            var function = node.GetFirstParent<AFunctionDeclarationStatement>();

            Dictionary<string, PTimePolicy> dict = new Dictionary<string, PTimePolicy>();

            foreach (var o in node.Policys.OfType<APrincipalPolicy>())
                foreach (var r in o.Readers)
                {
                    var pol = r.TimePolicy ?? o.Owner.TimePolicy;

                    if (pol != null)
                    {
                        if (function != null)
                            dict.Add(r.Identifier.Text, pol);
                        else
                            errorManager.Register(pol, "Time policies can only be specified for functions.");
                    }
                }

            if (dict.Count > 0 && function != null)
                time.Add(function.Identifier.Text, dict);
        }
        private void AddTime(string name, PLabel node)
        {
            if (node == null)
                return;

            Dictionary<string, PTimePolicy> dict = new Dictionary<string, PTimePolicy>();

            foreach (var o in node.Policys.OfType<APrincipalPolicy>())
                if (o.Owner.HasTimePolicy)
                    foreach (var r in o.Readers)
                    {
                        var pol = r.TimePolicy ?? o.Owner.TimePolicy;

                        if (pol != null)
                            dict.Add(r.Identifier.Text, pol);
                    }

            if (dict.Count > 0)
                time.Add(name, dict);
        }
    }
}
