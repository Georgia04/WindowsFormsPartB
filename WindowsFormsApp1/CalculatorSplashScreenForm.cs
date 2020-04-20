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
    /// This image introduces the application
    /// author:Georgia
    /// </summary>
    public partial class splashscreenForm : Form
    {
        public splashscreenForm()
        {
            InitializeComponent();
        }

        private void clickCalculator_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splashscreenForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
