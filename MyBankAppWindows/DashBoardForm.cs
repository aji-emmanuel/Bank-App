using System;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();

            AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(accountDetailsForm);
        }

        private void DepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(depositForm);
        }

        private void WithDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawalForm withdrawForm = new WithdrawalForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(withdrawForm);
        }

        private void TransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(transferForm);
        }

        private void AccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(accountDetailsForm);
        }

        private void AccountStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountStatementForm accountStatementForm = new AccountStatementForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(accountStatementForm);
        }

        private void CreateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            PlaceHolder.Controls.Clear();
            PlaceHolder.Controls.Add(createAccountForm);
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
