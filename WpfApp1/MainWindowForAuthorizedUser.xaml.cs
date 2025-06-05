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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static WpfApp1.AboutUs;
using WpfApp1.Core;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindowForAuthorizedUser.xaml
    /// </summary>
    public partial class MainWindowForAuthorizedUser : Window
    {
        public MainWindowForAuthorizedUser()
        {
            InitializeComponent();
        }

        private bool isCartOpen = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isCartOpen = !isCartOpen;

            if (isCartOpen)
            {
                CartPanel.Visibility = Visibility.Visible;

                var storyboard = (Storyboard)FindResource("CartOpenStoryboard");
                storyboard.Begin();
            }
            else
            {
                CartPanel.Visibility = Visibility.Collapsed;
            }
        }
        private void CloseCart_Click(object sender, RoutedEventArgs e)
        {
            CartPanel.Visibility = Visibility.Collapsed;
            isCartOpen = false;
        }
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The order has been placed! Thank you ♥️", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            CartPanel.Visibility = Visibility.Collapsed;
            isCartOpen = false;
        }

        private async void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogoutOverlay.Visibility = Visibility.Visible;

            Storyboard spinner = (Storyboard)FindResource("SpinnerAnimation");
            spinner.Begin();

            Logger.Log("Logged out");

            // Ждать 1.5 секунды для анимации
            await Task.Delay(1500);

            UserAuthorization loginWindow = new UserAuthorization();
            loginWindow.Show();
            Application.Current.MainWindow = loginWindow;
            this.Close();
        }


    }
}
