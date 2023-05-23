
namespace GYangProgram16
{
    partial class AllCharterForm
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
            this.CharterManagerbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharterManagerbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CharterManagerbindingSource
            // 
            this.CharterManagerbindingSource.DataMember = "CharterList";
            this.CharterManagerbindingSource.DataSource = typeof(GYangProgram16.CharterManager);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.yachtTypeDataGridViewTextBoxColumn,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.charterHoursDataGridViewTextBoxColumn,
            this.charterFeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.CharterManagerbindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-16, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(976, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customer Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // yachtTypeDataGridViewTextBoxColumn
            // 
            this.yachtTypeDataGridViewTextBoxColumn.DataPropertyName = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.HeaderText = "Yacht Type";
            this.yachtTypeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.yachtTypeDataGridViewTextBoxColumn.Name = "yachtTypeDataGridViewTextBoxColumn";
            this.yachtTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtTypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "Yacht Size";
            this.yachtSizeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            this.yachtSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtSizeDataGridViewTextBoxColumn.Width = 150;
            // 
            // charterHoursDataGridViewTextBoxColumn
            // 
            this.charterHoursDataGridViewTextBoxColumn.DataPropertyName = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.HeaderText = "Charter Hours";
            this.charterHoursDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.charterHoursDataGridViewTextBoxColumn.Name = "charterHoursDataGridViewTextBoxColumn";
            this.charterHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterHoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "Charter Fee";
            this.charterFeeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterFeeDataGridViewTextBoxColumn.Width = 175;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(820, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AllCharterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllCharterForm";
            this.Text = "AllCharterForm -Created by Gang Yang";
            ((System.ComponentModel.ISupportInitialize)(this.CharterManagerbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.BindingSource CharterManagerbindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}