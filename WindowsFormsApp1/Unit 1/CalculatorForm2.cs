﻿using System;
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
    public partial class CalculatorForm2 : Form
    {
        public CalculatorForm2()
        {
        InitializeComponent();
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

        private void clearNumbers_Click(object sender, EventArgs e)
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
