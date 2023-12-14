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
    public partial class TypeOfCredits : Form
    {
        public TypeOfCredits()
        {
            InitializeComponent();
        }

        private void TypeOfCredits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDBankDataSet1.TypeOfCredits". При необходимости она может быть перемещена или удалена.
            this.typeOfCreditsTableAdapter.Fill(this.bDBankDataSet1.TypeOfCredits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDBankDataSet1.TypeOfDeposits". При необходимости она может быть перемещена или удалена.
            this.typeOfDepositsTableAdapter.Fill(this.bDBankDataSet1.TypeOfDeposits);

        }
    }
}
