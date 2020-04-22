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
    /// This form moves a monkey and shows a message
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

        private void MonkeyBashForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 200);
            y = generator.Next(panel1.Height - 200);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;
            Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 200);
            y = generator.Next(panel1.Height - 200);

            pictureBox2.Left = x;
            pictureBox2.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 200);
            y = generator.Next(panel1.Height - 200);

            pictureBox3.Left = x;
            pictureBox3.Top = y;

            labelTotalHits.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 200);
            y = generator.Next(panel1.Height - 200);

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


        private void startForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void stopForm_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }
    }
}
