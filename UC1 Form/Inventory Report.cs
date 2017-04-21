using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC1_Form
{
    public partial class Inventory_Report : Form
    {
        public Inventory_Report()
        {
            InitializeComponent();
        }
        private void displayMessageYesNo(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvSub_Click(object sender, EventArgs e)
        {
            displayMessageYesNo("Would you like to save this document before you print?");
            //if yes, the user will save the document somewhere in the hard drive
            //if no, the user wlil NOT save the document, but the document will still print
            //if cancel, the document is NOT saved and will NOT print
        }
    }
}
