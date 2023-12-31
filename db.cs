﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void DepositMoney(int accountNumber, float amount, int ID_Staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand depositMoneyCommand = new SqlCommand("DepositMoney", connection))
                {
                    depositMoneyCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter accountNumberParameter = depositMoneyCommand.Parameters.Add("@AccountNumber", SqlDbType.Int);
                    accountNumberParameter.Value = accountNumber;

                    SqlParameter amountParameter = depositMoneyCommand.Parameters.Add("@Amount", SqlDbType.Float);
                    amountParameter.Value = amount;

                    SqlParameter idStaffParameter = depositMoneyCommand.Parameters.Add("@ID_Staff", SqlDbType.Int);
                    idStaffParameter.Value = ID_Staff;

                    depositMoneyCommand.ExecuteNonQuery();
                }
            }
        }


        public void WithdrawMoney( int accountNumber, float amount, int ID_Staff)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand withdrawMoneyCommand = new SqlCommand("WithdrawMoney", connection))
                {
                    withdrawMoneyCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter accountNumberParameter = withdrawMoneyCommand.Parameters.Add("@AccountNumber", SqlDbType.Int);
                    accountNumberParameter.Value = accountNumber;

                    SqlParameter amountParameter = withdrawMoneyCommand.Parameters.Add("@Amount", SqlDbType.Float);
                    amountParameter.Value = amount;

                    SqlParameter idStaffParameter = withdrawMoneyCommand.Parameters.Add("@ID_Staff", SqlDbType.Int);
                    idStaffParameter.Value = ID_Staff;

                    withdrawMoneyCommand.ExecuteNonQuery();
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
            float accountBalance = GetAccountBalance(accountNumber);

            // Проверяем, что баланс счета равен 0 перед закрытием
            if (accountBalance == 0)
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

                MessageBox.Show($"Счет {accountNumber} успешно закрыт.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нельзя закрыть счет с положительным балансом. Переведите деньги на другой счет или снимите их.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float GetAccountBalance(int accountNumber)
        {
            float balance = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT Balance FROM PersonalAccount WHERE AccountNumber = @AccountNumber", connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balance = Convert.ToSingle(reader["Balance"]);
                        }
                    }
                }
            }

            return balance;
        }

        public void ChangePassword(int staffID, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("ChangePassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID_Staff", staffID);
                    command.Parameters.AddWithValue("@OldPassword", oldPassword);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ChangeClientPassword(int clientID, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("ChangeClientPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ClientID", clientID);
                    command.Parameters.AddWithValue("@OldPassword", oldPassword);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    command.ExecuteNonQuery();
                }
            }
        }




    }


}
