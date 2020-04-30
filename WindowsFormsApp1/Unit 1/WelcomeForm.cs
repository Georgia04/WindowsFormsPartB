using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    /// <summary>
    /// This form shows a greeting message and which is the best computer
    /// and best software
    /// Author: Georgia
    /// </summary>
    public partial class WelcomeForm : Form
    {
        public  WelcomeForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showBestSoftware_Click_1(object sender, EventArgs e)
        {
            bragLabel.Text = "Windows 10\n A real bargain at 29.90";
            bragLabel.BackColor = Color.LightYellow;
        }

        private void showBestComputer_Click_1(object sender, EventArgs e)
        {
            bragLabel.Text = "Supa Dupa Computer\n Selling for $339";
        }
    }
}
