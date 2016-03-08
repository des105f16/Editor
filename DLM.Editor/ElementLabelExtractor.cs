using DLM.Editor.Analysis;
using SablePP.Tools.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor
{
    public class ElementLabelExtractor : DepthFirstAdapter
    {
        private ErrorManager errorManager;

        public ElementLabelExtractor(ErrorManager errorManager)
        {
            this.errorManager = errorManager;
        }
    }
}
