using System.Windows;

namespace VladProject001.Window
{
    public partial class PasswordWindow
    {
        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void SavePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (OldPasswordTextBox.Text == "" || NewPasswordTextBox.Text == "" || PasswordPasswordBox.Password == "")
            {
                MessageBox.Show("Поля пустые", "Уведомление");
            }
            else
            {
                if (OldPasswordTextBox.Text != "Pas1")
                {
                    MessageBox.Show("Старый пароль не верный", "Уведомление");
                }
                else
                {
                    if (PasswordPasswordBox.Password != NewPasswordTextBox.Text)
                    {
                        MessageBox.Show("Пароли не совподают", "Уведомление");
                    }
                    else
                    {
                        MessageBox.Show("Пароли успешно изменён", "Уведомление");
                        MainProfilWindow mainProfilWindow = new MainProfilWindow();
                        mainProfilWindow.Show();
                        this.Close();
                    }
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainProfilWindow mainProfilWindow = new MainProfilWindow();
            mainProfilWindow.Show();
            this.Close();
        }
    }
}
