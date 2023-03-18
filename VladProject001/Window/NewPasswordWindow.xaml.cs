using System.Windows;

namespace VladProject001.Window
{
    public partial class NewPasswordWindow
    {
        public NewPasswordWindow()
        {
            InitializeComponent();
        }

        private void SavePassword_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "" || OldPasswordTextBox.Text == "" || rrrTextBox.Text == "" || NewPasswordTextBox.Text == "" || NewPasswordPasswordBox.Password == "")
            {
                MessageBox.Show("Пустые поля", "Уведомление");
            }
            else
            {
                if (LoginTextBox.Text != "Log1")
                {
                    MessageBox.Show("Пользователь не найден", "Уведомление");
                }
                else
                {
                    if (NewPasswordPasswordBox.Password != NewPasswordTextBox.Text)
                    {
                        MessageBox.Show("Пароли не совподают", "Уведомление");
                    }
                    else
                    {
                        MessageBox.Show("Пароль успешно изменён", "Уведомление");

                        AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                        authorizationWindow.Show();
                        this.Close();
                    }
                }
            }
        }

        private void BackPassword_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
