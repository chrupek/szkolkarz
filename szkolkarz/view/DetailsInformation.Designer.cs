namespace szkolkarz.view
{
    partial class DetailsInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.sownLogDataGridView = new System.Windows.Forms.DataGridView();
            this.vFULLSOWNLOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAPEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTIONNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sownLogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFULLSOWNLOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sownLogDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(614, 337);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(193, 337);
            this.treeView1.TabIndex = 0;
            // 
            // sownLogDataGridView
            // 
            this.sownLogDataGridView.AllowUserToAddRows = false;
            this.sownLogDataGridView.AllowUserToDeleteRows = false;
            this.sownLogDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sownLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sownLogDataGridView.AutoGenerateColumns = false;
            this.sownLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sownLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tAPEIDDataGridViewTextBoxColumn,
            this.yEARDataGridViewTextBoxColumn,
            this.pLANTDataGridViewTextBoxColumn,
            this.pRODUCTIONNODataGridViewTextBoxColumn});
            this.sownLogDataGridView.DataSource = this.vFULLSOWNLOGBindingSource;
            this.sownLogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sownLogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sownLogDataGridView.Name = "sownLogDataGridView";
            this.sownLogDataGridView.ReadOnly = true;
            this.sownLogDataGridView.Size = new System.Drawing.Size(417, 337);
            this.sownLogDataGridView.TabIndex = 0;
            // 
            // vFULLSOWNLOGBindingSource
            // 
            this.vFULLSOWNLOGBindingSource.DataSource = typeof(szkolkarz.V_FULL_SOWN_LOG);
            // 
            // tAPEIDDataGridViewTextBoxColumn
            // 
            this.tAPEIDDataGridViewTextBoxColumn.DataPropertyName = "TAPE_ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tAPEIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tAPEIDDataGridViewTextBoxColumn.HeaderText = "Id taśmy";
            this.tAPEIDDataGridViewTextBoxColumn.Name = "tAPEIDDataGridViewTextBoxColumn";
            this.tAPEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.yEARDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.yEARDataGridViewTextBoxColumn.HeaderText = "Rok obsiania";
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            this.yEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLANTDataGridViewTextBoxColumn
            // 
            this.pLANTDataGridViewTextBoxColumn.DataPropertyName = "PLANT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pLANTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pLANTDataGridViewTextBoxColumn.HeaderText = "Artykuł";
            this.pLANTDataGridViewTextBoxColumn.Name = "pLANTDataGridViewTextBoxColumn";
            this.pLANTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTIONNODataGridViewTextBoxColumn
            // 
            this.pRODUCTIONNODataGridViewTextBoxColumn.DataPropertyName = "PRODUCTION_NO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pRODUCTIONNODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.pRODUCTIONNODataGridViewTextBoxColumn.HeaderText = "Numer produkcji";
            this.pRODUCTIONNODataGridViewTextBoxColumn.Name = "pRODUCTIONNODataGridViewTextBoxColumn";
            this.pRODUCTIONNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DetailsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 337);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DetailsInformation";
            this.Text = "Historia obsiań";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sownLogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFULLSOWNLOGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView sownLogDataGridView;
        private System.Windows.Forms.BindingSource vFULLSOWNLOGBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIONNODataGridViewTextBoxColumn;
    }
}