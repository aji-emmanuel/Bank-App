using System;
using System.Windows.Forms;

namespace MyBankAppWindows
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                MessageBox.Show("                              Thanks for contacting us.\n    " +
               "          We will get back to you as soon as possible." +
               "\nYou can also contact our Customer Care at ajiemilo@gmail.com");
                Dispose();
            }
            else
                MessageBox.Show("No message entered!", "Sending Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
