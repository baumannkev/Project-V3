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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.Enabled = false;
            helpTextBox.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            helpTextBox.SelectedText = ("Sound Wave Project Controls:\n");
            helpTextBox.SelectedText = ("Control                    Key:\n");
            helpTextBox.SelectionFont = new Font("Times New Roman", 9, FontStyle.Underline);
            helpTextBox.SelectedText = ("Time Domain:\n");
            helpTextBox.SelectedText = ("Scroll                      Mouse wheel\n");
            helpTextBox.SelectedText = ("Cut                         Ctrl + x\n");
            helpTextBox.SelectedText = ("Copy                       Ctrl + c\n");
            helpTextBox.SelectedText = ("Paste                      Ctrl + v\n");
            helpTextBox.SelectionFont = new Font("Times New Roman", 9, FontStyle.Underline);
            helpTextBox.SelectedText = ("File:\n");
            helpTextBox.SelectedText = ("Open File                 Ctrl + o\n");
            helpTextBox.SelectedText = ("New File                  Ctrl + n\n");
            helpTextBox.SelectedText = ("Save                       Ctrl + s\n");
            helpTextBox.SelectedText = ("Close                       Ctrl + shift + c\n");

            helpTextBox.SelectionFont = new Font("Times New Roman", 9, FontStyle.Underline);
            helpTextBox.SelectedText = ("\nHow to Use this program\n");

            helpTextBox.SelectedText = ("Step 1: Open a Wave File, under \"File\" menu strip. OR you may choose to record a sample.\n");
            helpTextBox.SelectedText = ("Step 2: The program then visually plots the sound as a wave.\n");
            helpTextBox.SelectedText = ("Step 3: You may then copy/cut/paste portion of the wave to different sections of the same wave or a different wave file.\n");
            helpTextBox.SelectedText = ("Step 4: There are multiples of wave mix functionalities in \"Data\" and \"Edit Wave\".\n");
            helpTextBox.SelectedText = ("Step 5: All mixed and recorded waves could be saved to your local device.\n");
        }
    }
}
