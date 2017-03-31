using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Build 0.1, 29-03-2017

//ABOUT THE MAIN FORM
/*/ The first thing the employee will see is a form that requires them to log in.
    At tihs point, the tabs are all disabled and will remain that way until the user logs in as an authorized member
    Once the user is in, there will be some text along the bottom that says "Welcome, {user name here}!"
        For now, it just says "Welcome Alex!" as a placeholder
/*/

//ABOUT THE "STANDARD EMPLOYEE" TAB
/*/...coming soon...
/*/
namespace UC1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEEOC_Click(object sender, EventArgs e)
        {
            new EEOC_Compliance().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMainSubmit_Click(object sender, EventArgs e)
        {
            /*/ Send the information provided in the Username and Password textboxes and compare them to what is in the database
                If the username-password combination does not match what we have on file, throw an error at the user
                If the username-password combination DOES match what we have on file, pull up the first tab that the user qualifies for
                    For example: a standard employee would only be able to access the "standard employee" section
                    Meanwhile, a supervisor could access the Employee and Equipment management
                    If it turns out the user does not have permission to access a certain tab, that tab will be locked and grayed out
            /*/
        }

        private void btnMoveEmp_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Inventory_Report().Show();
        }
    }
}
