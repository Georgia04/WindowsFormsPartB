using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// author: Georgia
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           //Application.Run(new GameUI());
            //Application.Run(new WelcomeForm());
            //Application.Run(new DataEntryForm());
            //Application.Run(new CalculatorForm());
            //Application.Run(new splashscreenForm());
            //Application.Run(new CurrencyconverterForm());
            //Application.Run(new PizzaShopForm());
            //Application.Run(new PoshNoshForm());
            //Application.Run(new MonkeyBashForm());
            //Application.Run(new MyPadForm());
            //Application.Run(new TargetForm());
            //Application.Run(new PictureForm());
            //Application.Run(new TipsterForm());
            //Application.Run(new ResultsForm());
            Application.Run(new DataEntryForm2());
            Application.Run(new CheckBillForm());
            Application.Run(new TotalsForm());
        }
    }
}

