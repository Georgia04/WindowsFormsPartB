using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
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
