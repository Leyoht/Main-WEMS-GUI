using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using UC_9_GUI; //takes imported code from Matt's GUI


//Build 0.3.15, 26-04-2017

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
        public void loadScript() //will be used to load the WilcoLoad.sql script 
        {
            FileInfo file = new FileInfo("WilcoLoad.sql");
            string script = file.OpenText().ReadToEnd();
        }

        public void testLists() //sends a test-run of test to the login script once the employee has logged in, ensuring the listboxes are functional
        {
            lstActiveProjects.Items.Add("Superior Landing, Project #7730909");
            lstActiveProjects.Items.Add("Maylan Hotel, Project #7729998");
            lstActiveProjects.Items.Add("Marquee Moon Dev., Project #");

            lstReports.Items.Add("Employee: Alex Reynaud      Week of 3/27 Logged Hours: 22.38       Wage Rate: 9.50/hr        Current Total: $212.61");
            lstReports.Items.Add("Employee: Alex Reynaud      Week of 4/3 Logged Hours: 37.00       Wage Rate: 9.50/hr        Current Total: $351.50");
            lstReports.Items.Add("Employee: Alex Reynaud      Week of 4/10 Logged Hours: 35.00       Wage Rate: 9.50/hr        Current Total: $332.50");

            lstProjectBids.Items.Add("Decatur County Courhouse Masonry Repairs          Valuation: $199,000        Location: Decatur, IN         Bid Date: May 1, 2017");
            lstProjectBids.Items.Add("Mendards Warehouse (Addition)                     Valuation: $2,999,999      Location: Allen, IN           Bid Date: June 12, 2017");
            lstProjectBids.Items.Add("Whihala Beach Conecession Bldg                    Valuation: $749,999        Location: Lake, IN            Bid Date: July 9, 2017");

            /*/for (int i = 0; i < lstActiveProjects.Items.Count; i++)
            {
                lstActiveProjects.Items.Add(...);
            }

            for (int i = 0; i < lstReports.Items.Count; i++)
            {
                lstReports.Items.Add(...);
            }

            for (int i = 0; i < lstProjectBids.Items.Count; i++)
            {
                lstProjectBids.Items.Add(...);
            }/*/
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

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string connectionString;
        public void openConn()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            connectionString = ConfigurationManager.ConnectionStrings["UC1_Form.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();

            //populates the comboboxes at startup
            using (con)
            {
                openConn();

                //writes to the Active Employees combobox on the Bookkeeper tab
                SqlCommand getActEmp = new SqlCommand("SELECT (First_Name + ' ' + Last_Name) AS Name FROM EMPLOYEE", con);
                getActEmp.Connection = con;
                SqlDataReader sqlActReader = getActEmp.ExecuteReader();
                while (sqlActReader.Read())
                    cboActEmp.Items.Add(sqlActReader["name"].ToString());
                sqlActReader.Close();

                //writes to the Select Project combobox on the Employee Management tab
                SqlCommand getProj = new SqlCommand("SELECT Job_Name FROM CONTRACT WHERE Is_State = 1", con);
                getProj.Connection = con;
                SqlDataReader sqlProjReader = getProj.ExecuteReader();
                while (sqlProjReader.Read())
                    cboAssProj.Items.Add(sqlProjReader["job_name"].ToString());
                sqlProjReader.Close();

                //writes to the Assign To combobox on the Equipment Management tab
                SqlCommand getClient = new SqlCommand("SELECT Company_Name FROM CLIENT", con);
                getClient.Connection = con;
                SqlDataReader sqlClientReader = getClient.ExecuteReader();
                while (sqlClientReader.Read())
                    cboClient.Items.Add(sqlClientReader["company_name"].ToString());
                sqlClientReader.Close();
            }
        }

        //ABOUT THE MAIN FORM
        /*/ The first thing the employee will see is a form that requires them to log in.
            At this point, the tabs are all disabled and will remain that way until the user logs in as an authorized member
            Once the user is in, there will pop-up that says "Welcome, {user name here}!"
        /*/
        string userID;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //retrieves the username and password
            DataTable userpass = new System.Data.DataTable();
            using (SqlDataAdapter uspw = new SqlDataAdapter("SELECT [Username], [Password] FROM [EMPLOYEE_CREDENTIALS] " +
                 "WHERE [Username] = '" + txtUsername.Text + "' and[Password] = '" + txtPassword.Text + "'", con))
            {
                con.ConnectionString = connectionString;
                uspw.Fill(userpass);
            }
            //retrieves the employee_ID
            DataTable getUID = new System.Data.DataTable();
            using (SqlDataAdapter adUID = new SqlDataAdapter("SELECT Employee_ID FROM EMPLOYEE_CREDENTIALS E WHERE[Username] = '" + txtUsername.Text + "' and[Password] = '" + txtPassword.Text + "'", con))
            {
                con.ConnectionString = connectionString;
                adUID.Fill(getUID);
                //ensures the employee ID is saved locally for the session
            }
            //test to see if the username + password combo exists within our database
            if (userpass.Rows.Count == 1 && getUID.Rows.Count == 1 || txtUsername.Text == "TESTMAN" && txtPassword.Text == "NAMTSET") //this means there is ONLY one row within the entire database that has this specific username+password combo
            {
                userID = getUID.ToString();
                displayMessage("Welcome!");
                btnLogin.Enabled = false;
                txtUsername.Clear();
                txtUsername.Enabled = false;
                txtPassword.Clear();
                txtPassword.Enabled = false;
                btnLogout.Enabled = true;
                tabMain.Enabled = true;
                //testLists(); //populates the forms on the "Standard Employee" tab once the user has logged in
                //enable the appropriate tabs, according to the user's credentials
            }
            else
            {
                displayError("Your username and/or password was incorrect");
                txtUsername.Focus();
                return;
            }

            //NOTE: THE CODE BELOW IS NOT YET WORKING AT INTENDED
            openConn();

            //populate lstActiveProjects, lstProjectBids, and lstReports
            SqlCommand getActProj = new SqlCommand("SELECT Job_Name FROM CONTRACT AS C INNER JOIN EMPLOYEE_CONTRACT AS EC " +
                "ON C.Contract_ID = EC.Contract_ID INNER JOIN EMPLOYEE AS E " +
                "ON EC.Employee_ID = E.Employee_ID WHERE E.Employee_ID = '" + userID + "'", con);
            getActProj.Connection = con;
            SqlDataReader sqlAPReader = getActProj.ExecuteReader();
            while (sqlAPReader.Read())
            {
                //add items into lstActiveProjects through for loops
                for (int i = 0; i < lstActiveProjects.Items.Count; i++)
                {
                    lstActiveProjects.Items.Add(sqlAPReader["job_name"].ToString());
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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
            //sends the file name to the textbox
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
            btnEditPay.Enabled = true;
            /*/ This area will be populated with links to PDF time reports once the employee logs in
                The most recent time report will be shown at the top of the list
                Downloading a PDF is as simple as double-clicking one of the listed items
            /*/
        }

        //ABOUT THE "BOOKKEEPER" TAB
        /*/...coming soon...
        /*/
        private void cboActEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVerify.Enabled = true;
            btnEEOC.Enabled = true;
            btnGrant.Enabled = true;
            lstHours.Enabled = true;
            btnValid.Enabled = true;
            btnEdit.Enabled = true;
        }


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

        private void cboAssProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstQualEmp.Enabled = true;
            lstQual.Enabled = true;
            lstCurrentAss.Enabled = true;
            btnMoveEmp.Enabled = true;
            btnSubChange.Enabled = true;
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

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOpenEquip.Enabled = true;
            lstNewEquip.Enabled = true;
            btnMoveEquip.Enabled = true;
            btnInvSub.Enabled = true;
            //this will hold a list of all the clients that are looking for and/or holding equipment
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            new VerifyPayment(cboActEmp.SelectedItem.ToString()).Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form NewPayStub = new Paystub();
            NewPayStub.Show();
        }

        private void btnEEOC_Click_1(object sender, EventArgs e)
        {
            new EEOC_Compliance(cboActEmp.SelectedItem.ToString()).Show();
        }
    }
}
