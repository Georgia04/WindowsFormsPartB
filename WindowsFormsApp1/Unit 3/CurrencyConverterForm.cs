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
    /// This class converts UK pounds into 
    /// euros, dollars or rupees amount
    /// author: Georgia
    /// </summary>
    public partial class CurrencyconverterForm : Form
    {
        public CurrencyconverterForm()
        {
            InitializeComponent();
        }

        private void calculateDollars(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.6;
            convertAmount.Text = amount.ToString() + " Dollars";
        }

        private void calculateEuros(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.9;
            convertAmount.Text = amount.ToString() + " Euros";
        }

        private void calculateRupees(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 60;
            convertAmount.Text = amount.ToString() + " Rupees";
        }

        private void quitForm(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (resultMessage == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("Cancelled");

            }
        }
    }
}
