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
    /// This form displays the user's choices and the bill.
    /// Author: Georgia
    /// </summary>
    public partial class CheckBillForm : Form
    {
        DataEntryForm2 form2 = new DataEntryForm2();

        public CheckBillForm()
        {
            InitializeComponent();
        }

        private void selectBack(object sender, EventArgs e)
        {
            this.Hide();
            DataEntryForm2 entryForm2 = new DataEntryForm2();
            entryForm2.ShowDialog();
            this.Close();
        }

        private void acceptBill_Click(object sender, EventArgs e)
        {
            if (universityBox.Text == "University of Leeds")
            {
                DataEntryForm2.leedsnum++;
                DataEntryForm2.leedsnumbill = DataEntryForm2.leedsnumbill + Convert.ToDecimal(BillTotal.Text);
            }
            else if (universityBox.Text == "University of Oxford")
            {
                DataEntryForm2.oxfordnum++;
                DataEntryForm2.oxfordnumbill = DataEntryForm2.oxfordnumbill + Convert.ToDecimal(BillTotal.Text);
            }
            else
            {
                DataEntryForm2.cambridgenum++;
                DataEntryForm2.cambridgenumbill = DataEntryForm2.cambridgenumbill + Convert.ToDecimal(BillTotal.Text);
            }
        }
    }
}
