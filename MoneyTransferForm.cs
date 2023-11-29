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
    public partial class MoneyTransferForm : Form
    {
        public MoneyTransferForm()
        {
            InitializeComponent();
        }

        private int senderAccountNumber;
        private DatabaseHelper db;
        private int ID_Staff;
       // private int accountNumber;
        private int transactNumber;

        int staffID = 1000;
        public MoneyTransferForm(int senderAccountNumber,  DatabaseHelper db)
        {
            InitializeComponent();

            this.senderAccountNumber = senderAccountNumber;

            this.db = db;
           // this.ID_Staff = ID_Staff;

        }
        // Добавим метод, который будет возвращать номер счета отправителя
        public int GetSenderAccountNumber()
        {
            return senderAccountNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные из TextBox'ов
            if (int.TryParse(txtRecipientAccount.Text, out int recipientAccountNumber) &&
                float.TryParse(txtAmount.Text, out float transferAmount))
            {
                try
                {
                    // Попытка выполнить списание средств с первого счета
                    db.WithdrawMoney(senderAccountNumber, transferAmount, ID_Staff);

                    // Если списание прошло успешно, пытаемся выполнить пополнение на втором счете
                    db.DepositMoney(recipientAccountNumber, transferAmount, ID_Staff);

                    // Если все успешно, выводим сообщение об успешном переводе
                    MessageBox.Show("Перевод выполнен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Закрываем форму после успешного выполнения операции
                    this.Close();
                }
                catch (SqlException ex)
                {
                    // Обработка ошибок SQL
                    if (ex.Number == 50001)
                    {
                        MessageBox.Show("Ошибка: статус счета не открыт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 50002)
                    {
                        MessageBox.Show("Ошибка: недостаточно средств на счете.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Другие ошибки SQL
                        MessageBox.Show($"SQL Error: {ex.Number} - {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Обработка других исключений
                    MessageBox.Show($"Error: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректные данные для перевода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MoneyTransferForm_Load(object sender, EventArgs e)
        {

        }
    }
}
