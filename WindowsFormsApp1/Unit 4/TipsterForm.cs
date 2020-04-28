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
    /// This form allows user to write the bill,
    /// to select the tip and the number of people 
    /// and to calculate it.
    /// author: Georgia
    /// </summary>
    public partial class TipsterForm : Form
    {
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void calculateForm_Click(object sender, EventArgs e)
        {
            Convert.ToString(textBill.Text);
            Convert.ToString(listPeople.Text);
            ResultsForm Results = new ResultsForm();
            Results.peopleNumber.Text = listPeople.Text;
            Results.totalBill.Text = textBill.Text;
            this.listPeople.Text = "";
            this.textBill.Focus();
            Results.Show();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noneRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(textBill.Text);
            newtotal = billnum * 0.00;
            newtotal = newtotal + billnum;
            textBill.Text = newtotal.ToString();
        }

        private void normalRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(textBill.Text);
            newtotal = billnum * 0.10;
            newtotal = newtotal + billnum;
            textBill.Text = newtotal.ToString();
        }

        private void generousRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(textBill.Text);
            newtotal = billnum * 0.20;
            newtotal = newtotal + billnum;
            textBill.Text = newtotal.ToString();
        }

        private void madRadio_CheckedChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBill.Text);
            double newtotal, billnum;
            billnum = Convert.ToDouble(textBill.Text);
            newtotal = billnum * 0.40;
            newtotal = newtotal + billnum;
            textBill.Text = newtotal.ToString();
        }

        private void TipsterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
