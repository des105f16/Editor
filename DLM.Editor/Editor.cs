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
    public partial class Editor : SablePP.Tools.Editor.SimpleEditor
    {
        private ListForm list;

        public Editor()
        {
            InitializeComponent();

            list = new ListForm();
            FormClosing += (s, e) =>
            {
                list.CanClose = true;
                list.Close();
            };

            CodeTextBox.CompilationCompleted += CodeTextBox_CompilationCompleted;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            list.Show();
        }

        private void CodeTextBox_CompilationCompleted(object sender, EventArgs e)
        {
            var comp = CodeTextBox.Executer as CompilerExecuter;

            list.Set(comp.Result);

        }
    }
}
