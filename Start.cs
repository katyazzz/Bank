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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();

            form1.Show();
        }

        private void buttonSotr_Click(object sender, EventArgs e)
        {
            Form EntStaf = new EntStaf();

            EntStaf.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
