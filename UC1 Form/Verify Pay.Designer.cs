namespace UC_9_GUI
{
    partial class VerifyPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.lstHours = new System.Windows.Forms.ListBox();
            this.lstWage = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new UC1_Form.Database1DataSet1();
            this.eMPLOYEE_CONTRACTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new UC1_Form.Database1DataSet1TableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new UC1_Form.Database1DataSet1TableAdapters.TableAdapterManager();
            this.eMPLOYEE_CONTRACTTableAdapter = new UC1_Form.Database1DataSet1TableAdapters.EMPLOYEE_CONTRACTTableAdapter();
            this.cboJobs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_CONTRACTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // txtFirst
            // 
            this.txtFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "First_Name", true));
            this.txtFirst.Enabled = false;
            this.txtFirst.Location = new System.Drawing.Point(14, 44);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(61, 20);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "Last_Name", true));
            this.txtLast.Enabled = false;
            this.txtLast.Location = new System.Drawing.Point(107, 44);
            this.txtLast.Margin = new System.Windows.Forms.Padding(2);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(78, 20);
            this.txtLast.TabIndex = 2;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "M.I.";
            // 
            // txtMI
            // 
            this.txtMI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "MI", true));
            this.txtMI.Enabled = false;
            this.txtMI.Location = new System.Drawing.Point(79, 44);
            this.txtMI.Margin = new System.Windows.Forms.Padding(2);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(24, 20);
            this.txtMI.TabIndex = 5;
            this.txtMI.TextChanged += new System.EventHandler(this.txtMI_TextChanged);
            // 
            // lstHours
            // 
            this.lstHours.Enabled = false;
            this.lstHours.FormattingEnabled = true;
            this.lstHours.Location = new System.Drawing.Point(140, 107);
            this.lstHours.Margin = new System.Windows.Forms.Padding(2);
            this.lstHours.Name = "lstHours";
            this.lstHours.Size = new System.Drawing.Size(118, 82);
            this.lstHours.TabIndex = 7;
            // 
            // lstWage
            // 
            this.lstWage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.eMPLOYEE_CONTRACTBindingSource, "Wage", true));
            this.lstWage.Enabled = false;
            this.lstWage.FormattingEnabled = true;
            this.lstWage.Location = new System.Drawing.Point(262, 107);
            this.lstWage.Margin = new System.Windows.Forms.Padding(2);
            this.lstWage.Name = "lstWage";
            this.lstWage.Size = new System.Drawing.Size(62, 82);
            this.lstWage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Job";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hours Worked";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wage";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(14, 135);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(67, 24);
            this.btnVerify.TabIndex = 12;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEEBindingSource, "Employee_ID", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(189, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(14, 163);
            this.btnContact.Margin = new System.Windows.Forms.Padding(2);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(81, 38);
            this.btnContact.TabIndex = 15;
            this.btnContact.Text = "Contact Management";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEE_CONTRACTBindingSource
            // 
            this.eMPLOYEE_CONTRACTBindingSource.DataMember = "EMPLOYEE_CONTRACT";
            this.eMPLOYEE_CONTRACTBindingSource.DataSource = this.database1DataSet1;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.CONTRACTTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_CONTRACTTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_QUALTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.EQUIPMENTTableAdapter = null;
            this.tableAdapterManager.JOBSITETableAdapter = null;
            this.tableAdapterManager.LINE_ITEMTableAdapter = null;
            this.tableAdapterManager.PAYCHECKV1TableAdapter = null;
            this.tableAdapterManager.QUALIFICATIONTableAdapter = null;
            this.tableAdapterManager.SUPPLIER_EQUIPMENTTableAdapter = null;
            this.tableAdapterManager.SUPPLIER_ITEMTableAdapter = null;
            this.tableAdapterManager.SUPPLIERTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UC1_Form.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLOYEE_CONTRACTTableAdapter
            // 
            this.eMPLOYEE_CONTRACTTableAdapter.ClearBeforeFill = true;
            // 
            // cboJobs
            // 
            this.cboJobs.FormattingEnabled = true;
            this.cboJobs.Location = new System.Drawing.Point(14, 107);
            this.cboJobs.Name = "cboJobs";
            this.cboJobs.Size = new System.Drawing.Size(121, 21);
            this.cboJobs.TabIndex = 16;
            // 
            // VerifyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 212);
            this.Controls.Add(this.cboJobs);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstWage);
            this.Controls.Add(this.lstHours);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerifyPayment";
            this.Text = "Verify Payment Data";
            this.Load += new System.EventHandler(this.VerifyPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEE_CONTRACTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.ListBox lstHours;
        private System.Windows.Forms.ListBox lstWage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnContact;
        private UC1_Form.Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private UC1_Form.Database1DataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private UC1_Form.Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource eMPLOYEE_CONTRACTBindingSource;
        private UC1_Form.Database1DataSet1TableAdapters.EMPLOYEE_CONTRACTTableAdapter eMPLOYEE_CONTRACTTableAdapter;
        private System.Windows.Forms.ComboBox cboJobs;
    }
}

