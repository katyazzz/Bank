using System;
using System.Collections.Generic;
using System.Data;
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


        public int CreateNewAccount(int pasSeries, int pasNumber)
        {
            int newAccountNumber = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand createAccountCommand = new SqlCommand("CreateNewAccount", connection))
                {
                    createAccountCommand.CommandType = CommandType.StoredProcedure;

                    // Добавляем параметр для серии паспорта
                    SqlParameter pasSeriesParameter = createAccountCommand.Parameters.Add("@PasSeries", SqlDbType.Int);
                    pasSeriesParameter.Value = pasSeries;

                    // Добавляем параметр для номера паспорта
                    SqlParameter pasNumberParameter = createAccountCommand.Parameters.Add("@PasNumber", SqlDbType.Int);
                    pasNumberParameter.Value = pasNumber;

                    // Добавляем параметр для получения результата (AccountNumber)
                   SqlParameter NewAccountNumberParameter = createAccountCommand.Parameters.Add("@NewAccountNumber", SqlDbType.Int);
                   NewAccountNumberParameter.Direction = ParameterDirection.Output;

                    // Выполняем хранимую процедуру
                    createAccountCommand.ExecuteNonQuery();

                    // Получаем значение выходного параметра
                   if (NewAccountNumberParameter.Value != DBNull.Value)
                   {
                    newAccountNumber = (int)NewAccountNumberParameter.Value;
                   }
                }
            }

            return newAccountNumber;
        }

        public void DepositMoney(int transactNumber, int accountNumber, float amount, int ID_Staff)

        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
           
                using (SqlCommand depositMoneyCommand = new SqlCommand("DepositMoney", connection))
                {
                    depositMoneyCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter transactNumberParameter = depositMoneyCommand.Parameters.Add("@TransactNumber", SqlDbType.Int);
                    transactNumberParameter.Value = transactNumber;

                    // Добавляем параметр для номера счета
                    SqlParameter accountNumberParameter = depositMoneyCommand.Parameters.Add("@AccountNumber", SqlDbType.Int);
                    accountNumberParameter.Value = accountNumber;

                    // Добавляем параметр для суммы пополнения
                    SqlParameter amountParameter = depositMoneyCommand.Parameters.Add("@Amount", SqlDbType.Float);
                    amountParameter.Value = amount;

                    // Добавляем параметр для ID сотрудника
                    SqlParameter idStaffParameter = depositMoneyCommand.Parameters.Add("@ID_Staff", SqlDbType.Int);
                    idStaffParameter.Value = ID_Staff;

                    // Выполняем хранимую процедуру
                    depositMoneyCommand.ExecuteNonQuery();
                }
            }
        }

        public void WithdrawMoney(int transactNumber, int accountNumber, float amount, int ID_Staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand withdrawMoneyCommand = new SqlCommand("WithdrawMoney", connection))
                {
                    withdrawMoneyCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter transactNumberParameter = withdrawMoneyCommand.Parameters.Add("@TransactNumber", SqlDbType.Int);
                    transactNumberParameter.Value = transactNumber;

                    // Добавляем параметр для номера счета
                    SqlParameter accountNumberParameter = withdrawMoneyCommand.Parameters.Add("@AccountNumber", SqlDbType.Int);
                    accountNumberParameter.Value = accountNumber;

                    // Добавляем параметр для суммы списания
                    SqlParameter amountParameter = withdrawMoneyCommand.Parameters.Add("@Amount", SqlDbType.Float);
                    amountParameter.Value = amount;

                    // Добавляем параметр для ID сотрудника
                    SqlParameter idStaffParameter = withdrawMoneyCommand.Parameters.Add("@ID_Staff", SqlDbType.Int);
                    idStaffParameter.Value = ID_Staff;

                   

                    // Выполняем хранимую процедуру
                    withdrawMoneyCommand.ExecuteNonQuery();

                    //Console.WriteLine($"Транзакция {transactNumber} завершена успешно.");
                }
            }
        }

        public int OpenNewDeposit(int pasSeries, int pasNumber, float summa, int depositCode, int idStaff)
        {
            int newDepositID = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("OpenNewDeposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PasSeries", pasSeries);
                    command.Parameters.AddWithValue("@PasNumber", pasNumber);
                    command.Parameters.AddWithValue("@Summa", summa);
                    command.Parameters.AddWithValue("@DepositCode", depositCode);
                    command.Parameters.AddWithValue("@ID_Staff", idStaff);

                    SqlParameter newDepositIDParameter = new SqlParameter("@NewID_Deposit", SqlDbType.Int);
                    newDepositIDParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(newDepositIDParameter);

                    command.ExecuteNonQuery();

                    newDepositID = (int)newDepositIDParameter.Value;
                }
            }

            return newDepositID;
        }

        public int OpenNewCredit(int pasSeries, int pasNumber, float summa, int creditCode, int idStaff)
        {
            int newCreditID = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("OpenNewCredit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PasSeries", pasSeries);
                    command.Parameters.AddWithValue("@PasNumber", pasNumber);
                    command.Parameters.AddWithValue("@Summa", summa);
                    command.Parameters.AddWithValue("@CrediteCode", creditCode);
                    command.Parameters.AddWithValue("@ID_Staff", idStaff);

                    SqlParameter newCreditIDParameter = new SqlParameter("@NewID_Credit", SqlDbType.Int);
                    newCreditIDParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(newCreditIDParameter);

                    command.ExecuteNonQuery();

                    newCreditID = (int)newCreditIDParameter.Value;
                }
            }

            return newCreditID;
        }

        public void CloseAccount(int accountNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CloseAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    command.ExecuteNonQuery();
                }
            }
        }




    }


    internal class db
    {
    }
}
