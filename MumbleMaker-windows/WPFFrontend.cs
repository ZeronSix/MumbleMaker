using System.Windows;

namespace MumbleMaker {
    /// <summary>
    /// Frontend based on WPF (works on windows)
    /// </summary>
    public class WpfFrontend: IFrontend {
        public Window Window;

        public WpfFrontend(Window window) {
            Window = window;
        }

        /// <summary>
        /// Shows message box with error message
        /// </summary>
        /// <param name="title">Message box title</param>
        /// <param name="text">Message text</param>
        public void ShowErrorMessage(string title, string text) {
            MessageBox.Show(Window, text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
