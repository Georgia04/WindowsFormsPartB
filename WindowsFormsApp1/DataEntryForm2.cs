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
    public partial class DataEntryForm2 : Form
    {
        int dinnerCost, endCost;
        
        public DataEntryForm2()
        {
            InitializeComponent();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void billForm_Click(object sender, EventArgs e)
        {
            CheckBillForm billForm = new CheckBillForm();
            billForm.firstnameBox.Text = this.firstName.Text;
            billForm.surnameBox.Text = this.surName.Text;
            billForm.universityBox.Text = this.universityCombo.Text;
            billForm.Show();
        }

        private void fishpieCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fishpieCheck.Checked) 
            {
                dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void pastaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (pastaCheck.Checked)
            {
                dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void chickenCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chickenCheck.Checked)
            {
                dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void risottoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (risottoCheck.Checked)
            {
                dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void lasagneCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lasagneCheck.Checked)
            {
                dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void budgetCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (budgetCheck.Checked) 
            {
               dinnerCost = 15;
            }
            endCost = dinnerCost;
            billPrice.Text = "£ " + endCost.ToString("0.00");
        }
    }
}
