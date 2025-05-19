using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp1.ViewModel;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var splash = new SplashWindow();
            splash.Show();

            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(4000); // имитация загрузки

                Dispatcher.Invoke(() =>
                {
                    var mainWindow = new Window2();
                    mainWindow.Show();
                    splash.Close();
                });
            });
        }
    }
}
