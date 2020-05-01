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
    public partial class TotalsForm : Form
    {
        public TotalsForm()
        {
            InitializeComponent();
        }

        public TotalsForm(int totalnum, int oxfordnum, int cambridgenum, int leedsnum, decimal totalbill, decimal oxfordnumbill, decimal cambridgenumbill, decimal leedsnumbill)
        {
            
        }

        private void selectBack(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
