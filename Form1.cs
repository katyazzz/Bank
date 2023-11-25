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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int GetCurrentClientID(string login, string password,DatabaseHelper db)
        {
            int ID_Klient = -1; 

            string query = "SELECT ID_Klient FROM LoginKlient WHERE Login_Klient = @Login AND Password_Klient = @Password";

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
                        ID_Klient = Convert.ToInt32(result);
                    }
                }
            }

            return ID_Klient;
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

            int ID_Klient = GetCurrentClientID(login, password, db);
            if (ID_Klient != -1)
            {
                ///DatabaseHelper db = new DatabaseHelper(connectionString);
                Klient_glav klientGlavForm = new Klient_glav(ID_Klient, db);
                klientGlavForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

