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
    public partial class DepositPaymentsHistoryForm : Form
    {
        public DepositPaymentsHistoryForm()
        {
            InitializeComponent();
        }

        public void LoadDepositPaymentsHistory(int pasSeries, int pasNumber, DatabaseHelper db)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetDepositPaymentsHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PasSeries", pasSeries);
                        command.Parameters.AddWithValue("@PasNumber", pasNumber);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Отображение только нужных столбцов
                        dataGridViewDepositPaymentsHistory.DataSource = dataTable.DefaultView.ToTable(false, "Номер счета", "Дата", "Сумма", "Остаток");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void DepositPaymentsHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
