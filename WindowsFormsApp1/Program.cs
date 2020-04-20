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

            Application.Run(new GameUI());
            //Application.Run(new WelcomeForm());
            //Application.Run(new DataEntryForm());
            //Application.Run(new CalculatorForm());
            //Application.Run(new splashscreenForm());
            
        }
    }
}
