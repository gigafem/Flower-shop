using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WpfApp1.Core;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private readonly string[] avatarPaths = new[]
        {
            "Avatars/avatar1.png",
            "Avatars/avatar2.png",
            "Avatars/avatar3.png",
            "Avatars/avatar4.png"
        };

        public Window4()
        {
            InitializeComponent();
            SetRandomAvatar();
            TableComboBox.SelectionChanged += TableComboBox_SelectionChanged;
        }

        private void SetRandomAvatar()
        {
            var random = new Random();
            var selected = avatarPaths[random.Next(avatarPaths.Length)];
            var uri = new Uri(selected, UriKind.Relative);
            AvatarImage.Source = new BitmapImage(uri);
        }
        private void CloseTableManagement(object sender, RoutedEventArgs e)
        {
            ManagementPanel.Visibility = Visibility.Collapsed;
        }
        private void ExecuteActionButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=flowerShop;Trusted_Connection=True;";
            string selectedTable = TableComboBox.SelectedItem?.ToString();
            string action = ActionComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedTable) || string.IsNullOrWhiteSpace(action))
            {
                MessageBox.Show("Select a table and an action");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;

                try
                {
                    switch (selectedTable)
                    {
                        case "Employees":
                            string firstName = GetFieldValue("FirstNameField");
                            string lastName = GetFieldValue("LastNameField");
                            string position = GetFieldValue("PositionField");
                            string email = GetFieldValue("EmailField");
                            string role = GetFieldValue("RoleField");

                            if (action == "Insert")
                            {
                                cmd.CommandText = "INSERT INTO Employees (FirstName, LastName, Position, Email, Role) VALUES (@f, @l, @p, @e, @r)";
                            }
                            else if (action == "Update")
                            {
                                cmd.CommandText = "UPDATE Employees SET Position=@p, Email=@e, Role=@r WHERE FirstName=@f AND LastName=@l";
                            }
                            else if (action == "Delete")
                            {
                                cmd.CommandText = "DELETE FROM Employees WHERE FirstName=@f AND LastName=@l";
                            }

                            cmd.Parameters.AddWithValue("@f", firstName);
                            cmd.Parameters.AddWithValue("@l", lastName);
                            if (action != "Delete")
                            {
                                cmd.Parameters.AddWithValue("@p", position);
                                cmd.Parameters.AddWithValue("@e", email);
                                cmd.Parameters.AddWithValue("@r", role);
                            }
                            break;

                        case "LogIns":
                            string empIdLog = GetFieldValue("EmployeeIDField");
                            string username = GetFieldValue("UsernameField");
                            string password = GetFieldValue("PasswordField");
                            string logRole = GetFieldValue("RoleField");

                            if (!int.TryParse(empIdLog, out int empIDLogInt))
                            {
                                MessageBox.Show("Employee ID must be a number.");
                                return;
                            }

                            if (action == "Insert")
                                cmd.CommandText = "INSERT INTO EmployeeLogIn (EmployeeID, Username, Password, Role) VALUES (@id, @u, @p, @r)";
                            else if (action == "Update")
                                cmd.CommandText = "UPDATE EmployeeLogIn SET Username=@u, Password=@p, Role=@r WHERE EmployeeID=@id";
                            else
                                cmd.CommandText = "DELETE FROM EmployeeLogIn WHERE EmployeeID=@id";

                            cmd.Parameters.AddWithValue("@id", empIDLogInt);
                            if (action != "Delete")
                            {
                                cmd.Parameters.AddWithValue("@u", username);
                                cmd.Parameters.AddWithValue("@p", password);
                                cmd.Parameters.AddWithValue("@r", logRole);
                            }
                            break;

                        case "Orders":
                            string oIdText = GetFieldValue("OrderIDField");
                            string empId = GetFieldValue("EmployeeIDField");
                            string productId = GetFieldValue("ProductIDField");
                            string quantityText = GetFieldValue("QuantityField");
                            string dateText = GetFieldValue("OrderDateField");

                            if (!int.TryParse(oIdText, out int oId) ||
                                !int.TryParse(empId, out int empOrderId) ||
                                !int.TryParse(productId, out int prodId) ||
                                !int.TryParse(quantityText, out int quantity) ||
                                !DateTime.TryParse(dateText, out DateTime orderDate))
                            {
                                MessageBox.Show("Check that all fields are correct.");
                                return;
                            }

                            if (action == "Insert")
                            {
                                cmd.CommandText = "INSERT INTO Orders (OrderID, EmployeeID, ProductID, Quantity, OrderDate) VALUES (@oid, @eid, @pid, @q, @d)";
                            }
                            else if (action == "Update")
                            {
                                cmd.CommandText = "UPDATE Orders SET Quantity=@q, OrderDate=@d WHERE OrderID=@oid";
                            }
                            else
                            {
                                cmd.CommandText = "DELETE FROM Orders WHERE OrderID=@oid";
                            }

                            cmd.Parameters.AddWithValue("@oid", oId);
                            if (action == "Insert")
                            {
                                cmd.Parameters.AddWithValue("@eid", empOrderId);
                                cmd.Parameters.AddWithValue("@pid", prodId);
                                cmd.Parameters.AddWithValue("@q", quantity);
                                cmd.Parameters.AddWithValue("@d", orderDate);
                            }
                            else if (action == "Update")
                            {
                                cmd.Parameters.AddWithValue("@q", quantity);
                                cmd.Parameters.AddWithValue("@d", orderDate);
                            }
                            break;


                        case "Bouquets":
                        case "Compositions":
                        case "Gifts":
                            string name = GetFieldValue("NameField");
                            string desc = GetFieldValue("DescriptionField");
                            string priceText = GetFieldValue("PriceField");
                            string stockText = GetFieldValue("StockField");

                            if (!decimal.TryParse(priceText, out decimal price) || !int.TryParse(stockText, out int stock))
                            {
                                MessageBox.Show("Price must be a decimal and Stock must be an integer.");
                                return;
                            }

                            if (action == "Insert")
                                cmd.CommandText = $"INSERT INTO {selectedTable} (Name, Description, Price, Stock) VALUES (@n, @d, @p, @s)";
                            else if (action == "Update")
                                cmd.CommandText = $"UPDATE {selectedTable} SET Description=@d, Price=@p, Stock=@s WHERE Name=@n";
                            else
                                cmd.CommandText = $"DELETE FROM {selectedTable} WHERE Name=@n";

                            cmd.Parameters.AddWithValue("@n", name);
                            if (action != "Delete")
                            {
                                cmd.Parameters.AddWithValue("@d", desc);
                                cmd.Parameters.AddWithValue("@p", price);
                                cmd.Parameters.AddWithValue("@s", stock);
                            }
                            break;
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Action completed successfully!");
                    Logger.Log("The admin made changes to the database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string GetFieldValue(string fieldName)
        {
            return (FormFieldsPanel.Children
                .OfType<TextBox>()
                .First(tb => tb.Name == fieldName)).Text;
        }

        private void LoadFieldsForTable(string tableName)
        {
            FormFieldsPanel.Children.Clear();

            void AddField(string name, string tag)
            {
                FormFieldsPanel.Children.Add(new TextBox
                {
                    Name = name,
                    Margin = new Thickness(0, 0, 0, 5),
                    FontSize = 14,
                    Tag = tag,
                    Text = tag 
                });
            }

            switch (tableName)
            {
                case "Employees":
                    AddField("FirstNameField", "First Name");
                    AddField("LastNameField", "Last Name");
                    AddField("PositionField", "Position");
                    AddField("EmailField", "Email");
                    AddField("RoleField", "Role");
                    break;

                case "LogIns":
                    AddField("EmployeeIDField", "Employee ID");
                    AddField("UsernameField", "Username");
                    AddField("PasswordField", "Password");
                    AddField("RoleField", "Role");
                    break;

                case "Orders":
                    AddField("EmployeeIDField", "Employee ID");
                    AddField("ProductIDField", "Product ID");
                    AddField("QuantityField", "Quantity");
                    AddField("OrderDateField", "Order Date (yyyy-MM-dd)");
                    break;

                case "Bouquets":
                case "Compositions":
                case "Gifts":
                    AddField("NameField", "Name");
                    AddField("DescriptionField", "Description");
                    AddField("PriceField", "Price");
                    AddField("StockField", "Stock");
                    break;
            }
        

    }

    private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TableComboBox.SelectedItem == null)
                return;

            string selectedTable = TableComboBox.SelectedItem.ToString();
            LoadFieldsForTable(selectedTable);
        }

        private void ManageTablesButton_Click(object sender, RoutedEventArgs e)
        {
            ManagementPanel.Visibility = ManagementPanel.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;

            if (TableComboBox.Items.Count == 0)
            {
                TableComboBox.ItemsSource = new List<string> { "Employees", "LogIns", "Orders", "Bouquets", "Compositions", "Gifts" };
                ActionComboBox.ItemsSource = new List<string> { "Insert", "Update", "Delete" };
            }

        }


    }
}
