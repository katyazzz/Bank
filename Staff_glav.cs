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
    public partial class Staff_glav : Form
    {
        public Staff_glav()
        {
            InitializeComponent();
        }
        private DatabaseHelper db;
        private int ID_Staff;

        public Staff_glav(int ID_Staff, DatabaseHelper db)
        {
            InitializeComponent();
            this.ID_Staff = ID_Staff;
            this.db = db;
        }
        private void Staff_glav_Load(object sender, EventArgs e)
        {
            // Получаем информацию о сотруднике
            (int, string, string) staffInfo = db.GetStaffInfoByID(ID_Staff);

            // Отображаем информацию на форме
            sotr_tb.Text = staffInfo.Item2; // FIO
            post_tb.Text = staffInfo.Item3; // Post
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form CreateKlient = new CreateKlient();

            CreateKlient.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // присвоить значения входным параметрам функции
            ShowPerAc.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowPerAc.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            // открыть соединение с БД
            Connection.Open();
            // создать временную таблицу temp
            var temp = new DataTable();
            // выполнить табличную функцию и вернуть таблицу в объект Reader
            // заполнить таблицу temp данными из Reader
            temp.Load(ShowPerAc.ExecuteReader());
            dataGridPA.DataSource = temp;
            Connection.Close();

            ShowVklad.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowVklad.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            Connection.Open();
            var temp1 = new DataTable();
            //устанавить связь с объектом типа dataGridView
            temp1.Load(ShowVklad.ExecuteReader());
            dataGridDep.DataSource = temp1;
            // закрыть соединение с БД
            Connection.Close();


            ShowCredit.Parameters["@PasSeries"].Value = Convert.ToInt32(txtspas.Text);
            ShowCredit.Parameters["@PasNumber"].Value = Convert.ToInt32(txtnpas.Text);

            Connection.Open();
            var temp2 = new DataTable();
            //устанавить связь с объектом типа dataGridView
            temp2.Load(ShowCredit.ExecuteReader());
            dataGridCredit.DataSource = temp2;
            // закрыть соединение с БД
            Connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
