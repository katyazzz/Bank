using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public MoneyTransferForm(int senderAccountNumber,  DatabaseHelper db)
        {
            InitializeComponent();

            this.senderAccountNumber = senderAccountNumber;

            //this.accountNumber = accountNumber;
            //this.transactNumber = transactNumber;
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
                // Вызываем методы DepositMoney и WithdrawMoney из объекта db
                // для счета отправителя и счета получателя соответственно
                //int transactNumber = GetNextTransactNumber();  // Ваш метод для получения следующего номера транзакции
                db.WithdrawMoney(transactNumber, senderAccountNumber, transferAmount, ID_Staff);
                db.DepositMoney(transactNumber, recipientAccountNumber, transferAmount, ID_Staff);

                // Ваш дополнительный код...

                MessageBox.Show("Перевод выполнен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем форму после успешного выполнения операции
                this.Close();
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
