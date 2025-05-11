using System;
using System.Collections.Generic;
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


                if (DatabaseHelper.ValidateEmployeeLogin(Username, PasswordHash))
                {
                    MessageBox.Show("Вход выполнен успешно!");
                    Window4 mainWindow = new Window4();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    ResultText.Text = "Неверный логин или пароль!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


    }
}
