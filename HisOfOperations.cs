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
    public partial class HisOfOperations : Form
    {
        public HisOfOperations()
        {
            InitializeComponent();
        }

        public void LoadAccountHistory(int pasSeries, int pasNumber, DatabaseHelper db)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetAccountHistory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PasSeries", pasSeries);
                        command.Parameters.AddWithValue("@PasNumber", pasNumber);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Отображение только нужных столбцов
                        dataGridHistory.DataSource = dataTable.DefaultView.ToTable(false, "Номер счета", "Дата", "Сумма", "Тип операции");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void HisOfOperations_Load(object sender, EventArgs e)
        {

        }
    }
}
