using Operations;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class TransferForm : UserControl
    {
        AccountOperations account = new AccountOperations();

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

            if(accountNumber!=String.Empty || amount!=String.Empty)
            {
                if (accountNumber.ValidateAcctNumber() == true)      // Validates if user entered the correct Account Number format
                {
                    if (amount.ValidateAmount() == true)      // Validates amount the amount entered.
                    {
                        if (senderAccount != accountNumber)  // Checks if Reciever Account Number and Reciever's account Number is same.
                        {
                            if (AccountQueries.GetAccountDetails(accountNumber) != null)  // Checks if reciever Account Number is registered
                            {
                                decimal Amount = Convert.ToDecimal(amount);
                                bool success = account.Withdraw(senderAccount, description, Amount);

                                if (success)
                                {
                                    bool success2 = account.Deposit(accountNumber, description, Amount);
                                    if (success2)
                                    {
                                        MessageBox.Show("Transfer Successful!");
                                        textBox2.Clear();
                                        textBox3.Clear();
                                        textBox4.Clear();
                                    }
                                }
                                else
                                    MessageBox.Show("Insufficient Balance");
                            }
                            else
                                MessageBox.Show("Account Number not found!");
                        }
                        else
                            MessageBox.Show("You can't transfer to yourself!");
                    }
                    else
                        MessageBox.Show("Invalid Amount! Amount should be a figure of 100 and above.");
                }
                else
                    MessageBox.Show("Invalid Account Number!");
            }
            else
                MessageBox.Show("Reciever's Account Number or Amount fields can't be empty!");
        }


        private void InitialiseComboBox()
        {
            comboBox1.DataSource = AccountQueries.GetUserAccounts();
        }
    }
}
