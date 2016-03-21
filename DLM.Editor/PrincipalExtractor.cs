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

        public List<Principal> Extract(Start<PRoot> root)
        {
            return new List<Principal>();
        }
    }
}
