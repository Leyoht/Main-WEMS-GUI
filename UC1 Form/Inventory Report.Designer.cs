﻿namespace UC1_Form
{
    partial class Inventory_Report
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
            this.lstShowInv = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPrint = new System.Windows.Forms.GroupBox();
            this.btnPYes = new System.Windows.Forms.RadioButton();
            this.btnPNo = new System.Windows.Forms.RadioButton();
            this.grpPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstShowInv
            // 
            this.lstShowInv.FormattingEnabled = true;
            this.lstShowInv.Location = new System.Drawing.Point(11, 83);
            this.lstShowInv.Margin = new System.Windows.Forms.Padding(2);
            this.lstShowInv.Name = "lstShowInv";
            this.lstShowInv.Size = new System.Drawing.Size(253, 160);
            this.lstShowInv.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(109, 265);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 19);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "&Send";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnInvSub_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(109, 288);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory Report";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // grpPrint
            // 
            this.grpPrint.Controls.Add(this.btnPNo);
            this.grpPrint.Controls.Add(this.btnPYes);
            this.grpPrint.Location = new System.Drawing.Point(11, 251);
            this.grpPrint.Name = "grpPrint";
            this.grpPrint.Size = new System.Drawing.Size(97, 57);
            this.grpPrint.TabIndex = 7;
            this.grpPrint.TabStop = false;
            this.grpPrint.Text = "Send to Printer?";
            // 
            // btnPYes
            // 
            this.btnPYes.AutoSize = true;
            this.btnPYes.Location = new System.Drawing.Point(3, 16);
            this.btnPYes.Name = "btnPYes";
            this.btnPYes.Size = new System.Drawing.Size(43, 17);
            this.btnPYes.TabIndex = 0;
            this.btnPYes.TabStop = true;
            this.btnPYes.Text = "Yes";
            this.btnPYes.UseVisualStyleBackColor = true;
            // 
            // btnPNo
            // 
            this.btnPNo.AutoSize = true;
            this.btnPNo.Location = new System.Drawing.Point(3, 34);
            this.btnPNo.Name = "btnPNo";
            this.btnPNo.Size = new System.Drawing.Size(39, 17);
            this.btnPNo.TabIndex = 1;
            this.btnPNo.TabStop = true;
            this.btnPNo.Text = "No";
            this.btnPNo.UseVisualStyleBackColor = true;
            // 
            // Inventory_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 318);
            this.Controls.Add(this.grpPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lstShowInv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Inventory_Report";
            this.Text = "Inventory_Report";
            this.grpPrint.ResumeLayout(false);
            this.grpPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShowInv;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPrint;
        private System.Windows.Forms.RadioButton btnPNo;
        private System.Windows.Forms.RadioButton btnPYes;
    }
}