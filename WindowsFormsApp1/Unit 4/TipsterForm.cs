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
     
        private double billNumber, peopleNumber, answer;
        private double tipFee = 0.00;
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void tipsterForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a bill Amount", "Enter Bill");
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectNoneRadio(object sender, EventArgs e)
        {
            tipFee = 0.0;
        }

        private void selectNormalRadio(object sender, EventArgs e)
        {
            tipFee = 0.3;
        }

        private void selectGenerousRadio(object sender, EventArgs e)
        {
            tipFee = 0.15;
        }

        private void selectMadRadio(object sender, EventArgs e)
        {
            tipFee = 0.2;
        }

        private void listPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            peopleNumber = listPeople.SelectedIndex + 1;
        }

        private void calculateForm_Click(object sender, EventArgs e) 
       {
         ResultsForm Results = new ResultsForm();
         Results.peopleNumber.Text = listPeople.Text.ToString();
         Results.totalBill.Text = textBill.Text;

          try
          {
          billNumber = Convert.ToDouble(textBill.Text);
          billNumber = billNumber * (1 + tipFee);
          answer = billNumber / peopleNumber;
          }
          catch
          {
           MessageBox.Show("Error in Data Entry");
          }
                Results.totalBill.Text = billNumber.ToString();
                Results.eachPays.Text = answer.ToString();
                Results.Show();
        }        
    }
}
