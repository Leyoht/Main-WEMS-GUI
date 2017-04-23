using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_9_GUI
{
    public partial class VerifyPayment : Form
    {
        public VerifyPayment()
        {
            InitializeComponent();
        }

        private void txtMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //make an "are you sure?" dialog appear first
            DialogResult result = MessageBox.Show("Are you sure you're ready to submit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                MessageBox.Show("Payment Data Verified", "Payment Data Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                return;
        }

        private void VerifyPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
