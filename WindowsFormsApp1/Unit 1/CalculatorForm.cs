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

        private void calculatorForm_Load_1(object sender, EventArgs e)
        {
            SplashscreenForm splashscreenForm = new SplashscreenForm();
            splashscreenForm.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splashscreenForm.Close();
        }

        private void addNumbers(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 + number2;
            this.BackColor = Color.LightCyan;

            numresultLabel.Text = result.ToString();
        }

        private void substractNumbers(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 - number2;
            this.BackColor = Color.Red;
            
            numresultLabel.Text = result.ToString();
        }

        private void multiplyNumbers(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = number1 * number2;
            this.BackColor = Color.Yellow;

            numresultLabel.Text = result.ToString();
        }

        private void divideNumbers(object sender, EventArgs e)
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
                this.BackColor = Color.Pink;

                numresultLabel.Text = result.ToString();
            }
        }

        private void raiseToPower_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = Math.Pow(number1, number2);
            numresultLabel.Text = result.ToString();
        }

        private void calculateAverage_Click(object sender, EventArgs e)
        {
            Double number1, number2, result;
            number1 = Convert.ToDouble(firstnumBox.Text);
            number2 = Convert.ToDouble(secnumBox.Text);
            result = (number1 + number2) / 2;
            numresultLabel.Text = result.ToString();
        }

        private void clearForm(object sender, EventArgs e)
        {
            firstnumBox.Text = "";
            secnumBox.Text = "";
            numresultLabel.Text = "";
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            CloseScreen closeButton = new CloseScreen();
            closeButton.ShowDialog();
            closeButton.Close();
            Application.Exit();
        }
    }
}
