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
    public partial class OpenDepositForm : Form
    {
        public OpenDepositForm()
        {
            InitializeComponent();
        }

        private DatabaseHelper db;
        private int ID_Staff;
        private int pasSeries;
        private int pasNumber;

        public OpenDepositForm(int ID_Staff, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Staff = ID_Staff;
            this.db = db;
        }

        public void SetPassportData(int series, int number)
        {
            // Устанавливаете данные в соответствующие элементы формы
            pasSeries= series;
            pasNumber= number;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Получение суммы для пополнения из текстового поля
            if (float.TryParse(txtSumma.Text, out float summa))
            {
                int depositCode = int.Parse(txtDepositCode.Text); 
                // Получаем информацию о сотруднике
                (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

                int idStaff = staffInfo.Item1;

                // Вызов процедуры для пополнения счета
                int newDepositID = db.OpenNewDeposit(pasSeries, pasNumber, summa, depositCode, idStaff);
                // Обновите интерфейс или выведите сообщение об успешном открытии вклада
                MessageBox.Show($"Новый вклад открыт с ID: {newDepositID}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Закрываем форму пополнения после успешного выполнения операции
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму для пополнения.");
            }
        }
    }
}
