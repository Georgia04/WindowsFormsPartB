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
    /// This form moves a target around and shows the hits
    /// and the misses attempts when user click on that 
    /// author: Georgia
    /// </summary>
    /// 
    public partial class TargetForm : Form
    {
        private int x, y;
        double score;
        private int hits, misses;

        private Random generator = new Random();

        public TargetForm()
        {
            InitializeComponent();
        }

        private void stopForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch!");
            hits = hits + 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            double x, y;
            Point mousePointerLocation = e.Location;
            x = mousePointerLocation.X;
            y = mousePointerLocation.Y;

            if (x == 50)
            {
                if (y == 50)
                {
                    MessageBox.Show("JACKPOT!!");
                    score = score + 50;
                }
            }

            else if (x <= 10 && y <= 50)
            {
                score = score + 10;
            }
            else if (x <= 50 && y <= 10)
            {
                score = score + 10;
            }
            else if (x >= 50 && y >= 10)
            {
                score = score + 20;
            }
            else if (x >= 10 && y >= 50)
            {
                score = score + 20;
            }
            else if (x > 50 && y < 10)
            {
                score = score + 10;
            }
            else if (x < 50 && y > 10)
            {
                score = score + 10;
            }
            else if (x < 50 && y > 50)
            {
                score = score + 15;
            }
            else if (x > 50 && y < 50)
            {
                score = score + 15;
            }
            else if (x > 50 && y > 50)
            {
                score = score + 15;
            }
            else
            {
                MessageBox.Show("Error");
            }

            this.scoreLabel.Text = score.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You MISSED!");
            misses = misses + 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            double a, b;

            a = Math.Pow((e.X - 50), 2);
            b = Math.Pow((e.Y - 50), 2);
            labelResult.Text = "You Score: " + (100 - Math.Sqrt(a + b)).ToString("0.00");
        }

        private void startForm_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void moveTarget(object sender, EventArgs e)
        {
            x = generator.Next(panel1.Width - 200);
            y = generator.Next(panel1.Height - 200);

            pictureBox1.Left = x;
            pictureBox1.Top = y;

            scoreLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }
    }
}
