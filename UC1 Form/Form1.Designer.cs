namespace UC1_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEEOC = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmitSE = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.lstProjectBids = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstActiveProjects = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.tabBookkeeper = new System.Windows.Forms.TabPage();
            this.tabEmpSuperv = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMoveEmp = new System.Windows.Forms.Button();
            this.lstCurrentAss = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReqNum = new System.Windows.Forms.TextBox();
            this.chkNewProj = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstQual = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAssProj = new System.Windows.Forms.ComboBox();
            this.lstQualEmp = new System.Windows.Forms.ListBox();
            this.tabEmpEquip = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMoveEquip = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lstOpenEquip = new System.Windows.Forms.ListBox();
            this.lstNewEquip = new System.Windows.Forms.ListBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnMainSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabEmpSuperv.SuspendLayout();
            this.tabEmpEquip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEmployee);
            this.tabMain.Controls.Add(this.tabBookkeeper);
            this.tabMain.Controls.Add(this.tabEmpSuperv);
            this.tabMain.Controls.Add(this.tabEmpEquip);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(576, 306);
            this.tabMain.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.label14);
            this.tabEmployee.Controls.Add(this.btnEEOC);
            this.tabEmployee.Controls.Add(this.label13);
            this.tabEmployee.Controls.Add(this.btnBrowse);
            this.tabEmployee.Controls.Add(this.btnSubmitSE);
            this.tabEmployee.Controls.Add(this.txtBrowse);
            this.tabEmployee.Controls.Add(this.lstProjectBids);
            this.tabEmployee.Controls.Add(this.label6);
            this.tabEmployee.Controls.Add(this.lstActiveProjects);
            this.tabEmployee.Controls.Add(this.label5);
            this.tabEmployee.Controls.Add(this.lstReports);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(568, 277);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Standard Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(371, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "You (do not) file under EEOC";
            // 
            // btnEEOC
            // 
            this.btnEEOC.Location = new System.Drawing.Point(375, 30);
            this.btnEEOC.Margin = new System.Windows.Forms.Padding(4);
            this.btnEEOC.Name = "btnEEOC";
            this.btnEEOC.Size = new System.Drawing.Size(187, 28);
            this.btnEEOC.TabIndex = 13;
            this.btnEEOC.Text = "Fill out the EEOC Form!";
            this.btnEEOC.UseVisualStyleBackColor = true;
            this.btnEEOC.Click += new System.EventHandler(this.btnEEOC_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(477, 113);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Project Bids";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(495, 210);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 28);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnSubmitSE
            // 
            this.btnSubmitSE.Location = new System.Drawing.Point(461, 242);
            this.btnSubmitSE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitSE.Name = "btnSubmitSE";
            this.btnSubmitSE.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitSE.TabIndex = 10;
            this.btnSubmitSE.Text = "Submit";
            this.btnSubmitSE.UseVisualStyleBackColor = true;
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(292, 213);
            this.txtBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(193, 22);
            this.txtBrowse.TabIndex = 9;
            // 
            // lstProjectBids
            // 
            this.lstProjectBids.FormattingEnabled = true;
            this.lstProjectBids.ItemHeight = 16;
            this.lstProjectBids.Location = new System.Drawing.Point(292, 134);
            this.lstProjectBids.Margin = new System.Windows.Forms.Padding(4);
            this.lstProjectBids.Name = "lstProjectBids";
            this.lstProjectBids.Size = new System.Drawing.Size(268, 68);
            this.lstProjectBids.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Active Projects";
            // 
            // lstActiveProjects
            // 
            this.lstActiveProjects.FormattingEnabled = true;
            this.lstActiveProjects.ItemHeight = 16;
            this.lstActiveProjects.Location = new System.Drawing.Point(8, 30);
            this.lstActiveProjects.Margin = new System.Windows.Forms.Padding(4);
            this.lstActiveProjects.Name = "lstActiveProjects";
            this.lstActiveProjects.Size = new System.Drawing.Size(207, 116);
            this.lstActiveProjects.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Download Time Report (.pdf)";
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 16;
            this.lstReports.Location = new System.Drawing.Point(4, 196);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(237, 68);
            this.lstReports.TabIndex = 1;
            // 
            // tabBookkeeper
            // 
            this.tabBookkeeper.Location = new System.Drawing.Point(4, 25);
            this.tabBookkeeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBookkeeper.Name = "tabBookkeeper";
            this.tabBookkeeper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBookkeeper.Size = new System.Drawing.Size(568, 277);
            this.tabBookkeeper.TabIndex = 0;
            this.tabBookkeeper.Text = "Bookkeeper";
            this.tabBookkeeper.UseVisualStyleBackColor = true;
            // 
            // tabEmpSuperv
            // 
            this.tabEmpSuperv.Controls.Add(this.btnSave);
            this.tabEmpSuperv.Controls.Add(this.label12);
            this.tabEmpSuperv.Controls.Add(this.label11);
            this.tabEmpSuperv.Controls.Add(this.btnMoveEmp);
            this.tabEmpSuperv.Controls.Add(this.lstCurrentAss);
            this.tabEmpSuperv.Controls.Add(this.label10);
            this.tabEmpSuperv.Controls.Add(this.label9);
            this.tabEmpSuperv.Controls.Add(this.txtReqNum);
            this.tabEmpSuperv.Controls.Add(this.chkNewProj);
            this.tabEmpSuperv.Controls.Add(this.label8);
            this.tabEmpSuperv.Controls.Add(this.lstQual);
            this.tabEmpSuperv.Controls.Add(this.label7);
            this.tabEmpSuperv.Controls.Add(this.cmbAssProj);
            this.tabEmpSuperv.Controls.Add(this.lstQualEmp);
            this.tabEmpSuperv.Location = new System.Drawing.Point(4, 25);
            this.tabEmpSuperv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpSuperv.Name = "tabEmpSuperv";
            this.tabEmpSuperv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpSuperv.Size = new System.Drawing.Size(568, 277);
            this.tabEmpSuperv.TabIndex = 1;
            this.tabEmpSuperv.Text = "Employee Management";
            this.tabEmpSuperv.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(433, 247);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 28);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(487, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "OR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Currently Assigned";
            // 
            // btnMoveEmp
            // 
            this.btnMoveEmp.Location = new System.Drawing.Point(244, 199);
            this.btnMoveEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveEmp.Name = "btnMoveEmp";
            this.btnMoveEmp.Size = new System.Drawing.Size(75, 28);
            this.btnMoveEmp.TabIndex = 12;
            this.btnMoveEmp.Text = ">>";
            this.btnMoveEmp.UseVisualStyleBackColor = true;
            this.btnMoveEmp.Click += new System.EventHandler(this.btnMoveEmp_Click);
            // 
            // lstCurrentAss
            // 
            this.lstCurrentAss.FormattingEnabled = true;
            this.lstCurrentAss.ItemHeight = 16;
            this.lstCurrentAss.Location = new System.Drawing.Point(327, 123);
            this.lstCurrentAss.Margin = new System.Windows.Forms.Padding(4);
            this.lstCurrentAss.Name = "lstCurrentAss";
            this.lstCurrentAss.Size = new System.Drawing.Size(159, 116);
            this.lstCurrentAss.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Qualified Employees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Required Workers";
            // 
            // txtReqNum
            // 
            this.txtReqNum.Location = new System.Drawing.Point(7, 128);
            this.txtReqNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtReqNum.Name = "txtReqNum";
            this.txtReqNum.ReadOnly = true;
            this.txtReqNum.Size = new System.Drawing.Size(132, 22);
            this.txtReqNum.TabIndex = 8;
            // 
            // chkNewProj
            // 
            this.chkNewProj.AutoSize = true;
            this.chkNewProj.Location = new System.Drawing.Point(447, 73);
            this.chkNewProj.Margin = new System.Windows.Forms.Padding(4);
            this.chkNewProj.Name = "chkNewProj";
            this.chkNewProj.Size = new System.Drawing.Size(105, 21);
            this.chkNewProj.TabIndex = 7;
            this.chkNewProj.Text = "New Project";
            this.chkNewProj.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qualifications";
            // 
            // lstQual
            // 
            this.lstQual.FormattingEnabled = true;
            this.lstQual.Location = new System.Drawing.Point(4, 26);
            this.lstQual.Margin = new System.Windows.Forms.Padding(4);
            this.lstQual.Name = "lstQual";
            this.lstQual.Size = new System.Drawing.Size(228, 72);
            this.lstQual.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Existing Assigned Projects";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbAssProj
            // 
            this.cmbAssProj.FormattingEnabled = true;
            this.cmbAssProj.Location = new System.Drawing.Point(349, 23);
            this.cmbAssProj.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAssProj.Name = "cmbAssProj";
            this.cmbAssProj.Size = new System.Drawing.Size(211, 24);
            this.cmbAssProj.TabIndex = 3;
            // 
            // lstQualEmp
            // 
            this.lstQualEmp.FormattingEnabled = true;
            this.lstQualEmp.ItemHeight = 16;
            this.lstQualEmp.Items.AddRange(new object[] {
            "Matthew Camino",
            "David Fisher",
            "Evan Ligget",
            "Dan Martersteck",
            "Alexander Reynaud"});
            this.lstQualEmp.Location = new System.Drawing.Point(7, 187);
            this.lstQualEmp.Margin = new System.Windows.Forms.Padding(4);
            this.lstQualEmp.Name = "lstQualEmp";
            this.lstQualEmp.Size = new System.Drawing.Size(228, 52);
            this.lstQualEmp.TabIndex = 2;
            // 
            // tabEmpEquip
            // 
            this.tabEmpEquip.Controls.Add(this.label18);
            this.tabEmpEquip.Controls.Add(this.cmbClient);
            this.tabEmpEquip.Controls.Add(this.button1);
            this.tabEmpEquip.Controls.Add(this.label17);
            this.tabEmpEquip.Controls.Add(this.label16);
            this.tabEmpEquip.Controls.Add(this.btnMoveEquip);
            this.tabEmpEquip.Controls.Add(this.label15);
            this.tabEmpEquip.Controls.Add(this.cmbCondition);
            this.tabEmpEquip.Controls.Add(this.lstOpenEquip);
            this.tabEmpEquip.Controls.Add(this.lstNewEquip);
            this.tabEmpEquip.Location = new System.Drawing.Point(4, 25);
            this.tabEmpEquip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmpEquip.Name = "tabEmpEquip";
            this.tabEmpEquip.Size = new System.Drawing.Size(568, 277);
            this.tabEmpEquip.TabIndex = 3;
            this.tabEmpEquip.Text = "Equipment Management";
            this.tabEmpEquip.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "New Assigned Equipment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 86);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Open Equipment";
            // 
            // btnMoveEquip
            // 
            this.btnMoveEquip.Location = new System.Drawing.Point(179, 170);
            this.btnMoveEquip.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoveEquip.Name = "btnMoveEquip";
            this.btnMoveEquip.Size = new System.Drawing.Size(43, 28);
            this.btnMoveEquip.TabIndex = 4;
            this.btnMoveEquip.Text = ">>";
            this.btnMoveEquip.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Equipment Condition";
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(8, 20);
            this.cmbCondition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(160, 24);
            this.cmbCondition.TabIndex = 2;
            // 
            // lstOpenEquip
            // 
            this.lstOpenEquip.FormattingEnabled = true;
            this.lstOpenEquip.ItemHeight = 16;
            this.lstOpenEquip.Location = new System.Drawing.Point(11, 106);
            this.lstOpenEquip.Margin = new System.Windows.Forms.Padding(4);
            this.lstOpenEquip.Name = "lstOpenEquip";
            this.lstOpenEquip.Size = new System.Drawing.Size(159, 164);
            this.lstOpenEquip.TabIndex = 1;
            // 
            // lstNewEquip
            // 
            this.lstNewEquip.FormattingEnabled = true;
            this.lstNewEquip.ItemHeight = 16;
            this.lstNewEquip.Location = new System.Drawing.Point(229, 106);
            this.lstNewEquip.Margin = new System.Windows.Forms.Padding(4);
            this.lstNewEquip.Name = "lstNewEquip";
            this.lstNewEquip.Size = new System.Drawing.Size(159, 164);
            this.lstNewEquip.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(657, 75);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(137, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(657, 102);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(137, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnMainSubmit
            // 
            this.btnMainSubmit.Location = new System.Drawing.Point(720, 143);
            this.btnMainSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainSubmit.Name = "btnMainSubmit";
            this.btnMainSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnMainSubmit.TabIndex = 2;
            this.btnMainSubmit.Text = "Submit";
            this.btnMainSubmit.UseVisualStyleBackColor = true;
            this.btnMainSubmit.Click += new System.EventHandler(this.btnMainSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login to WEMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome, Alex!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(720, 171);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Make Resource Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(404, 191);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(160, 24);
            this.cmbClient.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(508, 170);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Sign for";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 306);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wilco Employee Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabEmpSuperv.ResumeLayout(false);
            this.tabEmpSuperv.PerformLayout();
            this.tabEmpEquip.ResumeLayout(false);
            this.tabEmpEquip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnMainSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabEmpSuperv;
        private System.Windows.Forms.TabPage tabBookkeeper;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabEmpEquip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstActiveProjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAssProj;
        private System.Windows.Forms.ListBox lstQualEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox lstQual;
        private System.Windows.Forms.CheckBox chkNewProj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMoveEmp;
        private System.Windows.Forms.ListBox lstCurrentAss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReqNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmitSE;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.ListBox lstProjectBids;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEEOC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnMoveEquip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ListBox lstOpenEquip;
        private System.Windows.Forms.ListBox lstNewEquip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbClient;
    }
}

