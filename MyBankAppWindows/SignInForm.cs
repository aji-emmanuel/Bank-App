using Models;
using SQLQueries;
using System;
using System.Windows.Forms;
using Utilities;

namespace MyBankAppWindows
{
    public partial class SignInForm : Form
    {
        public static string AccountName { get; set; }
        public static string LoggedUserId { get; set; }

        public SignInForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = textUserName.Text;
            string password = textPassword.Text;

            if (textUserName.Text != String.Empty && textPassword.Text != String.Empty)
            {
                
                if (Validator.ValidateEmail(email) && Validator.ValidatePassword(password))
                {
                    UserModel LoggedUser = UserQueries.GetSignInDetails(email, password);     // Validates Registration email
                    if ( LoggedUser!= null)
                    {
                        AccountName = LoggedUser.AccountName;
                        LoggedUserId = LoggedUser.UserId;
                        MessageBox.Show($"Welcome {AccountName}");
                        Hide();
                        new DashBoardForm().Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect UserName or Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password!");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty!");
            }
        }

        private void ClearFieldLabel_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            Dispose();
            new WelcomeForm().Show();
        }
    }
}
