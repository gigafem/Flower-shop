using DocumentFormat.OpenXml.Wordprocessing;
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
using System.Windows.Threading;
using WpfAnimatedGif;

namespace WpfApp1.ViewModel
{
    /// <summary>
    /// Логика взаимодействия для SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        public SplashWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded;

            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/Loading/LoadingGIF.gif");
            image.EndInit();

            ImageBehavior.SetAnimatedSource(LoadingGIF, image);
        }
        
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "Loading...";
            await Task.Delay(1500); 
            StatusText.Text = "Connecting to the database...";
            await Task.Delay(3000); 
            StatusText.Text = "Done!";
            await Task.Delay(1500);
        }

    }

}
