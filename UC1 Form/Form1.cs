using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_9_GUI; //takes imported code from Matt's GUI


//Build 0.3, 20-04-2017
//CNIT 280 Group 17
//Alex Reynaud, David Fisher, Evan Ligett, Matt Camino, Dan Martersteck
/*/
 * The data within this program will be strictly tied into the SQL database we have created 
 * Certain parts of our database will demand "XML files" from objects; these are simply outside files that cannot be loaded into the form--such as .docx or .xlsx files
/*/
namespace UC1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.QUALIFICATION' table. You can move, or remove it, as needed.
            this.qUALIFICATIONTableAdapter.Fill(this.database1DataSet1.QUALIFICATION);
            // TODO: This line of code loads data into the 'database1DataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.database1DataSet1.EMPLOYEE);
            // TODO: This line of code loads data into the 'database1DataSet1.EMPLOYEE_CONTRACT' table. You can move, or remove it, as needed.
            this.eMPLOYEE_CONTRACTTableAdapter.Fill(this.database1DataSet1.EMPLOYEE_CONTRACT);
            InitializeComponent();
        }

        private void displayMessage(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void displayError(string err)
        {
            MessageBox.Show(err, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validateInput()
        {
            //makes sure all the values are filled
            return false;
        }


        //ABOUT THE MAIN FORM
        /*/ The first thing the employee will see is a form that requires them to log in.
            At this point, the tabs are all disabled and will remain that way until the user logs in as an authorized member
            Once the user is in, there will be some text along the bottom that says "Welcome, {user name here}!"
                NOTE: For now, it just says "Welcome Alex!" as a placeholder
        /*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (txtUsername.Text.ToUpper().Equals("OWNER") && txtPassword.Text.ToUpper().Equals("OWNER"))
            /*/ The txtUsername and txtPassword requirements could be changed later on, according to the pseudo-database we set up for our users.
            Such a database could probably set up in Microsoft Access or Notepad
            /*/
            {
                //enable the appropriate tabs, according to the user's credentials
                //also change the label's text (on the bottom) so that it displays the user's name
            }
            else
            {
                MessageBox.Show("Username or password was incorrect", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /*/ Send the information provided in the Username and Password textboxes and compare them to what is in the database
                If the username-password combination does not match what we have on file, throw an error at the user
                If the username-password combination DOES match what we have on file, pull up the first tab that the user qualifies for
                    For example: a standard employee would only be able to access the "standard employee" section
                    Meanwhile, a supervisor could access the Employee and Equipment management
                    If it turns out the user does not have permission to access a certain tab, that tab will be locked and grayed out
            /*/



            if (txtUsername.Text.ToUpper().Equals("OWNER") && txtPassword.Text.ToUpper().Equals("OWNER")) //username and password should tie back to an array that works with the SQL database
            /*/ The txtUsername and txtPassword requirements could be changed later on, according to the pseudo-database we set up for our users.
            Such a database could probably set up in Microsoft Access or Notepad
            /*/
            {
                tabMain.Enabled = true;
                //enable the tabs relating to this user's account; the tabs will be disabled in the final build
            }
            else
            {
                displayError("Your username and/or password was incorrect");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //ABOUT THE "STANDARD EMPLOYEE" TAB
        /*/ This tab will be available to:
                • Regular employees
                • Supervisors
            
            From this area, regular employees can see
                • Which projects they are currently working on
                • Previously-submitted project bids
                • A list of the user's time cards
            Project bids can be added to the listBox by clicking the Browse button and submitting an .xlsx file (or some kind of spreadsheet)
                NOTE: employees can open and edit these spreadsheets as needed, and a copy of these spreadsheets are sent to Wilco's database once saved
                There needs to be a way to save the data from the excel sheet, then to the form, and then to the database
        /*/

        private void btnEEOC_Click(object sender, EventArgs e)
        {
            new EEOC_Compliance().Show();
            //this button will ONLY be enabled if the boolean value that determines the employee's EEOC status is set to TRUE
        }

        private const int cSize = 40;
        private int mIndex;
        private string[] mFile = new string[cSize];
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //opens a prompt for the user to upload a spreadsheet
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Spreadsheet Files|*.xlsx";
            ofd.Title = "Select a spreadsheet";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBrowse.Text = ofd.FileName;
            }
            //sends the file name to the 
            mFile[mIndex] = txtBrowse.Text;
        }

        private void btnSubmitSE_Click(object sender, EventArgs e)
        {
            //submits the project bid to the database
            /*/ Assuming the state has previously accepted such a bid, the system will bring up a spreadsheet
                This spreadsheet lists the due dates and requirements of various project milestones
            /*/
        }

        private void lstActiveProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            //populates with the employee's current projects once they log in
        }

        private void lstReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*/ This area will be populated with links to PDF time reports once the employee logs in
                The most recent time report will be shown at the top of the list
                Downloading a PDF is as simple as double-clicking one of the listed items
            /*/
        }

        //ABOUT THE "BOOKKEEPER" TAB
        /*/...coming soon...
        /*/

        //ABOUT THE "EMPLOYEE MANAGEMENT" TAB
        /*/ This tab will be available to:
                • Supervisors
                • Managers

            When it comes to the employee management, supervisors and managers need all the assistance they can get
            The higher-ups within Wilco need a way to get the right employees in the right places
            This tab lists the required number of employees for an existing project
                NOTE: Checking the "New Project" box will gray out everything EXCEPT for btnSubChange
                When the user clicks btnSubChange while the New Project box is checked, a form will show up to submit a project bid--similar to what the Standard Employee can submit
        /*/
        private void btnMoveEmp_Click(object sender, EventArgs e)
        {
            /*/ Requires at least one of the "Qualified Employees" to be selected
                The employees selected in "Qualified Employees" will be moved to "Currently Assigned" when the button is clicked
            /*/
        }

        private void lstQualEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubChange_Click(object sender, EventArgs e)
        {
            //takes the employees listed in lstCurrentAss and updates the database with the values
        }

        private void chkNewProj_CheckedChanged(object sender, EventArgs e)
        {
            //Generate the "New Project" form when this is checked and the "save changes" button is clicked
            //The "Existing Assign Projects" combobox will be disabled if this is checked
        }

        private void cmbAssProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Will populate with the user's assigned projects once they're logged in
        }

        private void lstCurrentAss_SelectedIndexChanged(object sender, EventArgs e)
        {
            //we could potentially allow items in this listBox to be double-clicked and opened to reveal an employee profile
        }

        //ABOUT THE "EQUIPMENT MANAGEMENT" TAB
        /*/ This tab will be available to
                • Supervisors
                • Managers
            
            Users from customers to engineers will request equipment for multiple reasons--usually based on the equipment's condition
                For example: most clients that need special equipment will be assigned "Good" or "New" equipment,
                but organizations that wish to fix certain equipment can receive equipment of any type EXCEPT for "New"
                The system will refuse the user to give anyone (other than an equipment manufacturer/engineer) permission to send equipment with a lesser grade than "good" to regular customers
            Not all equipment is strictly tools such as computers, screwdrivers, or raw materials; Wilco also sends vehicles to organizations that need them,
            hence the radio buttons that let the user specify whether the equipment that's about to be checked out is actually a vehicle or not.
        /*/
        private void btnReport_Click(object sender, EventArgs e)
        {
            //Assuming the form has been updated with new values, the inventory report information will be updated before the report form pops up
            new Inventory_Report().Show();
        }

        private void btnMoveEquip_Click(object sender, EventArgs e)
        {
            /*/ Requires at least one of the "Qualified Employees" to be selected
                The employees selected in "Qualified Employees" will be moved to "Currently Assigned" when the button is clicked
            /*/
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this will hold a list of all the clients that are looking for and/or holding equipment
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            new VerifyPayment().Show();
        }
    }
}
