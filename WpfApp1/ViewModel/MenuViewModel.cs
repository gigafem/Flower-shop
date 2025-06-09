using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WpfApp1.Core;
using WpfApp1;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;

namespace WpfApp1.ViewModel { 
 class MenuViewModel
{
    public RelayCommand OpenMenuCommand { get; set; }
    public RelayCommand OpenReviewsCommand { get; set; }
    public RelayCommand OpenReserveCommand { get; set; }
    public RelayCommand OpenGuestCommand { get; set; }
    public RelayCommand OpenStaffCommand { get; set; }
    public RelayCommand OpenUserLogInCommand { get; set; }
    public RelayCommand OpenMainWindowCommand { get; set; }
    public RelayCommand OpenContactsForAuthUserCommand { get; set; }
    public RelayCommand OpenReviewsForAuthUserCommand { get; set; }
    public RelayCommand OpenCatalogForAuthUserCommand { get; set; }
    public RelayCommand OpenBouquetsForAuthUserCommand { get; set; }
    public RelayCommand OpenCompositionsForAuthUserCommand { get; set; }
    public RelayCommand OpenPresentsForAuthUserCommand { get; set; }
    public RelayCommand OpenForAuthUserCommand { get; set; }
    public RelayCommand GoBackCommand { get; set; }
    public RelayCommand GoBackMMCommand { get; set; }
    public RelayCommand GoBackCatalogCommand { get; set; }
    public RelayCommand GoBackCatalogForAuthUserCommand { get; set; }
    public RelayCommand GoBackAuthCommand { get; set; }
    public RelayCommand GoBackMMForAuthUserCommand { get; set; }
    public RelayCommand LogInCommand { get; set; }
    public RelayCommand GoBouquetsCommand { get; set; }
    public RelayCommand GoCompositionsCommand { get; set; }
    public RelayCommand GoPresentsCommand { get; set; }
    public RelayCommand GoEmployeesCommand { get; set; }
    public RelayCommand GoLogInsCommand { get; set; }
    public RelayCommand GoOrdersCommand { get; set; }
    public RelayCommand GoBouquetsDGCommand { get; set; }
    public RelayCommand GoCompositionsDGCommand { get; set; }
    public RelayCommand GoPresentsDGCommand { get; set; }

    public MenuViewModel()
        {
            OpenMenuCommand = new RelayCommand(o =>
            {
                Window1 window1 = new Window1();
                window1.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window1;
            });
            OpenGuestCommand = new RelayCommand(o =>
            {
                MainWindow window1 = new MainWindow();
                window1.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window1;
            });
            OpenStaffCommand = new RelayCommand(o =>
            {
                Window3 window = new Window3();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenUserLogInCommand = new RelayCommand(o =>
            {
                UserAuthorization window1 = new UserAuthorization();
                window1.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window1;
            });
            OpenReviewsCommand = new RelayCommand(o =>
            {
                AboutUs window = new AboutUs();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });

            OpenReserveCommand = new RelayCommand(o =>
            {
                Reserve window = new Reserve();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenMainWindowCommand = new RelayCommand(o =>
            {
                MainWindow window = new MainWindow();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenContactsForAuthUserCommand = new RelayCommand(o =>
            {
                ContactsForAuthorizedUser window = new ContactsForAuthorizedUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenReviewsForAuthUserCommand = new RelayCommand(o =>
            {
                ReviewsForAuthorizedUser window = new ReviewsForAuthorizedUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenCatalogForAuthUserCommand = new RelayCommand(o =>
            {
                CatalogForAuthUser window = new CatalogForAuthUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenBouquetsForAuthUserCommand = new RelayCommand(o =>
            {
                BouquetsForAuthUser window = new BouquetsForAuthUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenCompositionsForAuthUserCommand = new RelayCommand(o =>
            {
                CompositionsForAuthUser window = new CompositionsForAuthUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            OpenPresentsForAuthUserCommand = new RelayCommand(o =>
            {
                PresentsForAuthUser window = new PresentsForAuthUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });

            LogInCommand = new RelayCommand(o =>
            {
                Window4 window = new Window4();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });

            GoBackCommand = new RelayCommand(o =>
            {
                MainWindow window = new MainWindow();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoBackMMCommand = new RelayCommand(o =>
            {
                Window2 window = new Window2();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoBackCatalogCommand = new RelayCommand(o =>
            {
                Window1 window = new Window1();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoBackCatalogForAuthUserCommand = new RelayCommand(o =>
            {
                CatalogForAuthUser window = new CatalogForAuthUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });

            GoBackAuthCommand = new RelayCommand(o =>
            {
                UserAuthorization window = new UserAuthorization();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoBackMMForAuthUserCommand = new RelayCommand(o =>
            {
                MainWindowForAuthorizedUser window = new MainWindowForAuthorizedUser();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoBouquetsCommand = new RelayCommand(o =>
            {
                Window5 window = new Window5();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoCompositionsCommand = new RelayCommand(o =>
            {
                Window6 window = new Window6();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoPresentsCommand = new RelayCommand(o =>
            {
                Window7 window = new Window7();
                window.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = window;
            });
            GoEmployeesCommand = new RelayCommand(o =>
            {
                EmployeesDG window = new EmployeesDG();
                window.Show();
            });
            GoLogInsCommand = new RelayCommand(o =>
            {
                LogInsDG window = new LogInsDG();
                window.Show();
            });
            GoOrdersCommand = new RelayCommand(o =>
            {
                OrdersDG window = new OrdersDG();
                window.Show();
            });
            GoBouquetsDGCommand = new RelayCommand(o =>
            {
                BouquetsDG window = new BouquetsDG();
                window.Show();
            });
            GoCompositionsDGCommand = new RelayCommand(o =>
            {
                CompositionsDG window = new CompositionsDG();
                window.Show();
            });
            GoPresentsDGCommand = new RelayCommand(o =>
            {
                PresentsDG window = new PresentsDG();
                window.Show();
            });
        }
    }
}
