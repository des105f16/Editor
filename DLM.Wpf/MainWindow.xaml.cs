using MahApps.Metro.Controls;
using SablePP.Tools.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DLM.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private EditorFile file;

        public MainWindow()
        {
            InitializeComponent();

            var forecolor = System.Drawing.Color.FromArgb(220, 220, 220);
            var backcolor = System.Drawing.Color.FromArgb(30, 30, 30);
            var linenumbers = System.Drawing.Color.FromArgb(36, 126, 175);

            var currentline = System.Drawing.Color.FromArgb(12, 12, 12);

            var font = new System.Drawing.Font("Consolas", 10f, System.Drawing.FontStyle.Regular);

            var codeTextBox = new CodeTextBox()
            {
                Executer = new DLM.Compiler.CompilerExecuter(),
                BackColor = backcolor,
                ServiceLinesColor = backcolor,
                IndentBackColor = backcolor,
                LineNumberColor = linenumbers,
                CaretColor = forecolor,
                ForeColor = forecolor,
                CurrentLineColor = currentline,
                Font = font
            };

            Loaded += (s, e) => codegrid.Children.Add(new WindowsFormsHost() { Child = codeTextBox });

            file = new EditorFile(recentFilesMenuItem, CommandBindings);
        }
    }
}
