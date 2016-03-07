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

        public void Clear()
        {
            listBox1.Items.Clear();
        }

        private string getString(VariableLabel label)
        {
            return label.Name + " \u2248 " + label.NoVariables.ToString();
        }

        public void AddRange(IEnumerable<VariableLabel> labels)
        {
            listBox1.Items.AddRange(labels.Select(getString).ToArray());
        }
        public void Add(VariableLabel label)
        {
            listBox1.Items.Add(getString(label));
        }
    }
}
