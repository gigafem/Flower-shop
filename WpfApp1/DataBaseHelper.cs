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

        public static DataTable GetBouquets()
        {
            return GetTable("SELECT * FROM Bouquets");
        }

        public static DataTable GetCompositions()
        {
            return GetTable("SELECT * FROM Compositions");
        }

        public static DataTable GetGifts()
        {
            return GetTable("SELECT * FROM Gifts");
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
        public static bool ValidateEmployeeLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM EmployeeLogIn WHERE username = @username AND password = @PasswordHash";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
