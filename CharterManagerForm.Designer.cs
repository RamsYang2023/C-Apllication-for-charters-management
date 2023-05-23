
namespace GYangProgram16
{
    partial class CharterManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersForaYachtSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartersSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetForNextYachtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.nudCharterhour = new System.Windows.Forms.NumericUpDown();
            this.cboYachtSize = new System.Windows.Forms.ComboBox();
            this.cboYachtType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addANewTypeYachtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharterhour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.numberOfChartersForaYachtSizeToolStripMenuItem,
            this.chartersSummaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(125, 42);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Enabled = false;
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(583, 46);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // numberOfChartersForaYachtSizeToolStripMenuItem
            // 
            this.numberOfChartersForaYachtSizeToolStripMenuItem.Enabled = false;
            this.numberOfChartersForaYachtSizeToolStripMenuItem.Name = "numberOfChartersForaYachtSizeToolStripMenuItem";
            this.numberOfChartersForaYachtSizeToolStripMenuItem.Size = new System.Drawing.Size(583, 46);
            this.numberOfChartersForaYachtSizeToolStripMenuItem.Text = "Number of Charters for a Yacht Size";
            this.numberOfChartersForaYachtSizeToolStripMenuItem.Click += new System.EventHandler(this.numberOfChartersForaYachtSizeToolStripMenuItem_Click);
            // 
            // chartersSummaryToolStripMenuItem
            // 
            this.chartersSummaryToolStripMenuItem.Enabled = false;
            this.chartersSummaryToolStripMenuItem.Name = "chartersSummaryToolStripMenuItem";
            this.chartersSummaryToolStripMenuItem.Size = new System.Drawing.Size(583, 46);
            this.chartersSummaryToolStripMenuItem.Text = "Charters Summary";
            this.chartersSummaryToolStripMenuItem.Click += new System.EventHandler(this.chartersSummaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(580, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(583, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetForNextYachtToolStripMenuItem,
            this.toolStripSeparator2,
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(81, 42);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetForNextYachtToolStripMenuItem
            // 
            this.resetForNextYachtToolStripMenuItem.Name = "resetForNextYachtToolStripMenuItem";
            this.resetForNextYachtToolStripMenuItem.Size = new System.Drawing.Size(391, 46);
            this.resetForNextYachtToolStripMenuItem.Text = "Reset for Next Yacht";
            this.resetForNextYachtToolStripMenuItem.Click += new System.EventHandler(this.resetForNextYachtToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(388, 6);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(391, 46);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(391, 46);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCharter);
            this.groupBox1.Controls.Add(this.nudCharterhour);
            this.groupBox1.Controls.Add(this.cboYachtSize);
            this.groupBox1.Controls.Add(this.cboYachtType);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(77, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charters Info:";
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Location = new System.Drawing.Point(227, 386);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(238, 53);
            this.btnAddCharter.TabIndex = 8;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // nudCharterhour
            // 
            this.nudCharterhour.Location = new System.Drawing.Point(227, 287);
            this.nudCharterhour.Name = "nudCharterhour";
            this.nudCharterhour.Size = new System.Drawing.Size(238, 45);
            this.nudCharterhour.TabIndex = 7;
            // 
            // cboYachtSize
            // 
            this.cboYachtSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYachtSize.FormattingEnabled = true;
            this.cboYachtSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.cboYachtSize.Location = new System.Drawing.Point(227, 223);
            this.cboYachtSize.Name = "cboYachtSize";
            this.cboYachtSize.Size = new System.Drawing.Size(238, 46);
            this.cboYachtSize.TabIndex = 6;
            // 
            // cboYachtType
            // 
            this.cboYachtType.ContextMenuStrip = this.contextMenuStrip1;
            this.cboYachtType.FormattingEnabled = true;
            this.cboYachtType.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.cboYachtType.Location = new System.Drawing.Point(227, 148);
            this.cboYachtType.Name = "cboYachtType";
            this.cboYachtType.Size = new System.Drawing.Size(238, 46);
            this.cboYachtType.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewTypeYachtToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(270, 76);
            // 
            // addANewTypeYachtToolStripMenuItem
            // 
            this.addANewTypeYachtToolStripMenuItem.Name = "addANewTypeYachtToolStripMenuItem";
            this.addANewTypeYachtToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.addANewTypeYachtToolStripMenuItem.Text = "Add Yacht Type";
            this.addANewTypeYachtToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(269, 36);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 45);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yacht Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yacht Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Charter Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // CharterManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CharterManagerForm";
            this.Text = "CharterManagerForm-Created by Gang Yang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharterhour)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfChartersForaYachtSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartersSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetForNextYachtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.NumericUpDown nudCharterhour;
        private System.Windows.Forms.ComboBox cboYachtSize;
        private System.Windows.Forms.ComboBox cboYachtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addANewTypeYachtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
    }
}