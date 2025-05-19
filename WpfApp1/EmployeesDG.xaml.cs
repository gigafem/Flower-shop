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
    public partial class EmployeesDG : Window
    {
        public EmployeesDG()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            DataTable employees = DatabaseHelper.GetEmployees();
            EmployeeDataGrid.ItemsSource = employees.DefaultView;
        }
    }
}