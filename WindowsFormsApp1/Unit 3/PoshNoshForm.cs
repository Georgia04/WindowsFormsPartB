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
    /// This form calculates the price of a meal
    /// after user selects the starter menu, the main menu 
    /// and the dessert.
    /// Author: Georgia
    /// </summary>
    public partial class PoshNoshForm : Form
    {
        double mainmenucost, dessertcost, startercost, totalcost;

        public PoshNoshForm()
        {
            InitializeComponent();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectDesertMenu(object sender, EventArgs e)
        {
            switch (dessertMenu.Text) 
            {
                case "Fruit Cake": dessertcost = 7.00; break;
                case "Knickerbocker Glory": dessertcost = 9.50; break;
                case "Banoffee Pie": dessertcost = 10.00; break;
                case "Figgy Pudding": dessertcost = 12.50; break;
            }
            totalcost = mainmenucost + startercost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void selectMainMenu(object sender, EventArgs e)
        {
            switch (mainMenu.Text) 
            {
                case "Chicken Lasagne": mainmenucost = 10.50; break;
                case "Fish and Chips": mainmenucost = 9.50; break;
                case "Steak and Chips": mainmenucost = 12.20; break;
                case "Vegetable Curry": mainmenucost = 8.00; break;
            }
            totalcost = mainmenucost + startercost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }

        private void selectStarterMenu(object sender, EventArgs e)
        {
            switch (starterMenu.Text) 
            {
                case "Burger": startercost = 5.50; break;
                case "Meat Balls": startercost = 6.50; break;
                case "Soup of the Day": startercost = 12.50; break;
                case "Spaghetti Bolognese": startercost = 10.50; break;
            }
            totalcost = mainmenucost + startercost + dessertcost;
            FinalCost.Text = "£ " + totalcost.ToString("0.00");
        }
    }
}
