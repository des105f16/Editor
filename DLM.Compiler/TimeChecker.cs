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
        private ScopedDictionary<string, bool> safe;

        public TimeChecker(ErrorManager errorManager)
        {
            this.errorManager = errorManager;

            this.time = new ScopedDictionary<string, Dictionary<string, PTimePolicy>>();
            this.safe = new ScopedDictionary<string, bool>();
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            Visit(node.Type);

            if (errorManager.Errors.Count == 0)
            {
                safe.OpenScope();
                foreach (var n in time.Keys)
                    safe.Add(n, false);
                Visit(node.Statements);
                safe.CloseScope();
            }
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

        protected override void HandleATimeCheckExpression(ATimeCheckExpression node)
        {
            string name = node.Function.Text;

            if (!safe.ContainsKey(name, false))
                errorManager.Register(node, ErrorType.Message, $"{name} does not have time policies.");
            else if (safe[name])
                errorManager.Register(node, ErrorType.Message, $"{name} has already been checked. This check is redundant.");
            else
                safe[node.Function.Text] = true;
        }
        protected override void HandleAFunctionCallExpression(AFunctionCallExpression node)
        {
            string name = node.Function.Text;

            if (node.HasTimeCall)
            {
                if (!safe.ContainsKey(name, false))
                    errorManager.Register(node, ErrorType.Message, $"{name} does not have time policies.");
                else if (safe[name])
                    errorManager.Register(node, ErrorType.Message, $"Calling {name} with @ prefix will consume the last \"@?{name}\" check.");

                safe[name] = false;
            }
            else if (safe.ContainsKey(name, false))
            {
                if (!safe[name])
                    errorManager.Register(node, ErrorType.Error, $"Calling the {name} function, which has time policies, must be preceded with a \"@?{name}\" check or using the wait construct @{name}(...).");

                safe[name] = false;
            }
        }

        protected override void HandleAAndExpression(AAndExpression node)
        {
            Visit(node.Left);
            Visit(node.Right);
        }
        protected override void HandleAOrExpression(AOrExpression node)
        {
            safe.OpenScope();
            Visit(node.Left);
            var k1 = safe.Keys.ToArray().Where(x => safe.Keys.Contains(x, true) && safe[x]).ToArray();
            safe.CloseScope();

            safe.OpenScope();
            Visit(node.Right);
            var k2 = safe.Keys.ToArray().Where(x => safe.Keys.Contains(x, true) && safe[x]).ToArray();
            safe.CloseScope();

            var keys = k1.Intersect(k2).ToArray();
            foreach (var k in keys)
                safe[k] = true;
        }

        protected override void HandleAIfStatement(AIfStatement node)
        {
            safe.OpenScope();
            Visit(node.Expression);
            Visit(node.Statements);
            safe.CloseScope();
        }
    }
}
