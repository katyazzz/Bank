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
    public partial class DebFromAccountForm : Form
    {
        public DebFromAccountForm()
        {
            InitializeComponent();
        }
        private void DebFromAccountForm_Load(object sender, EventArgs e)
        {

        }

        private int accountNumber; 
        private int transactNumber;
        private DatabaseHelper db;
        private int ID_Staff;
        int staffID = 1000;
        public DebFromAccountForm(int transactNumber, int accountNumber, DatabaseHelper db)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            this.transactNumber = transactNumber;
            this.db = db;
        }


        private void btnDebFromAccount_Click_1(object sender, EventArgs e)
        {

            (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

            int staffID = staffInfo.Item1;

            if (float.TryParse(txtAmountDeb.Text, out float amount))
            {
                // Получаем текущий баланс счета
                float currentBalance = db.GetAccountBalance(accountNumber);

                if (currentBalance >= amount)
                {
                    // Выполняем списание средств
                    db.WithdrawMoney( accountNumber, amount, ID_Staff);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("На счете недостаточно средств для выполнения списания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

