using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Username = UsernameBox.Text.Trim();
                string PasswordHash = PasswordBox.Password.Trim();
                string role;

                if (DatabaseHelper.ValidateEmployeeLogin(Username, PasswordHash, out role))
                {
                    MessageBox.Show("the login was completed successfully!");

                    if (role == "admin")
                    {
                        Window4 adminWindow = new Window4();
                        adminWindow.Show();
                    }
                    else
                    {
                        UserWindow userWindow = new UserWindow();
                        userWindow.Show();
                    }

                    this.Close();
                }
                else
                {
                    ResultText.Text = "Invalid username or password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
