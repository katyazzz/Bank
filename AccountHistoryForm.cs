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
    public partial class AccountHistoryForm : Form
    {
        //private DataGridView dataGridHistory;
        private int ID_Klient;
        private DatabaseHelper db;


        public AccountHistoryForm(int ID_Klient, DatabaseHelper db)
        {
            
            InitializeComponent();
            this.ID_Klient = ID_Klient;
            this.db = db;

            LoadAccountHistory();
        }
        private void LoadAccountHistory()
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetAccountHistoryKlient", connection))
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

        private void AccountHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
