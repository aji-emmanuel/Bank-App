using Operations;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class WithdrawalForm : UserControl
    {
        AccountOperations account = new AccountOperations();

        public WithdrawalForm()
        {
            InitializeComponent();
            InitialiseComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = comboBox1.SelectedValue.ToString();
            string amount = textBox2.Text;
            string description = textBox3.Text;

            if (amount == String.Empty)
            {
                MessageBox.Show("Enter an amount!");
            }
            else
            {
                if (amount.ValidateAmount() != true)      // Validates user's inputed amount
                {
                    MessageBox.Show("Invalid Amount! Minimum of #100. No special character allowed!");
                }
                else
                {
                    decimal Amount = Convert.ToDecimal(amount);
                    bool success = account.Withdraw(accountNumber, description, Amount);
                    if (success)
                    {
                        MessageBox.Show("WithDrawal Successful!");
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance!");
                    }
                }
            }
        }

        private void InitialiseComboBox()
        {
            comboBox1.DataSource = AccountQueries.GetUserAccounts();
        }
    }
}

