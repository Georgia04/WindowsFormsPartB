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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void resultsForm_Load(object sender, EventArgs e)
        {
            double n1, n2, answer;

            try
            {
                n1 = Convert.ToDouble(totalBill.Text);
                n2 = Convert.ToDouble(peopleNumber.Text);
                answer = n1 / n2;
                eachPays.Text = answer.ToString();
                n1 = Convert.ToDouble(totalBill.Text);
            }

            catch
            {
                MessageBox.Show("Error in Data Entry");
            }

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
