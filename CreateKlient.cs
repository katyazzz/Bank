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
    public partial class CreateKlient : Form
    {
        public CreateKlient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int age = CalculateAge(txtbd.Value);

                if (age >= 14)
                {
                    Klient_Creation.Parameters["@fio"].Value = txtfio.Text;
                    Klient_Creation.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
                    Klient_Creation.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);
                    Klient_Creation.Parameters["@bd"].Value = txtbd.Value;
                    Klient_Creation.Parameters["@sex"].Value = txtsex.Text;
                    Klient_Creation.Parameters["@Phone"].Value = txtphone.Text;
                    Klient_Creation.Parameters["@mail"].Value = txtmail.Text;

                    // Открыть соединение с БД
                    Connect.Open();
                    // Выполнить SQL-выражение (хранимую процедуру) и вернуть количество измененных записей
                    Klient_Creation.ExecuteNonQuery();
                    // Закрыть соединение с БД
                    Connect.Close();

                    MessageBox.Show("Пользователь добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Клиенту должно быть не менее 14 лет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;

            if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
            {
                age--;
            }

            return age;
        }
        private void CreateKlient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDBankDataSet.DepositPayment". При необходимости она может быть перемещена или удалена.
            this.depositPaymentTableAdapter.Fill(this.bDBankDataSet.DepositPayment);

        }
    }
}
