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
    /// This form asks the user to put their details 
    /// for the participation
    /// Author: Georgia
    /// </summary>
    public partial class DataEntryForm2 : Form
    {
        private double billTotal = 50;
        public static int oxfordnum= 0;
        public static int cambridgenum = 0;
        public static int leedsnum = 0;
        public static decimal oxfordnumbill = 0;
        public static decimal cambridgenumbill = 0;
        public static decimal leedsnumbill = 0;

        public DataEntryForm2()
        {
            InitializeComponent();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            CheckBillForm billForm = new CheckBillForm();
            Application.Exit();
        }

        private void showBill(object sender, EventArgs e)
        {
            CheckBillForm billForm = new CheckBillForm();
            string[] universities = new string[] { "University of Oxford", "University of Cambridge", "University of Leeds" };
            if (nameBox.Text == "")
            {
                MessageBox.Show("Please Enter a Name!", "Data Entry Error");
            }

            billTotal = 50;
            if (radioDinner.Checked && radioLunch.Checked)
            {
                billTotal = billTotal + 25;
            }
            else if (radioDinner.Checked)
            {
                billTotal= billTotal + 15;
            }
            else if (radioLunch.Checked)
            {
                billTotal = billTotal + 10;
            }

            billForm.firstnameBox.Text = nameBox.Text;
            billForm.universityBox.Text = universities[universityCombo.SelectedIndex];
            billForm.BillTotal.Text = billTotal.ToString();

            if (radioDinner.Checked == true)
            {
                billForm.selectOption.Text = "Dinner Selected";
                billForm.selectOption.Visible = true;
            }
            else if (radioLunch.Checked == true)
            {
                billForm.selectOption.Text = "Lunch Selected";
                billForm.selectOption.Visible = true;
            }

            billForm.Show();
        }

        private void showTotal(object sender, EventArgs e)
        {
            int totalnum = oxfordnum + cambridgenum + leedsnum;
            decimal totalbill = oxfordnumbill + cambridgenumbill + leedsnumbill;
            TotalsForm totals  = new TotalsForm (totalnum, oxfordnum, cambridgenum, leedsnum, totalbill, oxfordnumbill, cambridgenumbill, leedsnumbill);
            totals.Show();
        }
    }
}
