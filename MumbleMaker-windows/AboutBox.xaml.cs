using System.Windows; 
using System.Windows.Controls; 
using System.Windows.Input; 

namespace MumbleMaker {
    /// <summary>
    /// Interaction logic for AboutBox.xaml
    /// </summary>
    public partial class AboutBox : Window {
        public AboutBox() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
