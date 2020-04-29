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
        public int lunchOption, dinnerOption, university;
        public string name;
        public double total1, total2, total3;
        public int totalBill1, totalBill2, totalBill3, totalAll;
        public string universityName;
        
        
        public DataEntryForm2()
        {
            InitializeComponent();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            CheckBillForm billForm = new CheckBillForm();
            Application.Exit();
        }

        private void billForm_Click(object sender, EventArgs e)
        {
            CheckBillForm billForm = new CheckBillForm();
            billForm.firstnameBox.Text = this.nameBox.Text;
            billForm.universityBox.Text = this.universityCombo.Text;

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
    }
}
