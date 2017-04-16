namespace UC1_Form
{
    partial class Paystub
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
            this.txtEmployer = new System.Windows.Forms.TextBox();
            this.txtEmployerAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeAdd = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.grpEmployer = new System.Windows.Forms.GroupBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPayPeriod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPayDate = new System.Windows.Forms.TextBox();
            this.grpIncTax = new System.Windows.Forms.GroupBox();
            this.btnSubChang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpEmployer.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            this.grpIncTax.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployer
            // 
            this.txtEmployer.Location = new System.Drawing.Point(6, 49);
            this.txtEmployer.Name = "txtEmployer";
            this.txtEmployer.Size = new System.Drawing.Size(100, 22);
            this.txtEmployer.TabIndex = 0;
            // 
            // txtEmployerAdd
            // 
            this.txtEmployerAdd.Location = new System.Drawing.Point(112, 49);
            this.txtEmployerAdd.Name = "txtEmployerAdd";
            this.txtEmployerAdd.Size = new System.Drawing.Size(131, 22);
            this.txtEmployerAdd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // txtEmployeeAdd
            // 
            this.txtEmployeeAdd.Location = new System.Drawing.Point(112, 44);
            this.txtEmployeeAdd.Name = "txtEmployeeAdd";
            this.txtEmployeeAdd.Size = new System.Drawing.Size(131, 22);
            this.txtEmployeeAdd.TabIndex = 5;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(6, 44);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 22);
            this.txtEmployee.TabIndex = 4;
            // 
            // grpEmployer
            // 
            this.grpEmployer.Controls.Add(this.txtEmployer);
            this.grpEmployer.Controls.Add(this.txtEmployerAdd);
            this.grpEmployer.Controls.Add(this.label1);
            this.grpEmployer.Controls.Add(this.label2);
            this.grpEmployer.Location = new System.Drawing.Point(12, 12);
            this.grpEmployer.Name = "grpEmployer";
            this.grpEmployer.Size = new System.Drawing.Size(261, 85);
            this.grpEmployer.TabIndex = 8;
            this.grpEmployer.TabStop = false;
            this.grpEmployer.Text = "Employer";
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.label6);
            this.grpEmployee.Controls.Add(this.txtSSN);
            this.grpEmployee.Controls.Add(this.label5);
            this.grpEmployee.Controls.Add(this.txtID);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Controls.Add(this.txtEmployee);
            this.grpEmployee.Controls.Add(this.label3);
            this.grpEmployee.Controls.Add(this.txtEmployeeAdd);
            this.grpEmployee.Location = new System.Drawing.Point(12, 103);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(431, 85);
            this.grpEmployee.TabIndex = 4;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(249, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 22);
            this.txtID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(331, 44);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(89, 22);
            this.txtSSN.TabIndex = 10;
            // 
            // txtPayPeriod
            // 
            this.txtPayPeriod.Location = new System.Drawing.Point(375, 32);
            this.txtPayPeriod.Name = "txtPayPeriod";
            this.txtPayPeriod.Size = new System.Drawing.Size(149, 22);
            this.txtPayPeriod.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pay Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pay Date";
            // 
            // txtPayDate
            // 
            this.txtPayDate.Location = new System.Drawing.Point(425, 75);
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.Size = new System.Drawing.Size(99, 22);
            this.txtPayDate.TabIndex = 14;
            // 
            // grpIncTax
            // 
            this.grpIncTax.Controls.Add(this.label15);
            this.grpIncTax.Controls.Add(this.label14);
            this.grpIncTax.Controls.Add(this.label13);
            this.grpIncTax.Controls.Add(this.label12);
            this.grpIncTax.Controls.Add(this.label11);
            this.grpIncTax.Controls.Add(this.label10);
            this.grpIncTax.Controls.Add(this.label9);
            this.grpIncTax.Controls.Add(this.listBox1);
            this.grpIncTax.Controls.Add(this.listBox2);
            this.grpIncTax.Location = new System.Drawing.Point(12, 213);
            this.grpIncTax.Name = "grpIncTax";
            this.grpIncTax.Size = new System.Drawing.Size(511, 161);
            this.grpIncTax.TabIndex = 16;
            this.grpIncTax.TabStop = false;
            this.grpIncTax.Text = "Income and Taxes";
            // 
            // btnSubChang
            // 
            this.btnSubChang.Location = new System.Drawing.Point(403, 380);
            this.btnSubChang.Name = "btnSubChang";
            this.btnSubChang.Size = new System.Drawing.Size(121, 25);
            this.btnSubChang.TabIndex = 0;
            this.btnSubChang.Text = "Submit Changes";
            this.btnSubChang.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 84);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(252, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 84);
            this.listBox2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Income";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hours";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total Pay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Deductions";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Year-to-Date";
            // 
            // Paystub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 415);
            this.Controls.Add(this.btnSubChang);
            this.Controls.Add(this.grpIncTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPayDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPayPeriod);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.grpEmployer);
            this.Name = "Paystub";
            this.Text = "Paystub";
            this.grpEmployer.ResumeLayout(false);
            this.grpEmployer.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpIncTax.ResumeLayout(false);
            this.grpIncTax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployer;
        private System.Windows.Forms.TextBox txtEmployerAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeAdd;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.GroupBox grpEmployer;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPayPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPayDate;
        private System.Windows.Forms.GroupBox grpIncTax;
        private System.Windows.Forms.Button btnSubChang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}