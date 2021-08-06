using Operations;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class WithdrawalForm : UserControl
    {
        readonly TransactionOperation transaction = new TransactionOperation();
        readonly AccountOperations accountControl = new AccountOperations();

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

            if (amount.ValidateAmount() != true)      // Validates user's inputed amount
            {
                MessageBox.Show("Invalid Amount! Minimum of #100.");
            }
            else
            {
                decimal Amount = Convert.ToDecimal(amount);

                decimal newBalance = accountControl.Withdraw(accountNumber, Amount);

                if (newBalance == -1)
                {
                    MessageBox.Show("Insufficient Balance!");
                }
                else
                {
                    bool success = transaction.DebitTransaction(accountNumber, amount.ToString(), description, newBalance);
                    if (success)
                    {
                        MessageBox.Show("WithDrawal Successful!");
                    }
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
        }
       

        private void InitialiseComboBox()
        {
            comboBox1.DataSource = AccountQueries.GetUserAccounts();
        }
    }
}

