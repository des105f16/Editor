using DLM.Inference;

namespace DLM.Compiler.Nodes
{
    public partial class PPrincipal
    {
        private Principal principal;

        public Principal DeclaredPrincipal
        {
            get { return principal; }
            set { principal = value; }
        }
    }
}
