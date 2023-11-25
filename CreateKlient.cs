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
            Klient_Creation.Parameters["@fio"].Value = txtfio.Text;
            Klient_Creation.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            Klient_Creation.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);
            Klient_Creation.Parameters["@bd"].Value = txtbd.Value;
            Klient_Creation.Parameters["@sex"].Value =txtsex.Text;
            // открыть соединение с БД
            Connect.Open();
            // выполнить sql-выражение (хранимую процедуру) и вернуть количество измененных записей
            Klient_Creation.ExecuteNonQuery();
            // закрыть соединение с БД
            Connect.Close();
            // вывести значение выходного параметра
            ///int result = (int)Klient_Creation.Parameters["@id"].Value;
            ///txtid.Text = Convert.ToString(result); // на форму
                                                          // вывод результата через окно сообщения
            MessageBox.Show("Пользователь добавлен!", "Успешно", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            // examBindingSource.AddNew();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateKlient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDBankDataSet.DepositPayment". При необходимости она может быть перемещена или удалена.
            this.depositPaymentTableAdapter.Fill(this.bDBankDataSet.DepositPayment);

        }
    }
}
