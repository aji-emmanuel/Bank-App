using Models;
using System;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void SignInbutton_Click(object sender, EventArgs e)
        {
            Hide();
            new SignInForm().Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            (new AboutUs()).ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            (new Contact()).ShowDialog();
            this.Show();
        }
    }
}
