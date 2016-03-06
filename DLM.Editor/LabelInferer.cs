using DLM.Editor.Analysis;
using DLM.Inference;
using SablePP.Tools;
using SablePP.Tools.Error;
using System.Collections.Generic;
using DLM.Editor.Nodes;

namespace DLM.Editor
{
    class LabelInferer : DepthFirstAdapter
    {
        private ErrorManager errorManager;
        private ScopedDictionary<string, PType> types;
        
        private Stack<Label> activeBasicBlock;

        public LabelInferer(ErrorManager errorManager)
        {
            this.errorManager = errorManager;

            types = new ScopedDictionary<string, PType>();
            activeBasicBlock = new Stack<Label>();
            activeBasicBlock.Push(Label.LowerBound);
        }

        protected override void HandleAFunctionDeclarationStatement(AFunctionDeclarationStatement node)
        {
            types.OpenScope();

            foreach (var p in node.Parameters)
                types.Add(p.Identifier.Text, p.Type);

            Visit(node.Statements);

            types.CloseScope();
        }

        protected override void HandleADeclarationStatement(ADeclarationStatement node)
        {
            base.HandleADeclarationStatement(node);
        }
        protected override void HandleAArrayDeclarationStatement(AArrayDeclarationStatement node)
        {
            base.HandleAArrayDeclarationStatement(node);
        }
        protected override void HandleAAssignmentStatement(AAssignmentStatement node)
        {
            base.HandleAAssignmentStatement(node);
        }
        protected override void HandleAActsForStatement(AActsForStatement node)
        {
            base.HandleAActsForStatement(node);
        }
        protected override void HandleAIfStatement(AIfStatement node)
        {
            base.HandleAIfStatement(node);
        }
        protected override void HandleAIfElseStatement(AIfElseStatement node)
        {
            base.HandleAIfElseStatement(node);
        }
        protected override void HandleAWhileStatement(AWhileStatement node)
        {
            base.HandleAWhileStatement(node);
        }
        protected override void HandleAReturnStatement(AReturnStatement node)
        {
            base.HandleAReturnStatement(node);
        }
    }
}
