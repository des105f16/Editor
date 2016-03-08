using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLM.Editor
{
    public partial class Editor : SablePP.Tools.Editor.EditorForm
    {
        public Editor()
        {
            InitializeComponent();

            codeTextBox1.CompilationCompleted += CodeTextBox_CompilationCompleted;
        }

        private void CodeTextBox_CompilationCompleted(object sender, EventArgs e)
        {
            var comp = codeTextBox1.Executer as CompilerExecuter;
        }
    }
}
