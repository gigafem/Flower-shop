using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class DatabaseHelper
    {
        public static string connectionString = @"Server=.\SQLEXPRESS;Database=flowerShop;Trusted_Connection=True;";
        public static DataTable GetPresents()
        {
            return GetTable("SELECT * FROM Gifts");
        }
        public static DataTable GetCompositions()
        {
            return GetTable("SELECT * FROM Compositions");
        }
        public static DataTable GetBouquets()
        {
            return GetTable("SELECT * FROM Bouquets");
        }
        public static DataTable GetOrders()
        {
            return GetTable("SELECT * FROM Orders");
        }
        public static DataTable GetLogIns()
        {
            return GetTable("SELECT * FROM EmployeeLogIn");
        }
        public static DataTable GetEmployees()
        {
            return GetTable("SELECT * FROM Employees");
        }

        private static DataTable GetTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(dt);
            }
            return dt;
        }
        public static bool ValidateEmployeeLogin(string username, string password, out string role)
        {
            role = null;
            string query = "SELECT role FROM EmployeeLogIn WHERE username = @username AND password = @PasswordHash";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


    }

}
