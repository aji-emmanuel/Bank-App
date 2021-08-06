using SQLQueries;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class AccountStatementForm : UserControl
    {
        public AccountStatementForm()
        {
            InitializeComponent();
            InitialiseComboBox();
        }

        /// <summary>
        /// Refreshes the Transaction details when an account is selected from the Account dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accountNumber = comboBox1.SelectedValue.ToString();
            DataTable data = TransactionQueries.ShowTransactions(accountNumber);
            if ( data.Rows.Count != 0)
                StatementGrid.DataSource = data;
            else
            {
                StatementGrid.DataSource = null;
                MessageBox.Show("No Transaction have been done on this Account");
            }
        }

        /// <summary>
        /// Gets all accounts of a signed in user
        /// </summary>

        private void InitialiseComboBox()
        {
            comboBox1.DataSource = AccountQueries.GetUserAccounts();
        }
    }
}
