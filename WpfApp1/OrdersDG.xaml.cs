using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.Win32;
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
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.IO;


namespace WpfApp1
{
    
    public partial class OrdersDG : Window
    {
        public OrdersDG()
        {
            InitializeComponent();
            LoadOrders();
        }
        private void LoadOrders()
        {
            DataTable Orders = DatabaseHelper.GetOrders();
            OrdersDataGrid.ItemsSource = Orders.DefaultView;
        }

        private void ExportToExcel_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersDataGrid.ItemsSource == null)
            {
                MessageBox.Show("There is no data for export :-( ");
                return;
            }

            DataTable dt = new DataTable();

            foreach (DataGridColumn column in OrdersDataGrid.Columns)
            {
                dt.Columns.Add(column.Header.ToString());
            }

            foreach (var item in OrdersDataGrid.ItemsSource)
            {
                var row = dt.NewRow();
                foreach (DataGridColumn column in OrdersDataGrid.Columns)
                {
                    if (column.GetCellContent(item) is TextBlock cellContent)
                        row[column.Header.ToString()] = cellContent.Text;
                }
                dt.Rows.Add(row);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Save as .xlsx"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var worksheet = wb.Worksheets.Add(dt, "Export");
                    worksheet.Columns().AdjustToContents();
                    wb.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("The data has been successfully exported to a file!", "Export done", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void ExportToWord(DataGrid dataGrid)
        {
            DataTable dt = ((DataView)dataGrid.ItemsSource).ToTable();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = "ExportedTable.docx"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (var doc = DocX.Create(saveFileDialog.FileName))
                {
                    doc.InsertParagraph("Table").FontSize(14).Bold().Alignment = Alignment.center;

                    var table = doc.AddTable(dt.Rows.Count + 1, dt.Columns.Count);
                    table.Design = TableDesign.ColorfulGrid;

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        table.Rows[0].Cells[i].Paragraphs[0].Append(dt.Columns[i].ColumnName).Bold();
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            table.Rows[i + 1].Cells[j].Paragraphs[0].Append(dt.Rows[i][j].ToString());
                        }
                    }

                    doc.InsertTable(table);
                    doc.Save();

                    MessageBox.Show("The data has been successfully exported to a file!", "Export done", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
        private void ExportDataGridToTxt(DataGrid dataGrid)
        {
            if (dataGrid.ItemsSource == null)
            {
                MessageBox.Show("No data to export", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = "ExportedTable.txt"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                DataView dv = dataGrid.ItemsSource as DataView;
                if (dv == null)
                {
                    MessageBox.Show("The data source must be a DataView!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                DataTable dt = dv.ToTable();

                int[] colWidths = new int[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    colWidths[i] = dt.Columns[i].ColumnName.Length;
                }

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        int length = row[i].ToString().Length;
                        if (length > colWidths[i])
                            colWidths[i] = length;
                    }
                }

                string divider = "+" + string.Join("+", colWidths.Select(w => new string('-', w + 2))) + "+";

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(divider);
                sb.Append("|");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string padded = dt.Columns[i].ColumnName.PadRight(colWidths[i]);
                    sb.Append($" {padded} |");
                }
                sb.AppendLine();
                sb.AppendLine(divider);

                foreach (DataRow row in dt.Rows)
                {
                    sb.Append("|");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string padded = row[i].ToString().PadRight(colWidths[i]);
                        sb.Append($" {padded} |");
                    }
                    sb.AppendLine();
                }

                sb.AppendLine(divider);

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Exported to TXT!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void ExportToTXT_Click(object sender, RoutedEventArgs e)
        {
            ExportDataGridToTxt(OrdersDataGrid);
        }

        private void ExportToWord_Click(object sender, object e)
        {
            ExportToWord(OrdersDataGrid);
        }
    }
}
