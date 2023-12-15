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
    public partial class WithdrawForm : Form
    {
        private int selectedDepositCode;

        public WithdrawForm(int depositCode, decimal summa)
        {
            InitializeComponent();
            selectedDepositCode = depositCode;
            textBoxAmount.Text = summa.ToString();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTargetAccount.Text, out int targetAccount) && targetAccount > 0)
            {
             string result = WithdrawFromClosedDeposit(selectedDepositCode, targetAccount);

                switch (result)
                {
                    case "Success":
                        MessageBox.Show("Средства успешно переведены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    case "InsufficientFunds":
                        MessageBox.Show("Недостаточно средств на вкладе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case "NotClosed":
                        MessageBox.Show("Вклад не закрыт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    default:
                        MessageBox.Show($"Неожиданный результат: {result}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Введите корректный номер счета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string WithdrawFromClosedDeposit(int selectedDepositCode, int targetAccount)
        {
            throw new NotImplementedException();
        }

        private string WithdrawFromClosedDeposit(int depositCode, int targetAccount, decimal amount)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-JGVCKUM\\SQLEXPRESS;Initial Catalog=BDBank;Integrated Security=True;Pooling=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("WithdrawFromClosedDeposit", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DepositCode", depositCode);
                        command.Parameters.AddWithValue("@TargetAccount", targetAccount);

                        SqlParameter resultParameter = command.Parameters.Add("@Result", SqlDbType.VarChar, 50);
                        resultParameter.Direction = ParameterDirection.Output;

                        command.ExecuteNonQuery();

                        string result = resultParameter.Value.ToString();

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при вызове процедуры SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

    }
}
