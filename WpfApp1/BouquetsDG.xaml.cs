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
    /// Логика взаимодействия для BouquetsDG.xaml
    /// </summary>
    public partial class BouquetsDG : Window
    {
        public BouquetsDG()
        {
            InitializeComponent();
            LoadBouquets();
        }
        private void LoadBouquets()
        {
            DataTable dBouquets = DatabaseHelper.GetBouquets();
            BouquetsDataGrid.ItemsSource = dBouquets.DefaultView;
        }
    }
}
