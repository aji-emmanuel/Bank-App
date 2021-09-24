using Models;
using SQLQueries;
using System;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class AccountDetailsForm : UserControl
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
            InitialiseComboBox();
            InitialiseLabel2();
        }

        /// <summary>
        /// Displays User Account Name, Number and Type
        /// </summary>

        private void InitialiseComboBox()
        {
            comboBox1.DataSource = AccountQueries.GetUserAccounts();
            label9.Text = SignInForm.AccountName;
        }

        private void InitialiseLabel2()
        {
            if (comboBox1.SelectedValue != null)
            {
                string accountNumber = comboBox1.SelectedValue.ToString();
                Account account = AccountQueries.GetAccountDetails(accountNumber);
                balanceOutput.Text = String.Format("{0:N}", account.AccountBalance);
                label2.Text = account.AccountType;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitialiseLabel2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            (new AboutUs()).ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            (new Contact()).ShowDialog();
            this.Show();
        }
    }
}
