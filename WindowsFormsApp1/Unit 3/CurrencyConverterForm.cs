using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Unit_3
{
    public partial class CurrencyconverterForm : Form
    {
        public CurrencyconverterForm()
        {
            InitializeComponent();
        }

        private void currencyconverterForm_Load(object sender, EventArgs e)
        {

        }

        private void radioDollars_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.8;
            convertAmount.Text = amount.ToString() + " Dollars";

        }

        private void radioEuros_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.4;
            convertAmount.Text = amount.ToString() + " Euros";
        }

        private void radioRupees_CheckedChanged(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(UKPounds.Text) * 1.4;
            convertAmount.Text = amount.ToString() + " Euros";
        }
    }
}
