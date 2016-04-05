using System.Windows.Controls;
using System.Windows.Input;

namespace DLM.Wpf
{
    public class EditorFile
    {
        private readonly MenuItem recentFilesMenuItem;
        private string filepath;

        public EditorFile(MenuItem recentFilesMenuItem, CommandBindingCollection bindings)
        {
            this.recentFilesMenuItem = recentFilesMenuItem;
            this.filepath = null;

            bindings.Add(new CommandBinding(ApplicationCommands.New, null, enabled));

            bindings.Add(new CommandBinding(ApplicationCommands.Open, null, enabled));
            bindings.Add(new CommandBinding(CustomCommands.OpenRecent, null, recentFiles_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Save, null, fileLoaded_CanExecute));
            bindings.Add(new CommandBinding(ApplicationCommands.SaveAs, null, fileLoaded_CanExecute));

            bindings.Add(new CommandBinding(ApplicationCommands.Close, null, fileLoaded_CanExecute));
        }

        private void enabled(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void disabled(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = false;
        private void fileLoaded_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = filepath != null;

        private void recentFiles_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            var source = recentFilesMenuItem as MenuItem;

            if (source.IsSubmenuOpen)
            {
                e.CanExecute = true;
                return;
            }

            string[] files = new string[] { "a", "b" };

            source.Items.Clear();
            foreach (var file in files)
            {
                MenuItem newMenuItem2 = new MenuItem();
                source.Items.Add(newMenuItem2);
                newMenuItem2.Header = file;
            }

            e.CanExecute = files.Length > 0;
        }
    }
}
