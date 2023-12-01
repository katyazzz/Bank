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
    public partial class ChangePasswordForm : Form
    {
        private int staffID;
        private string connectionString;
        private DatabaseHelper db;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(int ID_Staff, DatabaseHelper db)
        {
            InitializeComponent();
            this.staffID = ID_Staff;
            this.db = db;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение старого и нового паролей из TextBox'ов
            string oldPassword = OldPasswordTextBox.Text;
            string newPassword = NewPasswordTextBox.Text;

            try
            {
                db.ChangePassword(staffID, oldPassword, newPassword);
                MessageBox.Show("Пароль успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при смене пароля: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
