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
            this.components = new System.ComponentModel.Container();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.btnEditPay = new System.Windows.Forms.Button();
            this.btnSubPay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmitSE = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.lstProjectBids = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstActiveProjects = new System.Windows.Forms.ListBox();
            this.eMPLOYEE_CONTRACTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new UC1_Form.Database2DataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.tabBookkeeper = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cboActEmp = new System.Windows.Forms.ComboBox();
            this.btnVerify = new System.Windows.Forms.Button();
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
            this.tabEmpSuperv = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSubChange = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMoveEmp = new System.Windows.Forms.Button();
            this.lstCurrentAss = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReqNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstQual = new System.Windows.Forms.CheckedListBox();
            this.qUALIFICATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAssProj = new System.Windows.Forms.ComboBox();
            this.lstQualEmp = new System.Windows.Forms.ListBox();
            this.tabEmpEquip = new System.Windows.Forms.TabPage();
            this.btnCurStat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.btnInvSub = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMoveEquip = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lstOpenEquip = new System.Windows.Forms.ListBox();
            this.lstNewEquip = new System.Windows.Forms.ListBox();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_CONTRACTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.tabBookkeeper.SuspendLayout();
            this.tabEmpSuperv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUALIFICATIONBindingSource)).BeginInit();
            this.tabEmpEquip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEmployee);
            this.tabMain.Controls.Add(this.tabBookkeeper);
            this.tabMain.Controls.Add(this.tabEmpSuperv);
            this.tabMain.Controls.Add(this.tabEmpEquip);
            this.tabMain.Enabled = false;
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
            this.tabEmployee.Controls.Add(this.label27);
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
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(568, 277);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Standard Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(4, 0);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(159, 25);
            this.label27.TabIndex = 20;
            this.label27.Text = "View Credentials";
            // 
            // btnEditPay
            // 
            this.btnEditPay.Enabled = false;
            this.btnEditPay.Location = new System.Drawing.Point(201, 212);
            this.btnEditPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPay.Name = "btnEditPay";
            this.btnEditPay.Size = new System.Drawing.Size(99, 28);
            this.btnEditPay.TabIndex = 16;
            this.btnEditPay.Text = "Edit Paystub";
            this.btnEditPay.UseVisualStyleBackColor = true;
            // 
            // btnSubPay
            // 
            this.btnSubPay.Enabled = false;
            this.btnSubPay.Location = new System.Drawing.Point(201, 246);
            this.btnSubPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubPay.Name = "btnSubPay";
            this.btnSubPay.Size = new System.Drawing.Size(115, 28);
            this.btnSubPay.TabIndex = 15;
            this.btnSubPay.Text = "Submit Paystub";
            this.btnSubPay.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(375, 71);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Uploaded Project Bids (.xlsx)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(497, 212);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 28);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmitSE
            // 
            this.btnSubmitSE.Location = new System.Drawing.Point(463, 246);
            this.btnSubmitSE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitSE.Name = "btnSubmitSE";
            this.btnSubmitSE.Size = new System.Drawing.Size(100, 28);
            this.btnSubmitSE.TabIndex = 10;
            this.btnSubmitSE.Text = "Submit";
            this.btnSubmitSE.UseVisualStyleBackColor = true;
            this.btnSubmitSE.Click += new System.EventHandler(this.btnSubmitSE_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(333, 215);
            this.txtBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(155, 22);
            this.txtBrowse.TabIndex = 9;
            // 
            // lstProjectBids
            // 
            this.lstProjectBids.FormattingEnabled = true;
            this.lstProjectBids.ItemHeight = 16;
            this.lstProjectBids.Location = new System.Drawing.Point(293, 90);
            this.lstProjectBids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProjectBids.Name = "lstProjectBids";
            this.lstProjectBids.Size = new System.Drawing.Size(268, 100);
            this.lstProjectBids.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Active Projects";
            // 
            // lstActiveProjects
            // 
            this.lstActiveProjects.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLOYEE_CONTRACTBindingSource, "Job_Name", true));
            this.lstActiveProjects.FormattingEnabled = true;
            this.lstActiveProjects.ItemHeight = 16;
            this.lstActiveProjects.Location = new System.Drawing.Point(4, 62);
            this.lstActiveProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstActiveProjects.Name = "lstActiveProjects";
            this.lstActiveProjects.Size = new System.Drawing.Size(207, 84);
            this.lstActiveProjects.TabIndex = 6;
            this.lstActiveProjects.SelectedIndexChanged += new System.EventHandler(this.lstActiveProjects_SelectedIndexChanged);
            // 
            // eMPLOYEE_CONTRACTBindingSource
            // 
            this.eMPLOYEE_CONTRACTBindingSource.DataMember = "EMPLOYEE_CONTRACT";
            this.eMPLOYEE_CONTRACTBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database1DataSet1";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 170);
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
            this.lstReports.Location = new System.Drawing.Point(4, 190);
            this.lstReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(191, 84);
            this.lstReports.TabIndex = 1;
            this.lstReports.SelectedIndexChanged += new System.EventHandler(this.lstReports_SelectedIndexChanged);
            // 
            // tabBookkeeper
            // 
            this.tabBookkeeper.Controls.Add(this.label12);
            this.tabBookkeeper.Controls.Add(this.cboActEmp);
            this.tabBookkeeper.Controls.Add(this.btnVerify);
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
            this.tabBookkeeper.Location = new System.Drawing.Point(4, 25);
            this.tabBookkeeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBookkeeper.Name = "tabBookkeeper";
            this.tabBookkeeper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBookkeeper.Size = new System.Drawing.Size(568, 277);
            this.tabBookkeeper.TabIndex = 0;
            this.tabBookkeeper.Text = "Bookkeeper";
            this.tabBookkeeper.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Pay Employees";
            // 
            // cboActEmp
            // 
            this.cboActEmp.FormattingEnabled = true;
            this.cboActEmp.Location = new System.Drawing.Point(7, 90);
            this.cboActEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboActEmp.Name = "cboActEmp";
            this.cboActEmp.Size = new System.Drawing.Size(160, 24);
            this.cboActEmp.TabIndex = 18;
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(429, 34);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(131, 28);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify Paystub";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnEEOC
            // 
            this.btnEEOC.Enabled = false;
            this.btnEEOC.Location = new System.Drawing.Point(372, 70);
            this.btnEEOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEEOC.Name = "btnEEOC";
            this.btnEEOC.Size = new System.Drawing.Size(187, 28);
            this.btnEEOC.TabIndex = 14;
            this.btnEEOC.Text = "Fill Employee EEOC Form";
            this.btnEEOC.UseVisualStyleBackColor = true;
            // 
            // btnGrant
            // 
            this.btnGrant.Enabled = false;
            this.btnGrant.Location = new System.Drawing.Point(397, 105);
            this.btnGrant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(163, 28);
            this.btnGrant.TabIndex = 13;
            this.btnGrant.Text = "Grant Employee Edit";
            this.btnGrant.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(487, 249);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnValid
            // 
            this.btnValid.Enabled = false;
            this.btnValid.Location = new System.Drawing.Point(487, 219);
            this.btnValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(75, 23);
            this.btnValid.TabIndex = 11;
            this.btnValid.Text = "Validate";
            this.btnValid.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(405, 249);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 17);
            this.label26.TabIndex = 10;
            this.label26.Text = "Pay";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 156);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(291, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 17);
            this.label25.TabIndex = 8;
            this.label25.Text = "Hours Worked";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 249);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 17);
            this.label24.TabIndex = 7;
            this.label24.Text = "Day";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(65, 249);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 17);
            this.label23.TabIndex = 6;
            this.label23.Text = "Clock In";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(171, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 17);
            this.label22.TabIndex = 5;
            this.label22.Text = "Clock Out";
            // 
            // lstHours
            // 
            this.lstHours.Enabled = false;
            this.lstHours.FormattingEnabled = true;
            this.lstHours.ItemHeight = 16;
            this.lstHours.Location = new System.Drawing.Point(5, 156);
            this.lstHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHours.Name = "lstHours";
            this.lstHours.Size = new System.Drawing.Size(432, 84);
            this.lstHours.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(457, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Pay Rate ($/hr)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Logged Hours";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Select Employee";
            // 
            // tabEmpSuperv
            // 
            this.tabEmpSuperv.Controls.Add(this.label14);
            this.tabEmpSuperv.Controls.Add(this.btnSubChange);
            this.tabEmpSuperv.Controls.Add(this.label11);
            this.tabEmpSuperv.Controls.Add(this.btnMoveEmp);
            this.tabEmpSuperv.Controls.Add(this.lstCurrentAss);
            this.tabEmpSuperv.Controls.Add(this.label10);
            this.tabEmpSuperv.Controls.Add(this.label9);
            this.tabEmpSuperv.Controls.Add(this.txtReqNum);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Assign Employee to Project";
            // 
            // btnSubChange
            // 
            this.btnSubChange.Enabled = false;
            this.btnSubChange.Location = new System.Drawing.Point(433, 242);
            this.btnSubChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubChange.Name = "btnSubChange";
            this.btnSubChange.Size = new System.Drawing.Size(125, 28);
            this.btnSubChange.TabIndex = 15;
            this.btnSubChange.Text = "Submit Changes";
            this.btnSubChange.UseVisualStyleBackColor = true;
            this.btnSubChange.Click += new System.EventHandler(this.btnSubChange_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 134);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Currently Assigned";
            // 
            // btnMoveEmp
            // 
            this.btnMoveEmp.Enabled = false;
            this.btnMoveEmp.Location = new System.Drawing.Point(237, 165);
            this.btnMoveEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveEmp.Name = "btnMoveEmp";
            this.btnMoveEmp.Size = new System.Drawing.Size(84, 28);
            this.btnMoveEmp.TabIndex = 12;
            this.btnMoveEmp.Text = ">>";
            this.btnMoveEmp.UseVisualStyleBackColor = true;
            this.btnMoveEmp.Click += new System.EventHandler(this.btnMoveEmp_Click);
            // 
            // lstCurrentAss
            // 
            this.lstCurrentAss.Enabled = false;
            this.lstCurrentAss.FormattingEnabled = true;
            this.lstCurrentAss.ItemHeight = 16;
            this.lstCurrentAss.Location = new System.Drawing.Point(329, 154);
            this.lstCurrentAss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCurrentAss.Name = "lstCurrentAss";
            this.lstCurrentAss.Size = new System.Drawing.Size(228, 68);
            this.lstCurrentAss.TabIndex = 11;
            this.lstCurrentAss.SelectedIndexChanged += new System.EventHandler(this.lstCurrentAss_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-4, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Qualified Employees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Required Worker #\r\n";
            // 
            // txtReqNum
            // 
            this.txtReqNum.Location = new System.Drawing.Point(237, 244);
            this.txtReqNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReqNum.Name = "txtReqNum";
            this.txtReqNum.ReadOnly = true;
            this.txtReqNum.Size = new System.Drawing.Size(132, 22);
            this.txtReqNum.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Required Qualifications";
            // 
            // lstQual
            // 
            this.lstQual.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.qUALIFICATIONBindingSource, "Name", true));
            this.lstQual.Enabled = false;
            this.lstQual.FormattingEnabled = true;
            this.lstQual.Location = new System.Drawing.Point(385, 30);
            this.lstQual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstQual.Name = "lstQual";
            this.lstQual.Size = new System.Drawing.Size(172, 89);
            this.lstQual.TabIndex = 5;
            // 
            // qUALIFICATIONBindingSource
            // 
            this.qUALIFICATIONBindingSource.DataMember = "QUALIFICATION";
            this.qUALIFICATIONBindingSource.DataSource = this.database2DataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select Project";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbAssProj
            // 
            this.cmbAssProj.FormattingEnabled = true;
            this.cmbAssProj.Items.AddRange(new object[] {
            "Example"});
            this.cmbAssProj.Location = new System.Drawing.Point(0, 47);
            this.cmbAssProj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAssProj.Name = "cmbAssProj";
            this.cmbAssProj.Size = new System.Drawing.Size(211, 24);
            this.cmbAssProj.TabIndex = 3;
            this.cmbAssProj.SelectedIndexChanged += new System.EventHandler(this.cmbAssProj_SelectedIndexChanged);
            // 
            // lstQualEmp
            // 
            this.lstQualEmp.Enabled = false;
            this.lstQualEmp.FormattingEnabled = true;
            this.lstQualEmp.ItemHeight = 16;
            this.lstQualEmp.Items.AddRange(new object[] {
            "Matthew Camino",
            "David Fisher",
            "Evan Ligget",
            "Dan Martersteck",
            "Alexander Reynaud"});
            this.lstQualEmp.Location = new System.Drawing.Point(0, 154);
            this.lstQualEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstQualEmp.Name = "lstQualEmp";
            this.lstQualEmp.Size = new System.Drawing.Size(228, 116);
            this.lstQualEmp.TabIndex = 2;
            this.lstQualEmp.SelectedIndexChanged += new System.EventHandler(this.lstQualEmp_SelectedIndexChanged);
            // 
            // tabEmpEquip
            // 
            this.tabEmpEquip.Controls.Add(this.btnCurStat);
            this.tabEmpEquip.Controls.Add(this.label4);
            this.tabEmpEquip.Controls.Add(this.label18);
            this.tabEmpEquip.Controls.Add(this.cmbClient);
            this.tabEmpEquip.Controls.Add(this.btnInvSub);
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
            // btnCurStat
            // 
            this.btnCurStat.Location = new System.Drawing.Point(9, 28);
            this.btnCurStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCurStat.Name = "btnCurStat";
            this.btnCurStat.Size = new System.Drawing.Size(116, 28);
            this.btnCurStat.TabIndex = 12;
            this.btnCurStat.Text = "Current Status";
            this.btnCurStat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Assign Equipment to Client";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(495, 170);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Assign to";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Items.AddRange(new object[] {
            "Example"});
            this.cmbClient.Location = new System.Drawing.Point(400, 190);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(160, 24);
            this.cmbClient.TabIndex = 8;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // btnInvSub
            // 
            this.btnInvSub.Enabled = false;
            this.btnInvSub.Location = new System.Drawing.Point(395, 241);
            this.btnInvSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInvSub.Name = "btnInvSub";
            this.btnInvSub.Size = new System.Drawing.Size(171, 30);
            this.btnInvSub.TabIndex = 7;
            this.btnInvSub.Text = "Make Resource Report";
            this.btnInvSub.UseVisualStyleBackColor = true;
            this.btnInvSub.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Assigned Equipment";
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
            this.btnMoveEquip.Enabled = false;
            this.btnMoveEquip.Location = new System.Drawing.Point(179, 170);
            this.btnMoveEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMoveEquip.Name = "btnMoveEquip";
            this.btnMoveEquip.Size = new System.Drawing.Size(43, 28);
            this.btnMoveEquip.TabIndex = 4;
            this.btnMoveEquip.Text = ">>";
            this.btnMoveEquip.UseVisualStyleBackColor = true;
            this.btnMoveEquip.Click += new System.EventHandler(this.btnMoveEquip_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(423, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 17);
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
            this.cmbCondition.Location = new System.Drawing.Point(400, 41);
            this.cmbCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(160, 24);
            this.cmbCondition.TabIndex = 2;
            // 
            // lstOpenEquip
            // 
            this.lstOpenEquip.Enabled = false;
            this.lstOpenEquip.FormattingEnabled = true;
            this.lstOpenEquip.ItemHeight = 16;
            this.lstOpenEquip.Location = new System.Drawing.Point(11, 106);
            this.lstOpenEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOpenEquip.Name = "lstOpenEquip";
            this.lstOpenEquip.Size = new System.Drawing.Size(159, 164);
            this.lstOpenEquip.TabIndex = 1;
            // 
            // lstNewEquip
            // 
            this.lstNewEquip.Enabled = false;
            this.lstNewEquip.FormattingEnabled = true;
            this.lstNewEquip.ItemHeight = 16;
            this.lstNewEquip.Location = new System.Drawing.Point(229, 106);
            this.lstNewEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstNewEquip.Name = "lstNewEquip";
            this.lstNewEquip.Size = new System.Drawing.Size(159, 164);
            this.lstNewEquip.TabIndex = 0;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.database2DataSet;
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
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(720, 143);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 0);
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
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(720, 174);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 305);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
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
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_CONTRACTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.tabBookkeeper.ResumeLayout(false);
            this.tabBookkeeper.PerformLayout();
            this.tabEmpSuperv.ResumeLayout(false);
            this.tabEmpSuperv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUALIFICATIONBindingSource)).EndInit();
            this.tabEmpEquip.ResumeLayout(false);
            this.tabEmpEquip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInvSub;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbClient;
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
        private System.Windows.Forms.Button btnEditPay;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Button btnEEOC;
        private System.Windows.Forms.Button btnVerify;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource eMPLOYEE_CONTRACTBindingSource;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private System.Windows.Forms.BindingSource qUALIFICATIONBindingSource;
        private System.Windows.Forms.Button btnCurStat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboActEmp;
        private System.Windows.Forms.Label label27;
    }
}

