using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Klient_glav : Form
    {
        public Klient_glav()
        {
            InitializeComponent();
        }

        private DatabaseHelper db;
        private int ID_Klient;

        public Klient_glav(int ID_Klient, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Klient = ID_Klient;
            this.db = db;
            LoadAccountNumbers();
            LoadDeposits();
        }

        private void LoadAccountNumbers()
        {
            List<(int,float)> accountInfo = db.GetAccountNumbersWithBalance(ID_Klient);

            foreach (var info in accountInfo)
            {
                int accountNumber = info.Item1;
                float balance = info.Item2;


                listPersonalAccounts.Items.Add($"{accountNumber} (Баланс: {balance:C})");
            }
        }

        private void LoadDeposits()
        {
            List<(int, DateTime, float)> depositInfo = db.GetDeposits(ID_Klient);

            foreach (var info in depositInfo)
            {
                int depositID = info.Item1;
                DateTime startDate = info.Item2;
                float summa = info.Item3;

                string depositTypeInfo = GetDepositTypeInfo(depositID);
                // Добавляем отладочные выводы
                Console.WriteLine($"ID: {depositID}, Start Date: {startDate}, Summa: {summa}");
                listVklad.Items.Add($"ID: {depositID}, Start Date: {startDate}, Summa: {summa}, {{title}} ({{conditions}}, срок: {{term}} месяцев)");

            }
        }



        private string GetDepositTypeInfo(int depositCode)
        {
            string query = "SELECT Title, Conditions, Term FROM TypeOfDeposits WHERE DepositCode = @DepositCode";

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepositCode", depositCode);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string title = reader.GetString(0);
                            string conditions = reader.GetString(1);
                            int term = reader.GetInt32(2);

                            return $"{title} ({conditions}, срок: {term} месяцев)";
                        }
                    }
                }
            }

            return string.Empty;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Klient_glav_Load(object sender, EventArgs e)
        {

        }
    }
}
