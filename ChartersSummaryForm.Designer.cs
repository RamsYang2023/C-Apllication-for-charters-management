
namespace GYangProgram16
{
    partial class ChartersSummaryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverageFee = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblLowestFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverageFee);
            this.groupBox1.Controls.Add(this.lblTotalFee);
            this.groupBox1.Controls.Add(this.lblLowestFee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(84, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charter Summary";
            // 
            // lblAverageFee
            // 
            this.lblAverageFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageFee.Location = new System.Drawing.Point(329, 249);
            this.lblAverageFee.Name = "lblAverageFee";
            this.lblAverageFee.Size = new System.Drawing.Size(186, 39);
            this.lblAverageFee.TabIndex = 5;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFee.Location = new System.Drawing.Point(329, 167);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(186, 39);
            this.lblTotalFee.TabIndex = 4;
            // 
            // lblLowestFee
            // 
            this.lblLowestFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowestFee.Location = new System.Drawing.Point(329, 83);
            this.lblLowestFee.Name = "lblLowestFee";
            this.lblLowestFee.Size = new System.Drawing.Size(186, 39);
            this.lblLowestFee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average Charter fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Charter fee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lowest Charter fee:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChartersSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChartersSummaryForm";
            this.Text = "Charters Summary - Created by Gang Yang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblAverageFee;
        internal System.Windows.Forms.Label lblTotalFee;
        internal System.Windows.Forms.Label lblLowestFee;
        private System.Windows.Forms.Button btnClose;
    }
}