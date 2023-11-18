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
    public partial class CreditPaymentsHistoryForm : Form
    {
        public CreditPaymentsHistoryForm()
        {
            InitializeComponent();
        }

        public void LoadCreditPaymentsHistory(int pasSeries, int pasNumber, DatabaseHelper db)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetCreditPaymentsHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PasSeries", pasSeries);
                        command.Parameters.AddWithValue("@PasNumber", pasNumber);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Отображение только нужных столбцов
                        dataGridViewCreditPaymentsHistory.DataSource = dataTable.DefaultView.ToTable(false, "Номер счета", "Дата", "Сумма платежа", "Остаток по кредиту");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void CreditPaymentsHistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
