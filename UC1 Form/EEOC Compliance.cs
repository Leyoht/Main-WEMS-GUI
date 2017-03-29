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
    public partial class EEOC_Compliance : Form
    {
        public EEOC_Compliance()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Please pick up your printed report.", Text, MessageBoxButtons.OKCancel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
