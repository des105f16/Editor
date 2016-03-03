using System;
using SablePP.Tools.Nodes;
using SablePP.Tools.Generate;

namespace DLM.Editor
{
    public class CGenerator : Analysis.DepthFirstAdapter
    {
        private PatchElement element;

        private CGenerator()
        {
            this.element = new PatchElement();
        }

        public static string GenerateC(Node node)
        {
            CGenerator gen = new CGenerator();

            return gen.Visit((dynamic)node);
        }
        
        protected override void HandleDefault(Node node)
        {
            if (node is Token)
                element.Emit((node as Token).Text);
            else
                throw new NotImplementedException();
        }
    }
}
