using System.Windows;
using System.Windows.Controls;

namespace VladProject001.Window
{
    public partial class AuthorizationWindow
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordBox.Password == "")
            {
                MessageBox.Show("Поля пустые!", "Уведомление");
            }
            else
            {
                if (LoginTextBox.Text != "Log1" || PasswordBox.Password != "Pas1")
                {
                    MessageBox.Show("Данного пользователя не сушествуует", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Авторизация успешна!", "Уведомление");
                    MainProfilWindow mainProfilWindow = new MainProfilWindow();
                    mainProfilWindow.Show();
                    this.Close();
                }
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void NewPassword_Click(object sender, RoutedEventArgs e)
        {
            NewPasswordWindow newPasswordWindow = new NewPasswordWindow();
            newPasswordWindow.Show();
            this.Close();
        }
    }
}
