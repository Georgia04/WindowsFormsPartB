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
    /// <summary>
    /// This form displays data entry using boxes
    /// with text inside and buttons.
    /// author: Georgia
    /// </summary>
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_Click(object sender, EventArgs e)
        {

        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstnameBox.Text + " " +
                surnameBox.Text + "\nHappy Programming " +
                "\nEnjoy programming " + firstnameBox.Text;
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToUpper();

        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToLower();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void changemessageButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            firstnameBox.BackColor = Color.LightPink;
            surnameBox.BackColor = Color.LightPink;

            messageLabel.Text = "Hi " + firstnameBox.Text + " " +
                surnameBox.Text + "\nHappy Programming " +
                "\nEnjoy programming " + firstnameBox.Text +
                "\nGet on with it Georgia";
        }

        private void townBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
