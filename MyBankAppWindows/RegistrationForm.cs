using System;
using System.Windows.Forms;
using Utilities;
using Operations;
using SQLQueries;

namespace MyBankAppWindows
{
    public partial class RegistrationForm : Form
    {
        readonly UserOperations user = new UserOperations();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox1.Text;

            if (firstNameBox.Text == String.Empty || lastNameBox.Text == String.Empty ||
               emailBox.Text == String.Empty || passwordBox1.Text == String.Empty || passwordBox2.Text == String.Empty)
            {
                MessageBox.Show("All fields must be filled!");
            }
            else
            {
                if (!Validator.ValidateName(firstName) || !Validator.ValidateName(lastName))
                {
                    MessageBox.Show("Invalid Name format. It should begin with a capital letter folled by small letters");
                }
                else
                {
                    if (!Validator.ValidateEmail(email))
                    {
                        MessageBox.Show("Invalid Email format");
                    }
                    else
                    {
                        if (!Validator.ValidatePassword(password))
                        {
                            MessageBox.Show("             Invalid Password.\nPassword should be minimum " +
                                "6 characters that include alphanumeric \nand at least one special characters (@, #, $, %, ^, &, !)");
                        }
                        else if (passwordBox1.Text != passwordBox2.Text)
                        {
                            MessageBox.Show("Passwords does not match!", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(UserQueries.ValidateRegEmail(email)!=null)
                        {
                            MessageBox.Show("This email is already registered!", "Registration Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                string userId = Guid.NewGuid().ToString();
                                string accountName = firstName + " "+ lastName; 
                                bool success = user.UserRegistration(userId, accountName, email, password);
                                if (success)
                                {
                                    MessageBox.Show($"Congratulations {accountName}, your Registration was Successful!");
                                    this.Dispose();
                                    new SignInForm().Show();
                                }
                                else
                                    MessageBox.Show("Registration was Unsuccessful. Please try Again Later!");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Dispose();
            new WelcomeForm().Show();
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void passwordBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
