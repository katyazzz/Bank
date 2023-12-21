using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                // Установка значений параметров
                Staff_Creation.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
                Staff_Creation.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);
                Staff_Creation.Parameters["@FIO"].Value = txtfio.Text;
                Staff_Creation.Parameters["@BirthDay"].Value = txtbd.Value;
                Staff_Creation.Parameters["@Sex"].Value = txtsex.Text;
                Staff_Creation.Parameters["@Post"].Value = txtpost.Text;
                Staff_Creation.Parameters["@PhoneNumber"].Value = txtphone.Text;
                Staff_Creation.Parameters["@mail"].Value = txtmail.Text;

                // Открыть соединение с БД
                Connection.Open();

                // Выполнить SQL-выражение (хранимую процедуру) и вернуть количество измененных записей
                Staff_Creation.ExecuteNonQuery();

                MessageBox.Show("Пользователь добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // В случае ошибки SQL вывести сообщение
                MessageBox.Show($"Ошибка при добавлении пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // В случае других ошибок вывести сообщение
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрыть соединение с БД
                Connection.Close();
            }

            // Закрыть форму после выполнения операции
            this.Close();
        }

    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
