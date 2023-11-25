using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class CreateEmployeeForm : Form
    {
        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Creation.Parameters["@FIO"].Value = txtfio.Text;
            Staff_Creation.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            Staff_Creation.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);
            Staff_Creation.Parameters["@BirthDay"].Value = txtbd.Value;
            Staff_Creation.Parameters["@Sex"].Value = txtsex.Text;
            Staff_Creation.Parameters["@Post"].Value = txtpost.Text;
            // открыть соединение с БД
            Connection.Open();
            // выполнить sql-выражение (хранимую процедуру) и вернуть количество измененных записей
            Staff_Creation.ExecuteNonQuery();
            // закрыть соединение с БД
            Connection.Close();

            MessageBox.Show("Пользователь добавлен!", "Успешно", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            // examBindingSource.AddNew();
            this.Close();
        }
    }
}
