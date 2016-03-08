using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor.Nodes
{
    public partial class AElementExpression
    {
        private PStruct structTypedef;

        public PStruct StructTypedef { get { return structTypedef; } set { structTypedef = value; } }
    }
}
