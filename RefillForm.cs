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
    public partial class RefillForm : Form
    {
        public RefillForm()
        {
            InitializeComponent();
        }

        private int accountNumber;
        private int transactNumber;
        private DatabaseHelper db;
        private int ID_Staff;


        public RefillForm(int accountNumber, DatabaseHelper db, int ID_Staff)
        {
            InitializeComponent();

            this.accountNumber = accountNumber;
            this.db = db;
            this.ID_Staff = ID_Staff;
     
        }


        private void RefillForm_Load(object sender, EventArgs e)
        {

        }

      
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Получение суммы для пополнения из текстового поля
                if (float.TryParse(txtAmount.Text, out float amount))
                {
                    // Получаем информацию о сотруднике
                    (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

                    int staffID = staffInfo.Item1;

                    // Вызов процедуры для пополнения счета
                    db.DepositMoney(accountNumber, amount, staffID);

                    // Если код дошел до этого момента, значит операция прошла успешно
                    MessageBox.Show("Счет успешно пополнен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму для пополнения.");
                }
            }
            catch (Exception ex)
            {
                // Если произошло исключение, то, вероятно, счет закрыт
                MessageBox.Show($"Ошибка при попытке пополнения счета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

    }
}
