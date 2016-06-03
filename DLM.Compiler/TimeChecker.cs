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

        private List<string> timedFunctions;
        private ScopedDictionary<string, bool> safe;

        public TimeChecker(ErrorManager errorManager)
        {
            this.errorManager = errorManager;

            this.timedFunctions = new List<string>();
            this.safe = new ScopedDictionary<string, bool>();
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            Visit(node.Type);
            Visit(node.Parameters);

            safe.OpenScope();
            foreach (var n in timedFunctions)
                safe.Add(n, false);
            Visit(node.Statements);
            safe.CloseScope();
        }

        protected override void HandlePLabel(PLabel node)
        {
            base.HandlePLabel(node);

            bool hasTime = node.TimePolicies.Count > 0;

            if (hasTime)
            {
                var param = node.GetFirstParent<PFunctionParameter>();
                var stmt = node.GetFirstParent<PStatement>();

                bool isFunction = param == null && stmt != null && stmt is AFunctionDeclarationStatement;

                if (isFunction)
                    timedFunctions.Add((stmt as AFunctionDeclarationStatement).Identifier.Text);
                else
                    errorManager.Register(node.TimePolicies.First(), "Time policies can only be specified for functions.");
            }
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

        protected override void HandleANotExpression(ANotExpression node)
        {
            safe.OpenScope();
            Visit(node.Expression);
            var tempSafe = safe
                .Where(x => safe.Keys.Contains(x.Key, true))
                .ToList();
            safe.CloseScope();

            foreach (var kvp in tempSafe)
                safe.Add(kvp.Key, !kvp.Value);
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
            safe.CloseScope();

            safe.OpenScope();
            Visit(node.Right);
            safe.CloseScope();
        }

        protected override void HandleATernaryExpression(ATernaryExpression node)
        {
            safe.OpenScope();

            Visit(node.Condition);
            var tempSafe = safe
                .Where(x => safe.Keys.Contains(x.Key, true))
                .ToList();

            Visit(node.True);

            safe.CloseScope();
            safe.OpenScope();

            foreach (var kvp in tempSafe)
                safe.Add(kvp.Key, !kvp.Value);

            Visit(node.False);

            safe.CloseScope();
        }

        protected override void HandleAIfStatement(AIfStatement node)
        {
            safe.OpenScope();
            Visit(node.Expression);
            Visit(node.Statements);
            safe.CloseScope();
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            safe.OpenScope();

            Visit(node.Expression);
            var tempSafe = safe
                .Where(x => safe.Keys.Contains(x.Key, true))
                .ToList();

            Visit(node.IfStatements);

            safe.CloseScope();
            safe.OpenScope();

            foreach (var kvp in tempSafe)
                safe.Add(kvp.Key, !kvp.Value);

            Visit(node.ElseStatements);

            safe.CloseScope();
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            safe.OpenScope();

            Visit(node.Expression);
            Visit(node.Statements);

            safe.CloseScope();
        }
    }
}
