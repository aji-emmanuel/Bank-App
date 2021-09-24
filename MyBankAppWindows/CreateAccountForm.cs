using Models;
using SQLQueries;
using System;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class CreateAccountForm : UserControl
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AccountType = radioButton1.Checked ? "Savings" : "Current";
            decimal AccountBalance = 100.00M;
            string AccountId = Guid.NewGuid().ToString();
            string AccountNumber;

            AccountNumber = AccountQueries.GenAccountNo();
            Account newAccount = new Account(AccountId, SignInForm.AccountName, AccountNumber, AccountType, AccountBalance);
            bool success = AccountQueries.AddUserAccount(newAccount);
            if (success)
                MessageBox.Show($"   Your Account was Successfully Created!\n\nYour Account Number is: {newAccount.AccountNumber}\n" +
                    $"Your AccountType is: {newAccount.AccountType} Account.\nYour Account Starting Balance is: {newAccount.AccountBalance}");
            else
                MessageBox.Show($"Account creation Unsuccessful! Try Again.");
        }
    }
}
