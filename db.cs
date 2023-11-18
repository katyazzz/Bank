using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public List<(int, float)> GetAccountNumbersWithBalance(int ID_Klient)
        {
            List<(int, float)> accountInfo = new List<(int, float)>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AccountNumber, Balance FROM PersonalAccount WHERE ID_Klient = @ID_Klient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Klient", ID_Klient);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int accountNumber = reader.GetInt32(0);
                            float balance = (float)reader.GetDouble(1);
                    
                            accountInfo.Add((accountNumber,balance));
                        }
                    }
                }
            }

            return accountInfo;
        }


        public List<(int, DateTime, float)> 
            GetDeposits(int ID_Klient)
        {
            List<(int, DateTime, float)> depositInfo = new List<(int, DateTime, float)>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Deposit, StartDate, Summa FROM Deposit WHERE ID_Klient = @ID_Klient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Klient", ID_Klient);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int depositID = reader.GetInt32(0);
                            DateTime startDate = reader.GetDateTime(1);
                            float summa = (float)reader.GetDouble(2);

                            depositInfo.Add((depositID, startDate, summa));
                        }
                    }
                }
            }

            return depositInfo;
        }



        public (int, string, string) GetStaffInfoByID(int ID_Staff)
        {
            int ID = -1;
            string fullName = string.Empty;
            string position = string.Empty;

            string query = "SELECT ID_Staff, FIO, Post FROM staff WHERE ID_Staff = @ID_Staff";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Staff", ID_Staff);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ID = reader.GetInt32(0);
                            fullName = reader.GetString(1);
                            position = reader.GetString(2);
                        }
                    }
                }
            }

            return (ID, fullName, position);
        }




    }


    internal class db
    {
    }
}
