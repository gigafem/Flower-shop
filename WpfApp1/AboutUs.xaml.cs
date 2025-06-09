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
    public partial class AboutUs : Window
    {
        public AboutUs()
        {
            InitializeComponent();
        }
        public static class SessionManager
        {
            public static bool IsUserLoggedIn { get; set; } = false;
            public static string? CurrentUsername { get; set; } = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                if (!SessionManager.IsUserLoggedIn)
                {
                    MessageBox.Show("Only registered users can leave reviews.",
                                            "Access is prohibited",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Warning);
                    return;
                }

                AboutUs reviewsWindow = new AboutUs();
                reviewsWindow.Show();
                Application.Current.MainWindow = reviewsWindow;
            
            }

     }
}

