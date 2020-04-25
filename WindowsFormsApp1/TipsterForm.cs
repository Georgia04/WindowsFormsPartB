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
    public partial class TipsterForm : Form
    {
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void calculateForm_Click(object sender, EventArgs e)
        {
            Convert.ToString(billBox.Text);
            Convert.ToString(peoplenumberBox.Text);
            ResultsForm Results = new ResultsForm();
            Results.peopleNumber.Text = peoplenumberBox.Text;
            Results.totalBill.Text = billBox.Text;
            this.peoplenumberBox.Text = "";
            this.billBox.Focus();
            Results.Show();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noneRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(billBox.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(billBox.Text);
            newtotal = billnum * 0;
            newtotal = newtotal + billnum;
            billBox.Text = newtotal.ToString();
        }

        private void normalRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(billBox.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(billBox.Text);
            newtotal = billnum * 0.10;
            newtotal = newtotal + billnum;
            billBox.Text = newtotal.ToString();
        }

        private void generousRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(billBox.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(billBox.Text);
            newtotal = billnum * 0.20;
            newtotal = newtotal + billnum;
            billBox.Text = newtotal.ToString();
        }

        private void madRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(billBox.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(billBox.Text);
            newtotal = billnum * 0.60;
            newtotal = newtotal + billnum;
            billBox.Text = newtotal.ToString();
        }
    }
}
