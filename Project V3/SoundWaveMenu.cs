using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_V3
{
    public partial class SoundWaveMenu : Form
    {
        public SoundWaveMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            // Sets the Parent form of the Child window.
            newMDIChild.MdiParent = this;
            // Displays the new form
            newMDIChild.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openWavFile.ShowDialog(); // I want to open this to the child window in the file
            if (result == DialogResult.OK) // checks if the result returned true
            {

                Form openForm = this.ActiveMdiChild;
                if (openForm != null)
                {
                    if (openForm.GetType() == typeof(Form1))
                    {
                        Form1 openToChild = (Form1)this.ActiveMdiChild;
                        openToChild.OpenFile(openWavFile.FileName);
                        return;
                    }
                }

                // if there is no child window of InputForm, open a new one
                Form1 childWnd = new Form1();
                childWnd.OpenFile(openWavFile.FileName); // opens the file of the specified type in the child window
                childWnd.MdiParent = this;
                childWnd.Show(); // enter the child window
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveWavFile.ShowDialog();
            if (result == DialogResult.OK && this.ActiveMdiChild == null)
            {
                return;
            }
            else if (result == DialogResult.OK)
            {
                if (this.ActiveMdiChild.GetType() == typeof(Form1))
                {
                    Form1 inputForm = (Form1)this.ActiveMdiChild;
                    inputForm.SaveFile(saveWavFile.FileName);
                    return;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild == null) { return; } // if no child, break
            if (activeChild.GetType() == typeof(Form1))
            {
                Form1 chartInput = (Form1)activeChild; // become an InputForm
                double[] array = chartInput.FreqWaveChart_Copy();
                Clipboard.SetDataObject(array);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild == null) { return; } // if no child, break
            if (activeChild.GetType() == typeof(Form1))
            {
                Form1 chartInput = (Form1)activeChild; // become an InputForm
                chartInput.FreqWaveChart_Paste(Clipboard.GetDataObject());
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild == null) { return; } // if no child, break
            if (activeChild.GetType() == typeof(Form1))
            {
                Form1 chartInput = (Form1)activeChild; // become an InputForm
                double[] array = chartInput.FreqWaveChart_Cut();
                Clipboard.SetDataObject(array);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild == null) { return; } // if no child, break
            if (activeChild.GetType() == typeof(Form1))
            {
                Form1 chartDel = (Form1)activeChild; // become an InputForm
                chartDel.FreqWaveChart_Del();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verticalWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void horizontalWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Asks the user if they really want to quit the application
            if (MessageBox.Show("Did you save your work?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void openHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Enabled = true;
            help.ShowDialog();
        }
    }
}
