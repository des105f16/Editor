using DLM.Inference;
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
    public partial class ListForm : Form
    {
        public bool CanClose = false;

        public ListForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = !CanClose;
            base.OnClosing(e);
        }

        private string getString(VariableLabel label)
        {
            return label.Name + " \u2248 " + label.NoVariables.ToString();
        }

        public void Set(InferenceResult result)
        {
            listBox1.Items.Clear();

            if (result == null)
                return;

            if (result.Succes)
            {
                foreach (var v in result.Variables)
                    listBox1.Items.Add(getString(v));
            }
            else
            {
                listBox1.Items.Add("ERROR");
            }
        }
    }
}
