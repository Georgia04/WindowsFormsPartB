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
    /// Τhis form displays the result of the 
    /// arithmetic operations between two numbers
    /// author: Georgia
    /// </summary>
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load_1(object sender, EventArgs e)
        {
            splashscreenForm splashscreenForm = new splashscreenForm();
            splashscreenForm.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splashscreenForm.Close();
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 + number2;
            numresultLabel.Text = result.ToString();
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 - number2;
            numresultLabel.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 * number2;
            numresultLabel.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            if (number1 == 0 || number2 == 0)
            {
                MessageBox.Show("You should NOT divide by ZERO!");
            }
            else
            {
                result = number1 / number2;
                numresultLabel.Text = result.ToString();
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = Math.Pow(number1, number2);
            numresultLabel.Text = result.ToString();
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = (number1 + number2) / 2;
            numresultLabel.Text = result.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnumBox.Text = "";
            secnumBox.Text = "";
            numresultLabel.Text = "";
        }
    }
}
