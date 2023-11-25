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
    public partial class CreditPaymentsHistoryKlientForm : Form
    {

        private DataGridView dataGridCreditPaymentsHistory;
        private int ID_Klient;
        private DatabaseHelper db;

        public CreditPaymentsHistoryKlientForm(int ID_Klient, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Klient = ID_Klient;
            this.db = db;

            LoadCreditPaymentsHistory();
        }

        private void LoadCreditPaymentsHistory()
        {
            string connectionString = "your_connection_string_here";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetCreditPaymentsHistoryKlient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Klient", ID_Klient);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridHis.DataSource = dataTable;
                    }
                }
            }
        }

        private void CreditPaymentsHistoryKlientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
