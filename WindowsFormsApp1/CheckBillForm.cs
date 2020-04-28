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
    public partial class CheckBillForm : Form
    {
        public CheckBillForm()
        {
            InitializeComponent();
        }

        private void backForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataEntryForm2 entryForm2 = new DataEntryForm2();
            entryForm2.ShowDialog();
            this.Close();
        }
    }
}
