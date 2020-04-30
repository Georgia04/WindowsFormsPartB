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
    /// This class displays the final price
    /// of a pizza included toppings inside it.
    /// Author: Georgia
    /// </summary>
    public partial class PizzaShopForm : Form
    {
       double pizzaCost, toppingCost, endCost;

        public PizzaShopForm()
        {
            InitializeComponent();
        }

        private void calculateLarge(object sender, EventArgs e)
        {
            if (largeRadio.Checked)
            {
                pizzaCost = 10;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text= "£ " + endCost.ToString("0.00");

        }

        private void calaculateMedium(object sender, EventArgs e)
        {
            if (mediumRadio.Checked)
            {
                pizzaCost = 8;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");

        }

        private void calculateSmall(object sender, EventArgs e)
        {
            if (smallRadio.Checked)
            {
                pizzaCost = 5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");

        }

        private void calculatePineapple(object sender, EventArgs e)
        {
            if (pineapple.Checked)
            {
                toppingCost = toppingCost + 2.5;
            }
            else
            {
                toppingCost = toppingCost - 2.5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void calculateRhubarb(object sender, EventArgs e)
        {
            if (rhubarb.Checked)
            {
                toppingCost = toppingCost + 2.5;
            }
            else
            {
                toppingCost = toppingCost - 2.5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void calculatePepperoniVindaloo(object sender, EventArgs e)
        {
            if (pepperoniVindaloo.Checked)
            {
                toppingCost = toppingCost + 2.5;
            }
            else
            {
                toppingCost = toppingCost - 2.5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void calculateChocolate(object sender, EventArgs e)
        {
            if (chocolate.Checked)
            {
                toppingCost = toppingCost + 2.5;
            }
            else
            {
                toppingCost = toppingCost - 2.5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void calculateBBQ(object sender, EventArgs e)
        {
            if (bbq.Checked)
            {
                toppingCost = toppingCost + 2.5;
            }
            else
            {
                toppingCost = toppingCost - 2.5;
            }
            endCost = pizzaCost + toppingCost;
            finalPrice.Text = "£ " + endCost.ToString("0.00");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
