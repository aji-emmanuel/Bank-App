using Operations;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class DepositForm : UserControl
    {
        AccountOperations account = new AccountOperations();

        public DepositForm()
        {
            InitializeComponent();
            InitialiseComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = comboBox1.SelectedValue.ToString();
            string amount = textBox2.Text;
            string description = textBox3.Text;

            if(amount == String.Empty)
            {
                MessageBox.Show("Enter an amount!");
            }
            else
            {
                if (amount.ValidateAmount() != true)      // Validates user's inputed amount
                {
                    MessageBox.Show("Invalid Amount! Amount should be 100 and above. ");
                }
                else
                {
                    decimal Amount = Convert.ToDecimal(amount);
                    bool success = account.Deposit(accountNumber, description, Amount);

                    if (success)
                    {
                        MessageBox.Show("Deposit Successful!");
                        textBox2.Clear();
                        textBox3.Clear();
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
