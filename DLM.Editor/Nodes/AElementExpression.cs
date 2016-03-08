using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLM.Editor.Nodes
{
    public partial class AElementExpression
    {
        private PField fieldTypeDecl;

        public PField FieldTypeDecl { get { return fieldTypeDecl; } set { fieldTypeDecl = value; } }
    }
}
