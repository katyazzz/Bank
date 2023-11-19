﻿using System;
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
    public partial class Staff_glav : Form
    {
        public Staff_glav()
        {
            InitializeComponent();
        }
        private DatabaseHelper db;
        private int ID_Staff;

        public Staff_glav(int ID_Staff, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Staff = ID_Staff;
            this.db = db;
        }
        private void Staff_glav_Load(object sender, EventArgs e)
        {
            // Получаем информацию о сотруднике
            (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

            // Отображаем информацию на форме
            sotr_tb.Text = staffInfo.Item2; // FIO
            post_tb.Text = staffInfo.Item3; // Post
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form CreateKlient = new CreateKlient();

            CreateKlient.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // присвоить значения входным параметрам функции
            ShowPerAc.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowPerAc.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            // открыть соединение с БД
            Connection.Open();
            // создать временную таблицу temp
            var temp = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp.Load(ShowPerAc.ExecuteReader());
            dataGridPA.DataSource = temp;
            Connection.Close();

            ShowVklad.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowVklad.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            Connection.Open();
            var temp1 = new DataTable();
            //устанавить связь с объектом типа dataGridView
            temp1.Load(ShowVklad.ExecuteReader());
            dataGridDep.DataSource = temp1;
            // закрыть соединение с БД
            Connection.Close();


            ShowCredit.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowCredit.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            Connection.Open();
            var temp2 = new DataTable();
            //устанавить связь с объектом типа dataGridView
            temp2.Load(ShowCredit.ExecuteReader());
            dataGridCredit.DataSource = temp2;
            // закрыть соединение с БД
            Connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Получите серию и номер паспорта из вашего кода (предположим, что у вас есть переменные pasSeries и pasNumber)
           int pasSeries = Convert.ToInt32(txtspas.Text);
            int pasNumber = Convert.ToInt32(txtnpas.Text);

            // Создайте новую форму HisOfOperations
            HisOfOperations hisOfOperationsForm = new HisOfOperations();

            // Загрузите историю по счету в новую форму
            hisOfOperationsForm.LoadAccountHistory(pasSeries, pasNumber, db);

            // Покажите новую форму
            hisOfOperationsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int pasSeries = Convert.ToInt32(txtspas.Text);
            int pasNumber = Convert.ToInt32(txtnpas.Text);
            // Проверка наличия выбранного счета в DataGridView
            if (dataGridPA.SelectedRows.Count > 0)
            {
                int selTransactNumber = -1;
                // Получение номера выбранного счета
                int selectedAccountNumber = (int)dataGridPA.SelectedRows[0].Cells["AccountNumber"].Value;

                // Создание новой формы для пополнения счета
                DebFromAccountForm DebFromAccountForm = new DebFromAccountForm(selTransactNumber, selectedAccountNumber, db);

                // Показ формы для пополнения счета
                DebFromAccountForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите счет для списания баланса.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)

        {

          
            if (int.TryParse(txtspas.Text, out int pasSeries) && int.TryParse(txtnpas.Text, out int pasNumber))
            {
                // Преобразование прошло успешно, теперь pasSeries и pasNumber содержат значения

                // Создайте новую форму DepositPaymentsHistoryForm
                DepositPaymentsHistoryForm depositPaymentsHistoryForm = new DepositPaymentsHistoryForm();

                // Загрузите историю выплат по вкладам в новую форму
                depositPaymentsHistoryForm.LoadDepositPaymentsHistory(pasSeries, pasNumber, db);

                // Покажите новую форму
                depositPaymentsHistoryForm.Show();
            }
            else
            {
                // Возникла ошибка при преобразовании, обработайте эту ситуацию
                MessageBox.Show("Некорректный формат серии или номера паспорта. Пожалуйста, введите числовые значения.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void history_credit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtspas.Text, out int pasSeries) && int.TryParse(txtnpas.Text, out int pasNumber))
            {
                // Преобразование прошло успешно, теперь pasSeries и pasNumber содержат значения

                // Создайте новую форму CreditPaymentsHistoryForm
                CreditPaymentsHistoryForm creditPaymentsHistoryForm = new CreditPaymentsHistoryForm();

                // Загрузите историю платежей по кредиту в новую форму
                creditPaymentsHistoryForm.LoadCreditPaymentsHistory(pasSeries, pasNumber, db);

                // Покажите новую форму
                creditPaymentsHistoryForm.Show();
            }
            else
            {
                // Возникла ошибка при преобразовании, обработайте эту ситуацию
                MessageBox.Show("Некорректный формат серии или номера паспорта. Пожалуйста, введите числовые значения.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pasSeries = Convert.ToInt32(txtspas.Text);
            int pasNumber = Convert.ToInt32(txtnpas.Text);

            // Подтверждение перед открытием нового счета
            DialogResult result = MessageBox.Show("Вы уверены, что хотите открыть новый счет?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Используйте DatabaseHelper для создания нового счета
                int newAccountNumber = db.CreateNewAccount(pasSeries, pasNumber);

                if (newAccountNumber != -1)
                {
                    // При необходимости выполните какие-то дополнительные действия после создания счета
                    // Например, обновите интерфейс, отобразите новый номер счета и т. д.
                    MessageBox.Show($"Новый счет успешно создан. Номер счета: {newAccountNumber}");
                }
                else
                {
                    MessageBox.Show("Не удалось создать новый счет.");
                }
            }
            // В противном случае (если result == DialogResult.No), ничего не делаем
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int pasSeries = Convert.ToInt32(txtspas.Text);
            int pasNumber = Convert.ToInt32(txtnpas.Text);
            // Проверка наличия выбранного счета в DataGridView
            if (dataGridPA.SelectedRows.Count > 0)
            {
                int selTransactNumber = -1;
                // Получение номера выбранного счета
                int selectedAccountNumber = (int)dataGridPA.SelectedRows[0].Cells["AccountNumber"].Value;

                // Создание новой формы для пополнения счета
                RefillForm refillForm = new RefillForm(selTransactNumber,selectedAccountNumber, db);

                // Показ формы для пополнения счета
                refillForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите счет для пополнения баланса.");
            }

        }

        private void sotr_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
