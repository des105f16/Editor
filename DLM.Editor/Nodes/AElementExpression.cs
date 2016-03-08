using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor.Nodes
{
    public partial class AElementExpression
    {
        private PStruct structDecl;

        public PStruct StructDecl { get { return structDecl; } set { structDecl = value; } }
    }
}
