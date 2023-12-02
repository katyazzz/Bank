using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ChangeClientPasswordForm : Form
    {
        private int clientID;
        private DatabaseHelper db;

        public ChangeClientPasswordForm()
        {
            InitializeComponent();
        }
        public ChangeClientPasswordForm(int clientID, DatabaseHelper db)
        {
            InitializeComponent();
            this.clientID = clientID;
            this.db = db;
        }

        private void ChangeClientPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = OldPasswordTextBox.Text;
            string newPassword = NewPasswordTextBox.Text;

            try
            {
                db.ChangeClientPassword(clientID, oldPassword, newPassword);
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
