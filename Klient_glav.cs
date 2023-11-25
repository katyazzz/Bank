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

            LoadClientAccounts(ID_Klient);
            LoadClientDeposits();
            LoadClientCredits();
        }

        private void LoadClientAccounts(int ID_Klient)
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetClientAccounts", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Klient", this.ID_Klient);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridPA.DataSource = dataTable;

                        dataGridPA.Columns["AccountNumber"].HeaderText = "Номер счета";
                        dataGridPA.Columns["DateOfOpening"].HeaderText = "Дата открытия";
                        dataGridPA.Columns["DateOfClosing"].HeaderText = "Дата закрытия";
                        dataGridPA.Columns["Balance"].HeaderText = "Баланс";
                        dataGridPA.Columns["Stat"].HeaderText = "Статус";
                    }
                }
            }
        }

        private void LoadClientDeposits()
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetClientDeposit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Klient", this.ID_Klient);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridDep.DataSource = dataTable;

                        // Переименование столбцов, если необходимо
                        dataGridDep.Columns["ID_Deposit"].HeaderText = "ID депозита";
                        dataGridDep.Columns["StartDate"].HeaderText = "Дата начала";
                        dataGridDep.Columns["EndDate"].HeaderText = "Дата окончания";
                        dataGridDep.Columns["Summa"].HeaderText = "Сумма";
                        dataGridDep.Columns["Stat"].HeaderText = "Статус";
                    }
                }
            }
        }

        private void LoadClientCredits()
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetClientCredit", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Klient", this.ID_Klient);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridCredit.DataSource = dataTable;

                        // Переименование столбцов, если необходимо
                        dataGridCredit.Columns["ID_Credit"].HeaderText = "ID кредита";
                        dataGridCredit.Columns["StartDate"].HeaderText = "Дата начала";
                        dataGridCredit.Columns["EndDate"].HeaderText = "Дата окончания";
                        dataGridCredit.Columns["Summa"].HeaderText = "Сумма";
                        dataGridCredit.Columns["Stat"].HeaderText = "Статус";
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Klient_glav_Load(object sender, EventArgs e)
        {
            //LoadClientAccounts(ID_Klient);
        }

        private void listPersonalAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
