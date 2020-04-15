using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    /// <summary>
    /// This task shows a welcome message and which is the best computer
    /// and best software
    /// Author: Georgia
    /// </summary>
    public partial class WelcomeForm : Form
    {
        public  WelcomeForm()
        {
            InitializeComponent();
        }

        private void greetingLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            bragLabel.Text = "Supa Dupa Computer\n Selling for $339";
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            bragLabel.Text = "Windows 10\n A real bargain at 29.90";
            bragLabel.BackColor = Color.LightYellow;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
