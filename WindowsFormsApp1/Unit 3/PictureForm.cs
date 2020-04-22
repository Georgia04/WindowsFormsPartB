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
    /// This form shows pictures of some monsters
    /// when user choose a monster.
    /// Author: Georgia
    /// </summary>
    
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();
        }

        private void comboChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboChoice.Text == "Alien")
            {
                pictureChoice.Image = Image.FromFile("alien.gif");
            }
            else if (comboChoice.Text == "Dragon")
            {
                pictureChoice.Image = Image.FromFile("Dragon.gif");
            }
            else if (comboChoice.Text == "Hydra")
            {
                pictureChoice.Image = Image.FromFile("Hydra.gif");
            }
            else if (comboChoice.Text == "RedHarpy")
            {
                pictureChoice.Image = Image.FromFile("RedHarpy.gif");
            }
            else if (comboChoice.Text == "Scorpius")
            {
                pictureChoice.Image = Image.FromFile("scorpius.jpg");
            }
            else if (comboChoice.Text == "Shadow")
            {
                pictureChoice.Image = Image.FromFile("Shadow.jpg");
            }
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
