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
    /// This form moves a monkey, shows a message, hits and misses
    /// when the monkey is clicked
    /// author:Georgia
    /// </summary>
    public partial class MonkeyBashForm : Form
    {
        private int x, y;

        private int hits, misses;

        private Random generator = new Random();

        public MonkeyBashForm()
        {
            InitializeComponent();
        }

        private void moveMonkey1(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;
            Refresh();
        }

        private void moveMonkey2(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox2.Left = x;
            pictureBox2.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void moveMonkey3(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox3.Left = x;
            pictureBox3.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void moveMonkey4(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 100);
            y = generator.Next(panel1.Height - 100);

            pictureBox4.Left = x;
            pictureBox4.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void startTimer(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void stopTimer(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You MISSED!");
             misses = misses + 1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void MonkeyBashForm_MouseDown(object sender, MouseEventArgs e)
        {
            messageLabel.Text = "(" + e.X + "," + e.Y + ")";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            double a, b;

            a = Math.Pow((e.X - 50), 2);
            b = Math.Pow((e.Y - 50), 2);
            labelResult.Text = "You Score: " + (100 - Math.Sqrt(a + b)).ToString("0.00");
        }

        private void clickMonkeyBash(object sender, EventArgs e)
        {
            misses++;
        }
    }
}
