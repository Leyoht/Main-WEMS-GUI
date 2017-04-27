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
        string name;

        public EEOC_Compliance(string Iname)
        {
            InitializeComponent();
            name = Iname;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! Please pick up your printed report.", Text, MessageBoxButtons.OKCancel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EEOC_Compliance_Load(object sender, EventArgs e)
        {
            int space = name.IndexOf(" ");
            txtFirstName.Text = name.Substring(0, space);
            int spacee = space++;
            txtLastName.Text = name.Substring(spacee);
        }
    }
}
