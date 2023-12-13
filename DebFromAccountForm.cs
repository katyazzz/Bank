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
        public DebFromAccountForm(int transactNumber, int accountNumber, DatabaseHelper db, int ID_Staff)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            this.transactNumber = transactNumber;
            this.db = db;
            this.ID_Staff = ID_Staff;
        }


        private void btnDebFromAccount_Click_1(object sender, EventArgs e)
        {


            try
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
                        db.WithdrawMoney(accountNumber, amount, ID_Staff);
                        this.Close();
                    }
                    else
                    {
                        // Выводим предупреждение в виде всплывающего окна
                        MessageBox.Show("На счете недостаточно средств для выполнения списания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Выводим предупреждение в виде всплывающего окна
                    MessageBox.Show("Пожалуйста, введите корректную сумму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Выводим предупреждение в виде всплывающего окна
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

