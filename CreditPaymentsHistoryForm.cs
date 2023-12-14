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
        private BindingSource bindingSource;
        private DatabaseHelper db;
        private int pasSeries;
        private int pasNumber;

        public CreditPaymentsHistoryForm(int pasSeries, int pasNumber, DatabaseHelper db)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            this.db = db;
            this.pasSeries = pasSeries;
            this.pasNumber = pasNumber;

            // Инициализация DataGridView
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridViewCreditPaymentsHistory.AutoGenerateColumns = true;
            dataGridViewCreditPaymentsHistory.DataSource = bindingSource;

            // Добавление обработчика события для сортировки
            dataGridViewCreditPaymentsHistory.ColumnHeaderMouseClick += dataGridViewCreditPaymentsHistory_ColumnHeaderMouseClick;
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

                        // Проверяем наличие столбца "Номер Кредита" в таблице
                        if (dataTable.Columns.Contains("Номер Кредита"))
                        {
                            bindingSource.DataSource = dataTable;
                            dataGridViewCreditPaymentsHistory.DataSource = bindingSource;
                        }
                        else
                        {
                            MessageBox.Show("Столбец 'Номер Кредита' не найден в таблице данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void dataGridViewCreditPaymentsHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCreditPaymentsHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Обработка щелчка по заголовку столбца для сортировки
                DataGridViewColumn newColumn = dataGridViewCreditPaymentsHistory.Columns[e.ColumnIndex];
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
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сортировке: {ex.Message}");
            }
        }

        private string GetSortDirectionString(ListSortDirection direction)
        {
            return direction == ListSortDirection.Ascending ? "ASC" : "DESC";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Фильтрация данных по номеру кредита при изменении текста в TextBox
                bindingSource.Filter = $"[Номер Кредита] = '{textBox1.Text}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при фильтрации: {ex.Message}");
            }
        }
    }
}
