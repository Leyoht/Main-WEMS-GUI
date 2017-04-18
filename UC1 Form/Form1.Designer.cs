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
            this.btnEditPay = new System.Windows.Forms.Button();
            this.btnSubPay = new System.Windows.Forms.Button();
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
            this.btnEEOC = new System.Windows.Forms.Button();
            this.btnGrant = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lstHours = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lstActEmp = new System.Windows.Forms.ListBox();
            this.tabEmpSuperv = new System.Windows.Forms.TabPage();
            this.btnSubChange = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVNo = new System.Windows.Forms.RadioButton();
            this.radVYes = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMoveEquip = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lstOpenEquip = new System.Windows.Forms.ListBox();
            this.lstNewEquip = new System.Windows.Forms.ListBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
=======
>>>>>>> refs/remotes/origin/tracking-objects
            this.tabMain.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabBookkeeper.SuspendLayout();
            this.tabEmpSuperv.SuspendLayout();
            this.tabEmpEquip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEmployee);
            this.tabMain.Controls.Add(this.tabBookkeeper);
            this.tabMain.Controls.Add(this.tabEmpSuperv);
            this.tabMain.Controls.Add(this.tabEmpEquip);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(432, 249);
            this.tabMain.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnEditPay);
            this.tabEmployee.Controls.Add(this.btnSubPay);
            this.tabEmployee.Controls.Add(this.label13);
            this.tabEmployee.Controls.Add(this.btnBrowse);
            this.tabEmployee.Controls.Add(this.btnSubmitSE);
            this.tabEmployee.Controls.Add(this.txtBrowse);
            this.tabEmployee.Controls.Add(this.lstProjectBids);
            this.tabEmployee.Controls.Add(this.label6);
            this.tabEmployee.Controls.Add(this.lstActiveProjects);
            this.tabEmployee.Controls.Add(this.label5);
            this.tabEmployee.Controls.Add(this.lstReports);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(424, 223);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Standard Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEditPay
            // 
            this.btnEditPay.Enabled = false;
            this.btnEditPay.Location = new System.Drawing.Point(151, 172);
            this.btnEditPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPay.Name = "btnEditPay";
            this.btnEditPay.Size = new System.Drawing.Size(74, 23);
            this.btnEditPay.TabIndex = 16;
            this.btnEditPay.Text = "Edit Paystub";
            this.btnEditPay.UseVisualStyleBackColor = true;
            // 
            // btnSubPay
            // 
            this.btnSubPay.Enabled = false;
            this.btnSubPay.Location = new System.Drawing.Point(151, 200);
            this.btnSubPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubPay.Name = "btnSubPay";
            this.btnSubPay.Size = new System.Drawing.Size(86, 23);
            this.btnSubPay.TabIndex = 15;
            this.btnSubPay.Text = "Submit Paystub";
            this.btnSubPay.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Uploaded Project Bids (.xlsx)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(373, 172);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(50, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmitSE
            // 
            this.btnSubmitSE.Location = new System.Drawing.Point(347, 200);
            this.btnSubmitSE.Name = "btnSubmitSE";
            this.btnSubmitSE.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSE.TabIndex = 10;
            this.btnSubmitSE.Text = "Submit";
            this.btnSubmitSE.UseVisualStyleBackColor = true;
            this.btnSubmitSE.Click += new System.EventHandler(this.btnSubmitSE_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(250, 175);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(117, 20);
            this.txtBrowse.TabIndex = 9;
            // 
            // lstProjectBids
            // 
            this.lstProjectBids.FormattingEnabled = true;
            this.lstProjectBids.Location = new System.Drawing.Point(220, 73);
            this.lstProjectBids.Name = "lstProjectBids";
            this.lstProjectBids.Size = new System.Drawing.Size(202, 82);
            this.lstProjectBids.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Active Projects";
            // 
            // lstActiveProjects
            // 
            this.lstActiveProjects.FormattingEnabled = true;
            this.lstActiveProjects.Location = new System.Drawing.Point(6, 24);
            this.lstActiveProjects.Name = "lstActiveProjects";
            this.lstActiveProjects.Size = new System.Drawing.Size(156, 95);
            this.lstActiveProjects.TabIndex = 6;
            this.lstActiveProjects.SelectedIndexChanged += new System.EventHandler(this.lstActiveProjects_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Download Time Report (.pdf)";
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.Location = new System.Drawing.Point(3, 154);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(144, 69);
            this.lstReports.TabIndex = 1;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);
            // 
            // tabBookkeeper
            // 
            this.tabBookkeeper.Controls.Add(this.btnEEOC);
            this.tabBookkeeper.Controls.Add(this.btnGrant);
            this.tabBookkeeper.Controls.Add(this.btnEdit);
            this.tabBookkeeper.Controls.Add(this.btnValid);
            this.tabBookkeeper.Controls.Add(this.label26);
            this.tabBookkeeper.Controls.Add(this.textBox1);
            this.tabBookkeeper.Controls.Add(this.label25);
            this.tabBookkeeper.Controls.Add(this.label24);
            this.tabBookkeeper.Controls.Add(this.label23);
            this.tabBookkeeper.Controls.Add(this.label22);
            this.tabBookkeeper.Controls.Add(this.lstHours);
            this.tabBookkeeper.Controls.Add(this.label21);
            this.tabBookkeeper.Controls.Add(this.label20);
            this.tabBookkeeper.Controls.Add(this.label19);
            this.tabBookkeeper.Controls.Add(this.lstActEmp);
            this.tabBookkeeper.Location = new System.Drawing.Point(4, 22);
            this.tabBookkeeper.Margin = new System.Windows.Forms.Padding(2);
            this.tabBookkeeper.Name = "tabBookkeeper";
            this.tabBookkeeper.Padding = new System.Windows.Forms.Padding(2);
            this.tabBookkeeper.Size = new System.Drawing.Size(424, 223);
            this.tabBookkeeper.TabIndex = 0;
            this.tabBookkeeper.Text = "Bookkeeper";
            this.tabBookkeeper.UseVisualStyleBackColor = true;
            // 
            // btnEEOC
            // 
            this.btnEEOC.Enabled = false;
            this.btnEEOC.Location = new System.Drawing.Point(188, 71);
            this.btnEEOC.Name = "btnEEOC";
            this.btnEEOC.Size = new System.Drawing.Size(140, 23);
            this.btnEEOC.TabIndex = 14;
            this.btnEEOC.Text = "Fill Employee EEOC Form";
            this.btnEEOC.UseVisualStyleBackColor = true;
            // 
            // btnGrant
            // 
            this.btnGrant.Location = new System.Drawing.Point(207, 99);
            this.btnGrant.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(122, 23);
            this.btnGrant.TabIndex = 13;
            this.btnGrant.Text = "Grant Employee Edit";
            this.btnGrant.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(365, 202);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 19);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(365, 178);
            this.btnValid.Margin = new System.Windows.Forms.Padding(2);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(56, 19);
            this.btnValid.TabIndex = 11;
            this.btnValid.Text = "Validate";
            this.btnValid.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(304, 202);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Pay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(218, 202);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Hours Worked";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 202);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Day";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(49, 202);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Clock In";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(128, 202);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Clock Out";
            // 
            // lstHours
            // 
            this.lstHours.FormattingEnabled = true;
            this.lstHours.Location = new System.Drawing.Point(4, 127);
            this.lstHours.Margin = new System.Windows.Forms.Padding(2);
            this.lstHours.Name = "lstHours";
            this.lstHours.Size = new System.Drawing.Size(325, 69);
            this.lstHours.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(343, 110);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Pay Rate ($/hr)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 110);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Logged Hours";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Active Employees";
            // 
            // lstActEmp
            // 
            this.lstActEmp.FormattingEnabled = true;
            this.lstActEmp.Location = new System.Drawing.Point(4, 27);
            this.lstActEmp.Margin = new System.Windows.Forms.Padding(2);
            this.lstActEmp.Name = "lstActEmp";
            this.lstActEmp.Size = new System.Drawing.Size(133, 69);
            this.lstActEmp.TabIndex = 0;
            // 
            // tabEmpSuperv
            // 
            this.tabEmpSuperv.Controls.Add(this.btnSubChange);
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
            this.tabEmpSuperv.Location = new System.Drawing.Point(4, 22);
            this.tabEmpSuperv.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmpSuperv.Name = "tabEmpSuperv";
            this.tabEmpSuperv.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmpSuperv.Size = new System.Drawing.Size(424, 223);
            this.tabEmpSuperv.TabIndex = 1;
            this.tabEmpSuperv.Text = "Employee Management";
            this.tabEmpSuperv.UseVisualStyleBackColor = true;
            // 
            // btnSubChange
            // 
            this.btnSubChange.Location = new System.Drawing.Point(325, 197);
            this.btnSubChange.Name = "btnSubChange";
            this.btnSubChange.Size = new System.Drawing.Size(94, 23);
            this.btnSubChange.TabIndex = 15;
            this.btnSubChange.Text = "Submit Changes";
            this.btnSubChange.UseVisualStyleBackColor = true;
            this.btnSubChange.Click += new System.EventHandler(this.btnSubChange_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "OR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Currently Assigned";
            // 
            // btnMoveEmp
            // 
            this.btnMoveEmp.Location = new System.Drawing.Point(178, 134);
            this.btnMoveEmp.Name = "btnMoveEmp";
            this.btnMoveEmp.Size = new System.Drawing.Size(56, 23);
            this.btnMoveEmp.TabIndex = 12;
            this.btnMoveEmp.Text = ">>";
            this.btnMoveEmp.UseVisualStyleBackColor = true;
            this.btnMoveEmp.Click += new System.EventHandler(this.btnMoveEmp_Click);
            // 
            // lstCurrentAss
            // 
            this.lstCurrentAss.FormattingEnabled = true;
            this.lstCurrentAss.Location = new System.Drawing.Point(240, 125);
            this.lstCurrentAss.Name = "lstCurrentAss";
            this.lstCurrentAss.Size = new System.Drawing.Size(172, 56);
            this.lstCurrentAss.TabIndex = 11;
            this.lstCurrentAss.SelectedIndexChanged += new System.EventHandler(this.lstCurrentAss_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Qualified Employees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Required Workers";
            // 
            // txtReqNum
            // 
            this.txtReqNum.Location = new System.Drawing.Point(173, 22);
            this.txtReqNum.Name = "txtReqNum";
            this.txtReqNum.ReadOnly = true;
            this.txtReqNum.Size = new System.Drawing.Size(100, 20);
            this.txtReqNum.TabIndex = 8;
            // 
            // chkNewProj
            // 
            this.chkNewProj.AutoSize = true;
            this.chkNewProj.Location = new System.Drawing.Point(11, 63);
            this.chkNewProj.Name = "chkNewProj";
            this.chkNewProj.Size = new System.Drawing.Size(84, 17);
            this.chkNewProj.TabIndex = 7;
            this.chkNewProj.Text = "New Project";
            this.chkNewProj.UseVisualStyleBackColor = true;
            this.chkNewProj.CheckedChanged += new System.EventHandler(this.chkNewProj_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Required Qualifications";
            // 
            // lstQual
            // 
            this.lstQual.FormattingEnabled = true;
            this.lstQual.Location = new System.Drawing.Point(279, 22);
            this.lstQual.Name = "lstQual";
            this.lstQual.Size = new System.Drawing.Size(130, 34);
            this.lstQual.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Existing Assigned Projects";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbAssProj
            // 
            this.cmbAssProj.FormattingEnabled = true;
            this.cmbAssProj.Location = new System.Drawing.Point(8, 22);
            this.cmbAssProj.Name = "cmbAssProj";
            this.cmbAssProj.Size = new System.Drawing.Size(159, 21);
            this.cmbAssProj.TabIndex = 3;
            this.cmbAssProj.SelectedIndexChanged += new System.EventHandler(this.cmbAssProj_SelectedIndexChanged);
            // 
            // lstQualEmp
            // 
            this.lstQualEmp.FormattingEnabled = true;
            this.lstQualEmp.Items.AddRange(new object[] {
            "Matthew Camino",
            "David Fisher",
            "Evan Ligget",
            "Dan Martersteck",
            "Alexander Reynaud"});
            this.lstQualEmp.Location = new System.Drawing.Point(0, 125);
            this.lstQualEmp.Name = "lstQualEmp";
            this.lstQualEmp.Size = new System.Drawing.Size(172, 95);
            this.lstQualEmp.TabIndex = 2;
            this.lstQualEmp.SelectedIndexChanged += new System.EventHandler(this.lstQualEmp_SelectedIndexChanged);
            // 
            // tabEmpEquip
            // 
            this.tabEmpEquip.Controls.Add(this.groupBox1);
            this.tabEmpEquip.Controls.Add(this.label18);
            this.tabEmpEquip.Controls.Add(this.cmbClient);
            this.tabEmpEquip.Controls.Add(this.btnReport);
            this.tabEmpEquip.Controls.Add(this.label17);
            this.tabEmpEquip.Controls.Add(this.label16);
            this.tabEmpEquip.Controls.Add(this.btnMoveEquip);
            this.tabEmpEquip.Controls.Add(this.label15);
            this.tabEmpEquip.Controls.Add(this.cmbCondition);
            this.tabEmpEquip.Controls.Add(this.lstOpenEquip);
            this.tabEmpEquip.Controls.Add(this.lstNewEquip);
            this.tabEmpEquip.Location = new System.Drawing.Point(4, 22);
            this.tabEmpEquip.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmpEquip.Name = "tabEmpEquip";
            this.tabEmpEquip.Size = new System.Drawing.Size(424, 223);
            this.tabEmpEquip.TabIndex = 3;
            this.tabEmpEquip.Text = "Equipment Management";
            this.tabEmpEquip.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVNo);
            this.groupBox1.Controls.Add(this.radVYes);
            this.groupBox1.Location = new System.Drawing.Point(307, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 41);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is this a vehicle?";
            // 
            // radVNo
            // 
            this.radVNo.AutoSize = true;
            this.radVNo.Location = new System.Drawing.Point(69, 19);
            this.radVNo.Name = "radVNo";
            this.radVNo.Size = new System.Drawing.Size(39, 17);
            this.radVNo.TabIndex = 1;
            this.radVNo.TabStop = true;
            this.radVNo.Text = "No";
            this.radVNo.UseVisualStyleBackColor = true;
            // 
            // radVYes
            // 
            this.radVYes.AutoSize = true;
            this.radVYes.Location = new System.Drawing.Point(6, 19);
            this.radVYes.Name = "radVYes";
            this.radVYes.Size = new System.Drawing.Size(43, 17);
            this.radVYes.TabIndex = 0;
            this.radVYes.TabStop = true;
            this.radVYes.Text = "Yes";
            this.radVYes.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(381, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Sign for";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(300, 154);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 8;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(296, 201);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(128, 19);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Make Resource Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "New Assigned Equipment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Open Equipment";
            // 
            // btnMoveEquip
            // 
            this.btnMoveEquip.Location = new System.Drawing.Point(134, 138);
            this.btnMoveEquip.Name = "btnMoveEquip";
            this.btnMoveEquip.Size = new System.Drawing.Size(32, 23);
            this.btnMoveEquip.TabIndex = 4;
            this.btnMoveEquip.Text = ">>";
            this.btnMoveEquip.UseVisualStyleBackColor = true;
            this.btnMoveEquip.Click += new System.EventHandler(this.btnMoveEquip_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Equipment Condition";
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "(Select Value)",
            "Poor",
            "Fair",
            "Good",
            "New"});
            this.cmbCondition.Location = new System.Drawing.Point(6, 16);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(121, 21);
            this.cmbCondition.TabIndex = 2;
            // 
            // lstOpenEquip
            // 
            this.lstOpenEquip.FormattingEnabled = true;
            this.lstOpenEquip.Location = new System.Drawing.Point(8, 86);
            this.lstOpenEquip.Name = "lstOpenEquip";
            this.lstOpenEquip.Size = new System.Drawing.Size(120, 134);
            this.lstOpenEquip.TabIndex = 1;
            // 
            // lstNewEquip
            // 
            this.lstNewEquip.FormattingEnabled = true;
            this.lstNewEquip.Location = new System.Drawing.Point(172, 86);
            this.lstNewEquip.Name = "lstNewEquip";
            this.lstNewEquip.Size = new System.Drawing.Size(120, 134);
            this.lstNewEquip.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(493, 61);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(104, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(493, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
<<<<<<< HEAD
            this.btnLogin.Location = new System.Drawing.Point(540, 116);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 19);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
=======
            this.btnMainSubmit.Location = new System.Drawing.Point(540, 116);
            this.btnMainSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainSubmit.Name = "btnMainSubmit";
            this.btnMainSubmit.Size = new System.Drawing.Size(56, 19);
            this.btnMainSubmit.TabIndex = 2;
            this.btnMainSubmit.Text = "Login";
            this.btnMainSubmit.UseVisualStyleBackColor = true;
            this.btnMainSubmit.Click += new System.EventHandler(this.btnMainSubmit_Click);
>>>>>>> refs/remotes/origin/tracking-objects
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login to WEMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome, Alex!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(540, 139);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
<<<<<<< HEAD
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(440, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 7;
            // 
=======
>>>>>>> refs/remotes/origin/tracking-objects
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 249);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Wilco Employee Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.tabBookkeeper.ResumeLayout(false);
            this.tabBookkeeper.PerformLayout();
            this.tabEmpSuperv.ResumeLayout(false);
            this.tabEmpSuperv.PerformLayout();
            this.tabEmpEquip.ResumeLayout(false);
            this.tabEmpEquip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
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
        private System.Windows.Forms.Button btnSubChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmitSE;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.ListBox lstProjectBids;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnMoveEquip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ListBox lstOpenEquip;
        private System.Windows.Forms.ListBox lstNewEquip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radVNo;
        private System.Windows.Forms.RadioButton radVYes;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSubPay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListBox lstHours;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox lstActEmp;
        private System.Windows.Forms.Button btnEditPay;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Button btnEEOC;
    }
}

