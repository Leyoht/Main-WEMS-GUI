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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHours = new System.Windows.Forms.ListBox();
            this.lstWage = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.cboJobs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // txtFirst
            // 
            this.txtFirst.Enabled = false;
            this.txtFirst.Location = new System.Drawing.Point(22, 85);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(140, 31);
            this.txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            this.txtLast.Enabled = false;
            this.txtLast.Location = new System.Drawing.Point(170, 85);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(190, 31);
            this.txtLast.TabIndex = 2;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last";
            // 
            // lstHours
            // 
            this.lstHours.Enabled = false;
            this.lstHours.FormattingEnabled = true;
            this.lstHours.ItemHeight = 25;
            this.lstHours.Location = new System.Drawing.Point(280, 204);
            this.lstHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstHours.Name = "lstHours";
            this.lstHours.Size = new System.Drawing.Size(232, 154);
            this.lstHours.TabIndex = 7;
            // 
            // lstWage
            // 
            this.lstWage.Enabled = false;
            this.lstWage.FormattingEnabled = true;
            this.lstWage.ItemHeight = 25;
            this.lstWage.Location = new System.Drawing.Point(524, 204);
            this.lstWage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWage.Name = "lstWage";
            this.lstWage.Size = new System.Drawing.Size(158, 154);
            this.lstWage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Job";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hours Worked";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wage";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(28, 260);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(134, 46);
            this.btnVerify.TabIndex = 12;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(432, 85);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 31);
            this.txtID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(28, 313);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(242, 48);
            this.btnContact.TabIndex = 15;
            this.btnContact.Text = "Contact Management";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // cboJobs
            // 
            this.cboJobs.FormattingEnabled = true;
            this.cboJobs.Location = new System.Drawing.Point(22, 206);
            this.cboJobs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboJobs.Name = "cboJobs";
            this.cboJobs.Size = new System.Drawing.Size(244, 33);
            this.cboJobs.TabIndex = 16;
            // 
            // VerifyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 371);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VerifyPayment";
            this.Text = "Verify Payment Data";
            this.Load += new System.EventHandler(this.VerifyPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHours;
        private System.Windows.Forms.ListBox lstWage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.ComboBox cboJobs;
    }
}

