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
        public MainWindow()
        {
            InitializeComponent();

            var codeTextBox = new CodeTextBox() { Executer = new DLM.Compiler.CompilerExecuter() };

            Loaded += (s, e) => codegrid.Child = new WindowsFormsHost() { Child = codeTextBox };
        }
    }
}
