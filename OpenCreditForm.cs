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
    public partial class OpenCreditForm : Form
    {
        private DatabaseHelper db;
        private int ID_Staff;
        private int pasSeries;
        private int pasNumber;
        public OpenCreditForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public OpenCreditForm(int ID_Staff, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Staff = ID_Staff;
            this.db = db;
        }

        public void SetPassportData(int series, int number)
        {
            // Устанавливаете данные в соответствующие элементы формы
            pasSeries = series;
            pasNumber = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение суммы для открытия кредита из текстового поля
            if (float.TryParse(txtSumma.Text, out float summa))
            {
                int creditCode = int.Parse(txtCreditCode.Text);

                // Получаем информацию о сотруднике
                (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);
                int idStaff = staffInfo.Item1;

                // Вызов процедуры для открытия нового кредита
                int newCreditID = db.OpenNewCredit(pasSeries, pasNumber, summa, creditCode, idStaff);

                // Обновите интерфейс или выведите сообщение об успешном открытии кредита
                MessageBox.Show($"Новый кредит открыт с ID: {newCreditID}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Закрываем форму после успешного выполнения операции
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите корректную сумму для открытия кредита.");
            }
        }
    }
}
