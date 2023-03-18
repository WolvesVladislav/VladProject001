using System.Windows;

namespace VladProject001.Window
{
    public partial class RegistrationWindow
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrarionButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || PhoneTextBox.Text == "" || EmailTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Поля пустые!", "Уведомление");
            }
            else
            {
                if (PasswordPasswordBox.Password != PasswordTextBox.Text)
                {
                    MessageBox.Show("Пароли не сходятся!", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Реистрация прошла успешно", "Уведомление");
                    AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                    authorizationWindow.Show();
                    this.Close();
                }
            }
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
