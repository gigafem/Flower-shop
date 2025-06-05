using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp1.Core;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ContactsForAuthorizedUser.xaml
    /// </summary>
    public partial class ContactsForAuthorizedUser : Window
    {
        public ContactsForAuthorizedUser()
        {
            InitializeComponent();
        }
        
    private async void Button_Click(object sender, RoutedEventArgs e)
        {
            goInstagram.Visibility = Visibility.Visible;

            Storyboard spinner = (Storyboard)FindResource("SpinnerAnimation");
            spinner.Begin();

            Logger.Log("Visited our website");

            await Task.Delay(1500);

            Reserve window = new Reserve();
            window.Show();
            Application.Current.MainWindow = window;
            this.Close();

            Process.Start(new ProcessStartInfo("https://www.instagram.com/kostopraww/")
              {
                  UseShellExecute = true
              });
          }
    }
}
