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
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void mainForm_Click(object sender, EventArgs e)
        {

        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstnameBox.Text + " " +
                surnameBox.Text + "\nHappy Programming " + 
                "\nEnjoy programming " + firstnameBox.Text;
        }

        private void firstnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
