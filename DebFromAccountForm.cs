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

        public DebFromAccountForm(int transactNumber, int accountNumber, DatabaseHelper db)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
            this.transactNumber = transactNumber;
            this.db = db;
        }


        private void btnDebFromAccount_Click_1(object sender, EventArgs e)
        {
            if (float.TryParse(txtAmountDeb.Text, out float amount))
            {
                // Получаем информацию о сотруднике
                (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

                int staffID = staffInfo.Item1;

                db.WithdrawMoney(transactNumber, accountNumber, amount, ID_Staff);

                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму.");
            }
        }
    }
}

