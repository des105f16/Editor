using System.Windows.Input;

namespace DLM.Wpf
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
        (
            "Exit",
            "Exit",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.F4, ModifierKeys.Alt)
            }
        );

        public static readonly RoutedUICommand OpenRecent = new RoutedUICommand
        (
            "Open Recent",
            "OpenRecent",
            typeof(CustomCommands),
            new InputGestureCollection()
        );
    }
}
