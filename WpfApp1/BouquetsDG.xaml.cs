using ClosedXML.Excel;
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
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Word = DocumentFormat.OpenXml.Wordprocessing;


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

        private void ExportToExcel_Click(object sender, RoutedEventArgs e)
            {
                if (BouquetsDataGrid.ItemsSource == null)
                {
                    MessageBox.Show("There is no data for export :-( ");
                    return;
                }

                DataTable dt = new DataTable();

                foreach (DataGridColumn column in BouquetsDataGrid.Columns)
                {
                    dt.Columns.Add(column.Header.ToString());
                }

                foreach (var item in BouquetsDataGrid.ItemsSource)
                {
                    var row = dt.NewRow();
                    foreach (DataGridColumn column in BouquetsDataGrid.Columns)
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
            // Получаем таблицу из DataGrid
            DataTable dt = ((DataView)dataGrid.ItemsSource).ToTable();

            // Диалог выбора файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document (*.docx)|*.docx",
                FileName = "ExportedTable.docx"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(saveFileDialog.FileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Word.Document();
                    Word.Body body = new Word.Body();

                    // Заголовок
                    Word.Paragraph heading = new Word.Paragraph(new Word.Run(new Word.Text("Exported Table")));
                    heading.ParagraphProperties = new Word.ParagraphProperties(new Justification { Val = JustificationValues.Center });
                    body.AppendChild(heading);

                    // Создание таблицы
                    Word.Table table = new Word.Table();

                    // Свойства таблицы
                    TableProperties tblProperties = new TableProperties(
                        new TableBorders(
                            new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 },
                            new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 6 }
                        )
                    );
                    table.AppendChild(tblProperties);

                    // Заголовки
                    Word.TableRow headerRow = new Word.TableRow();
                    foreach (DataColumn column in dt.Columns)
                    {
                        Word.TableCell cell = new Word.TableCell(new Word.Paragraph(new Word.Run(new Word.Text(column.ColumnName))));
                        headerRow.Append(cell);
                    }
                    table.Append(headerRow);

                    // Данные
                    foreach (DataRow row in dt.Rows)
                    {
                        Word.TableRow dataRow = new Word.TableRow();
                        foreach (var item in row.ItemArray)
                        {
                            Word.TableCell cell = new Word.TableCell(new Word.Paragraph(new Word.Run(new Word.Text(item.ToString()))));
                            dataRow.Append(cell);
                        }
                        table.Append(dataRow);
                    }
                    body.Append(table);
                    mainPart.Document.Append(body);
                    mainPart.Document.Save();
                }

                MessageBox.Show("Data exported to Word!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
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

                // Вычисляем ширину каждой колонки
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

                // Построим разделитель
                string divider = "+" + string.Join("+", colWidths.Select(w => new string('-', w + 2))) + "+";

                StringBuilder sb = new StringBuilder();

                // Заголовок таблицы
                sb.AppendLine(divider);
                sb.Append("|");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string padded = dt.Columns[i].ColumnName.PadRight(colWidths[i]);
                    sb.Append($" {padded} |");
                }
                sb.AppendLine();
                sb.AppendLine(divider);

                // Строки
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

                // Сохраняем в файл
                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Exported to TXT!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void ExportToTXT_Click(object sender, RoutedEventArgs e)
        {
            ExportDataGridToTxt(BouquetsDataGrid);
        }

        private void ExportToWord_Click(object sender, object e)
        {
            ExportToWord(BouquetsDataGrid);
        }
    }
}
