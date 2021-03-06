﻿namespace UC1_Form
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
            this.txtPayRate = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.cboAssProj = new System.Windows.Forms.ComboBox();
            this.lstQualEmp = new System.Windows.Forms.ListBox();
            this.tabEmpEquip = new System.Windows.Forms.TabPage();
            this.btnCurStat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.btnInvSub = new System.Windows.Forms.Button();
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabBookkeeper.SuspendLayout();
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
            this.tabMain.Enabled = false;
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
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(424, 223);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "Standard Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 20);
            this.label27.TabIndex = 20;
            this.label27.Text = "View Credentials";
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
            this.label6.Location = new System.Drawing.Point(0, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Active Projects";
            // 
            // lstActiveProjects
            // 
            this.lstActiveProjects.FormattingEnabled = true;
            this.lstActiveProjects.Location = new System.Drawing.Point(3, 50);
            this.lstActiveProjects.Name = "lstActiveProjects";
            this.lstActiveProjects.Size = new System.Drawing.Size(156, 69);
            this.lstActiveProjects.TabIndex = 6;
            this.lstActiveProjects.SelectedIndexChanged += new System.EventHandler(this.lstActiveProjects_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 138);
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
            this.tabBookkeeper.Controls.Add(this.txtPayRate);
            this.tabBookkeeper.Controls.Add(this.label25);
            this.tabBookkeeper.Controls.Add(this.label24);
            this.tabBookkeeper.Controls.Add(this.label23);
            this.tabBookkeeper.Controls.Add(this.label22);
            this.tabBookkeeper.Controls.Add(this.lstHours);
            this.tabBookkeeper.Controls.Add(this.label21);
            this.tabBookkeeper.Controls.Add(this.label20);
            this.tabBookkeeper.Controls.Add(this.label19);
            this.tabBookkeeper.Location = new System.Drawing.Point(4, 22);
            this.tabBookkeeper.Margin = new System.Windows.Forms.Padding(2);
            this.tabBookkeeper.Name = "tabBookkeeper";
            this.tabBookkeeper.Padding = new System.Windows.Forms.Padding(2);
            this.tabBookkeeper.Size = new System.Drawing.Size(424, 223);
            this.tabBookkeeper.TabIndex = 0;
            this.tabBookkeeper.Text = "Bookkeeper";
            this.tabBookkeeper.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Pay Employees";
            // 
            // cboActEmp
            // 
            this.cboActEmp.FormattingEnabled = true;
            this.cboActEmp.Location = new System.Drawing.Point(5, 73);
            this.cboActEmp.Name = "cboActEmp";
            this.cboActEmp.Size = new System.Drawing.Size(121, 21);
            this.cboActEmp.TabIndex = 18;
            this.cboActEmp.SelectedIndexChanged += new System.EventHandler(this.cboActEmp_SelectedIndexChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(322, 28);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(98, 23);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify Paystub";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnEEOC
            // 
            this.btnEEOC.Enabled = false;
            this.btnEEOC.Location = new System.Drawing.Point(279, 57);
            this.btnEEOC.Name = "btnEEOC";
            this.btnEEOC.Size = new System.Drawing.Size(140, 23);
            this.btnEEOC.TabIndex = 14;
            this.btnEEOC.Text = "Fill Employee EEOC Form";
            this.btnEEOC.UseVisualStyleBackColor = true;
            // 
            // btnGrant
            // 
            this.btnGrant.Enabled = false;
            this.btnGrant.Location = new System.Drawing.Point(298, 85);
            this.btnGrant.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(122, 23);
            this.btnGrant.TabIndex = 13;
            this.btnGrant.Text = "Grant Employee Edit";
            this.btnGrant.UseVisualStyleBackColor = true;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
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
            this.btnValid.Enabled = false;
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
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(345, 127);
            this.txtPayRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.ReadOnly = true;
            this.txtPayRate.Size = new System.Drawing.Size(76, 20);
            this.txtPayRate.TabIndex = 9;
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
            this.lstHours.Enabled = false;
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
            this.label19.Location = new System.Drawing.Point(3, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
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
            this.tabEmpSuperv.Controls.Add(this.cboAssProj);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Assign Employee to Project";
            // 
            // btnSubChange
            // 
            this.btnSubChange.Enabled = false;
            this.btnSubChange.Location = new System.Drawing.Point(325, 197);
            this.btnSubChange.Name = "btnSubChange";
            this.btnSubChange.Size = new System.Drawing.Size(94, 23);
            this.btnSubChange.TabIndex = 15;
            this.btnSubChange.Text = "Submit Changes";
            this.btnSubChange.UseVisualStyleBackColor = true;
            this.btnSubChange.Click += new System.EventHandler(this.btnSubChange_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Currently Assigned";
            // 
            // btnMoveEmp
            // 
            this.btnMoveEmp.Enabled = false;
            this.btnMoveEmp.Location = new System.Drawing.Point(178, 134);
            this.btnMoveEmp.Name = "btnMoveEmp";
            this.btnMoveEmp.Size = new System.Drawing.Size(63, 23);
            this.btnMoveEmp.TabIndex = 12;
            this.btnMoveEmp.Text = ">>";
            this.btnMoveEmp.UseVisualStyleBackColor = true;
            this.btnMoveEmp.Click += new System.EventHandler(this.btnMoveEmp_Click);
            // 
            // lstCurrentAss
            // 
            this.lstCurrentAss.Enabled = false;
            this.lstCurrentAss.FormattingEnabled = true;
            this.lstCurrentAss.Location = new System.Drawing.Point(247, 125);
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
            this.label9.Location = new System.Drawing.Point(175, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Required Worker #\r\n";
            // 
            // txtReqNum
            // 
            this.txtReqNum.Location = new System.Drawing.Point(178, 198);
            this.txtReqNum.Name = "txtReqNum";
            this.txtReqNum.ReadOnly = true;
            this.txtReqNum.Size = new System.Drawing.Size(100, 20);
            this.txtReqNum.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Required Qualifications";
            // 
            // lstQual
            // 
            this.lstQual.Enabled = false;
            this.lstQual.FormattingEnabled = true;
            this.lstQual.Location = new System.Drawing.Point(289, 24);
            this.lstQual.Name = "lstQual";
            this.lstQual.Size = new System.Drawing.Size(130, 64);
            this.lstQual.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select Project";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAssProj
            // 
            this.cboAssProj.FormattingEnabled = true;
            this.cboAssProj.Location = new System.Drawing.Point(0, 38);
            this.cboAssProj.Name = "cboAssProj";
            this.cboAssProj.Size = new System.Drawing.Size(159, 21);
            this.cboAssProj.TabIndex = 3;
            this.cboAssProj.SelectedIndexChanged += new System.EventHandler(this.cboAssProj_SelectedIndexChanged);
            // 
            // lstQualEmp
            // 
            this.lstQualEmp.Enabled = false;
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
            // 
            // tabEmpEquip
            // 
            this.tabEmpEquip.Controls.Add(this.btnCurStat);
            this.tabEmpEquip.Controls.Add(this.label4);
            this.tabEmpEquip.Controls.Add(this.label18);
            this.tabEmpEquip.Controls.Add(this.cboClient);
            this.tabEmpEquip.Controls.Add(this.btnInvSub);
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
            // btnCurStat
            // 
            this.btnCurStat.Location = new System.Drawing.Point(7, 23);
            this.btnCurStat.Name = "btnCurStat";
            this.btnCurStat.Size = new System.Drawing.Size(87, 23);
            this.btnCurStat.TabIndex = 12;
            this.btnCurStat.Text = "Current Status";
            this.btnCurStat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Assign Equipment to Client";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Assign to";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(300, 154);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(121, 21);
            this.cboClient.TabIndex = 8;
            this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
            // 
            // btnInvSub
            // 
            this.btnInvSub.Enabled = false;
            this.btnInvSub.Location = new System.Drawing.Point(296, 196);
            this.btnInvSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvSub.Name = "btnInvSub";
            this.btnInvSub.Size = new System.Drawing.Size(128, 24);
            this.btnInvSub.TabIndex = 7;
            this.btnInvSub.Text = "Make Resource Report";
            this.btnInvSub.UseVisualStyleBackColor = true;
            this.btnInvSub.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Assigned Equipment";
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
            this.btnMoveEquip.Enabled = false;
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
            this.label15.Location = new System.Drawing.Point(317, 17);
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
            this.cmbCondition.Location = new System.Drawing.Point(300, 33);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(121, 21);
            this.cmbCondition.TabIndex = 2;
            this.cmbCondition.SelectedIndexChanged += new System.EventHandler(this.cmbCondition_selectedIndexChanged);
            // 
            // lstOpenEquip
            // 
            this.lstOpenEquip.Enabled = false;
            this.lstOpenEquip.FormattingEnabled = true;
            this.lstOpenEquip.Location = new System.Drawing.Point(8, 86);
            this.lstOpenEquip.Name = "lstOpenEquip";
            this.lstOpenEquip.Size = new System.Drawing.Size(120, 134);
            this.lstOpenEquip.TabIndex = 1;
            // 
            // lstNewEquip
            // 
            this.lstNewEquip.Enabled = false;
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
            this.btnLogin.Location = new System.Drawing.Point(540, 116);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 25);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 0);
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
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(540, 141);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 25);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 248);
            this.Controls.Add(this.btnLogout);
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
        private System.Windows.Forms.ComboBox cboAssProj;
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
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.Button btnSubPay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPayRate;
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
        private System.Windows.Forms.Button btnCurStat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboActEmp;
        private System.Windows.Forms.Label label27;
    }
}

