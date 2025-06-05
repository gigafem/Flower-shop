using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Core;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для UserAuthorization.xaml
    /// </summary>
    public partial class UserAuthorization : Window
    {
        public UserAuthorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string phoneNumber = PhoneNumberBox.Text.Trim();
                string email = EmailBox.Text.Trim();
                string password = PasswordBox.Password.Trim();

                if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    ResultText.Text = "All fields must be filled in!";
                    return;
                }

                if (!Regex.IsMatch(phoneNumber, @"^\+?\d{10,15}$"))
                {
                    ResultText.Text = "Invalid phone number format!";
                    return;
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    ResultText.Text = "Invalid email format!";
                    return;
                }

                if (password.Length < 6)
                {
                    ResultText.Text = "Password must be at least 6 characters long!";
                    return;
                }

                MessageBox.Show("the login was completed successfully!");
                Logger.Log("Logged in");

                MainWindowForAuthorizedUser mainWindow = new MainWindowForAuthorizedUser();
                Application.Current.MainWindow = mainWindow;
                mainWindow.Show();

                // Закрытие текущего окна
                this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

