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
    public partial class EntStaf : Form
    {
        public EntStaf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetCurrentStaffID(string login, string password, DatabaseHelper db)
        {
            int ID_Staff = -1;

            string query = "SELECT ID_Staff FROM LoginStaff WHERE Login_Staff = @Login AND Password_Staff = @Password";

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        ID_Staff = Convert.ToInt32(result);
                    }
                }
            }

            return ID_Staff;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;";
            DatabaseHelper db = new DatabaseHelper(connectionString);

            int ID_Staff = GetCurrentStaffID(login, password, db);
            if (ID_Staff != -1)
            {
                ///DatabaseHelper db = new DatabaseHelper(connectionString);
                Staff_glav staffGlavForm = new Staff_glav(ID_Staff, db);
                staffGlavForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }


            try
            {
                ///int ID_Staff = GetCurrentStaffID(login, password, db);
                if (ID_Staff != -1)
                {
                    Staff_glav staffGlavForm = new Staff_glav(ID_Staff, db);

                    ///LoadStaffInfo(staffGlavForm);
                    staffGlavForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

    }
}
