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
    /// This form terminates the calculator form
    /// Author: Georgia
    /// </summary>
    public partial class CloseScreen : Form
    {
        public CloseScreen()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
