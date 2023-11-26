using Bank.Properties;
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
            LoadClientInformation();
            btnRefresh.Click += btnRefresh_Click_1;
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

        private void LoadClientInformation()
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Получение ФИО клиента из таблицы Klient
                string query = "SELECT FIO FROM Klient WHERE ID_Klient = @ID_Klient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID_Klient", this.ID_Klient);

                    string fullName = command.ExecuteScalar() as string;

                    if (!string.IsNullOrEmpty(fullName))
                    {
                        // Вывод ФИО в TextBox
                        tbFIOKlient.Text = fullName;
                    }
                }
            }
        }

        private void FreezeAccount(int accountNumber)
        {
            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("FreezeAccount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        // Выполняем процедуру и получаем результат
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Счет успешно заморожен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Невозможно заморозить счет. Возможно, статус не был 'Открыт'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при замораживании счета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли хотя бы одна строка в дата-гриде
            if (dataGridPA.SelectedRows.Count > 0)
            {
                // Извлекаем информацию о счете отправителя из выбранной строки
                DataGridViewRow selectedRow = dataGridPA.SelectedRows[0];
                int senderAccountNumber = Convert.ToInt32(selectedRow.Cells["AccountNumber"].Value);

                int staffID = 1000;

                // Проверяем, что db не null
                if (db != null)
                {
                    // Создаем форму MoneyTransferForm, передавая информацию о счете отправителя и экземпляр db
                    MoneyTransferForm moneyTransferForm = new MoneyTransferForm(senderAccountNumber, db);

                    // Отображаем форму
                    moneyTransferForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Экземпляр DatabaseHelper не был проинициализирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите счет отправителя в дата-гриде.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnfreeze_Click(object sender, EventArgs e)
        {
            // Проверяем, что в DataGridView выбрана хотя бы одна строка
            if (dataGridPA.SelectedRows.Count > 0)
            {
                // Получаем номер счета из выбранной строки
                DataGridViewRow selectedRow = dataGridPA.SelectedRows[0];
                int accountNumber = Convert.ToInt32(selectedRow.Cells["AccountNumber"].Value);

                // Замораживаем счет с помощью вашей процедуры или функции
                FreezeAccount(accountNumber);
            }
            else
            {
                MessageBox.Show("Выберите счет для заморозки.");
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Обновление всей информации
            LoadClientAccounts(ID_Klient);
            LoadClientInformation();
            LoadClientDeposits();
            LoadClientCredits();

       
        }

        private void btnhistoryPA_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранного клиента
            if (ID_Klient > 0)
            {
                // Создание и отображение формы с историей операций для всех счетов клиента
                AccountHistoryForm historyForm = new AccountHistoryForm(ID_Klient, db);
                historyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра истории операций.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnhistoryDeposit_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранного клиента
            if (ID_Klient > 0)
            {
                // Создание и отображение формы с историей операций для всех счетов клиента
                DepositPaymentsHistoryKlientForm historyForm = new DepositPaymentsHistoryKlientForm(ID_Klient, db);
                historyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра истории операций.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnhistoryCredit_Click(object sender, EventArgs e)
        {
            // Проверка наличия выбранного клиента
            if (ID_Klient > 0)
            {
                // Создание и отображение формы с историей операций для всех счетов клиента
                DepositPaymentsHistoryKlientForm historyForm = new DepositPaymentsHistoryKlientForm(ID_Klient, db);
                historyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите клиента для просмотра истории операций.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
