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
    /// This form uses a text box to provide the main functions
    /// of a pad
    /// author: Georgia
    /// </summary>
    public partial class MyPadForm : Form
    {
        public MyPadForm()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMain.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMain.Undo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.ShowDialog();
            textMain.SaveFile(sfd.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textMain.LoadFile(ofd.FileName);
        }

        private void chooseFontTool(object sender, EventArgs e)
        {
            fd.ShowDialog();
            textMain.Font = fd.Font;
        }

        private void chooseForeColor(object sender, EventArgs e)
        {
            cd.ShowDialog();
            textMain.ForeColor = cd.Color;
        }

        private void chooseBckColor(object sender, EventArgs e)
        {
            cd.ShowDialog();
            textMain.BackColor = cd.Color;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           Font f = new Font(textMain.Font.Name, 20, FontStyle.Regular);
            textMain.SelectionFont = f;
        }
    }
}
