using Operations;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class TransferForm : UserControl
    {
        readonly TransactionOperation transaction = new TransactionOperation();
        readonly AccountOperations accountControl = new AccountOperations();

        public TransferForm()
        {
            InitializeComponent();
            InitialiseComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox2.Text;
            string senderAccount = comboBox1.SelectedValue.ToString();
            string amount = textBox4.Text;
            string description = textBox3.Text;

            if (accountNumber.ValidateAcctNumber() != true)      // Validates user's inputed Account Number
            {
                MessageBox.Show("Invalid Account Number!");
            }
            else
            {
                if (amount.ValidateAmount() != true)      // Validates user's inputed amount
                {
                    MessageBox.Show("Invalid Amount! Amount should be a figure of 100 and above.");
                }
                else
                {
                    if (senderAccount==accountNumber)
                    {
                        MessageBox.Show("You can't transfer to yourself!");
                    }
                    else
                    {
                        if (AccountQueries.GetAccountDetails(accountNumber) != null)
                        {
                            decimal Amount = Convert.ToDecimal(amount);
                            decimal newBalance1 = accountControl.Withdraw(senderAccount, Amount);

                            if (newBalance1 != -1)
                            {
                                decimal newBalance2 = accountControl.Deposit(accountNumber, Amount);

                                if (newBalance2 != -1)
                                {
                                    bool success1 = transaction.CreditTransaction(accountNumber, amount.ToString(), description, newBalance1);
                                    bool success2 = transaction.DebitTransaction(senderAccount, amount.ToString(), description, newBalance2);
                                    if (success1 == true && success2 == true)
                                        MessageBox.Show("Transfer Successful!");
                                    textBox2.Clear();
                                    textBox3.Clear();
                                    textBox4.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Insufficient Balance");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account Number not found!");
                        }
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
