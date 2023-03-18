using System.Windows;

namespace VladProject001.Window
{
    public partial class MainProfilWindow
    {
        public MainProfilWindow()
        {
            InitializeComponent();
        }

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
            this.Close();
        }
    }
}
