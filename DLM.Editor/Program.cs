using SablePP.Tools.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLM.Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var editor = new Editor();
            editor.CodeTextBox.Executer = new CompilerExecuter();
            editor.FileExtension = ".ncif";
            editor.Text = "Not CIF";

            Application.Run(editor);
        }
    }
}
