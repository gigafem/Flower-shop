﻿using System;
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
    /// Логика взаимодействия для CompositionsDG.xaml
    /// </summary>
    public partial class CompositionsDG : Window
    {
        public CompositionsDG()
        {
            InitializeComponent();
            LoadCompositions();
        }
        private void LoadCompositions()
        {
            DataTable Compositions = DatabaseHelper.GetCompositions();
            CompositionsDataGrid.ItemsSource = Compositions.DefaultView;
        }
    }
}
