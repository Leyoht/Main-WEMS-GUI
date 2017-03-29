namespace UC1_Form
{
    partial class EEOC_Compliance
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
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboRace = new System.Windows.Forms.ComboBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(102, 212);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(111, 20);
            this.txtJob.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Job Classification:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(38, 263);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Nonbinary"});
            this.cboGender.Location = new System.Drawing.Point(104, 177);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(110, 21);
            this.cboGender.TabIndex = 26;
            // 
            // cboRace
            // 
            this.cboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRace.FormattingEnabled = true;
            this.cboRace.Items.AddRange(new object[] {
            "Caucasian",
            "African American",
            "Hispanic/Latino",
            "Asian",
            "Native American",
            "Indian",
            "Middle Eastern",
            "African"});
            this.cboRace.Location = new System.Drawing.Point(104, 143);
            this.cboRace.Margin = new System.Windows.Forms.Padding(2);
            this.cboRace.Name = "cboRace";
            this.cboRace.Size = new System.Drawing.Size(109, 21);
            this.cboRace.TabIndex = 25;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(102, 108);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(112, 20);
            this.txtEmpID.TabIndex = 24;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(103, 77);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(111, 20);
            this.txtLastName.TabIndex = 23;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 47);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtFirstName.TabIndex = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(188, 263);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Submit";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "EEOC Compliance Form";
            // 
            // EEOC_Compliance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboRace);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EEOC_Compliance";
            this.Text = "EEOC_Compliance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboRace;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}