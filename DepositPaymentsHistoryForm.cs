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
        private BindingSource bindingSource;
        private DatabaseHelper db;
        private int pasSeries;
        private int pasNumber;
        public DepositPaymentsHistoryForm(int pasSeries, int pasNumber, DatabaseHelper db)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            this.db = db;
            this.pasSeries = pasSeries;
            this.pasNumber = pasNumber;

            dataGridViewDepositPaymentsHistory.DataSource = bindingSource;
        }
        
        public DepositPaymentsHistoryForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();

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

                        // Проверяем наличие столбца "Номер Вклада" в таблице
                        if (dataTable.Columns.Contains("Номер Вклада"))
                        {
                            bindingSource.DataSource = dataTable;
                            dataGridViewDepositPaymentsHistory.DataSource = bindingSource;
                        }
                        else
                        {
                            MessageBox.Show("Столбец 'Номер Вклада' не найден в таблице данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void dataGridViewDepositPaymentsHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Обработка щелчка по заголовку столбца для сортировки
            DataGridViewColumn newColumn = dataGridViewDepositPaymentsHistory.Columns[e.ColumnIndex];
            string propertyName = newColumn.DataPropertyName;

            // Смена направления сортировки при повторном щелчке
            ListSortDirection direction = ListSortDirection.Ascending;
            if (bindingSource.Sort != null && bindingSource.Sort.Contains(propertyName))
                direction = (bindingSource.SortDirection == ListSortDirection.Ascending)
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;

            // Применение сортировки
            bindingSource.Sort = $"{propertyName} {GetSortDirectionString(direction)}";

        }

        private string GetSortDirectionString(ListSortDirection direction)
        {
            return direction == ListSortDirection.Ascending ? "ASC" : "DESC";
        }

        private void DepositPaymentsHistoryForm_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDepositNumber_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = $"[Номер Вклада] = '{textBoxDepositNumber.Text}'";
            bindingSource.Filter = filterExpression;

            // Отладочное сообщение
            MessageBox.Show($"Applied filter: {filterExpression}");
        }

    }
}
