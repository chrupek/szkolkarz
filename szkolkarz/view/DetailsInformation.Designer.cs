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
            this.vFULLSOWNLOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sownLogDataGridView = new System.Windows.Forms.DataGridView();
            this.tAPEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cERTIFICATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vFULLSOWNLOGBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sownLogDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vFULLSOWNLOGBindingSource
            // 
            this.vFULLSOWNLOGBindingSource.DataSource = typeof(szkolkarz.V_FULL_SOWN_LOG);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.sownLogDataGridView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(444, 313);
            this.mainPanel.TabIndex = 0;
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
            this.aRTICLEDataGridViewTextBoxColumn,
            this.cERTIFICATEDataGridViewTextBoxColumn});
            this.sownLogDataGridView.DataSource = this.vFULLSOWNLOGBindingSource;
            this.sownLogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sownLogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.sownLogDataGridView.Name = "sownLogDataGridView";
            this.sownLogDataGridView.ReadOnly = true;
            this.sownLogDataGridView.Size = new System.Drawing.Size(444, 313);
            this.sownLogDataGridView.TabIndex = 1;
            // 
            // tAPEIDDataGridViewTextBoxColumn
            // 
            this.tAPEIDDataGridViewTextBoxColumn.DataPropertyName = "TAPE_ID";
            this.tAPEIDDataGridViewTextBoxColumn.HeaderText = "Nr taśmy";
            this.tAPEIDDataGridViewTextBoxColumn.Name = "tAPEIDDataGridViewTextBoxColumn";
            this.tAPEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yEARDataGridViewTextBoxColumn
            // 
            this.yEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR";
            this.yEARDataGridViewTextBoxColumn.HeaderText = "Rok";
            this.yEARDataGridViewTextBoxColumn.Name = "yEARDataGridViewTextBoxColumn";
            this.yEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aRTICLEDataGridViewTextBoxColumn
            // 
            this.aRTICLEDataGridViewTextBoxColumn.DataPropertyName = "ARTICLE";
            this.aRTICLEDataGridViewTextBoxColumn.HeaderText = "Artykuł";
            this.aRTICLEDataGridViewTextBoxColumn.Name = "aRTICLEDataGridViewTextBoxColumn";
            this.aRTICLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cERTIFICATEDataGridViewTextBoxColumn
            // 
            this.cERTIFICATEDataGridViewTextBoxColumn.DataPropertyName = "CERTIFICATE";
            this.cERTIFICATEDataGridViewTextBoxColumn.HeaderText = "Świadectwo";
            this.cERTIFICATEDataGridViewTextBoxColumn.Name = "cERTIFICATEDataGridViewTextBoxColumn";
            this.cERTIFICATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eksportToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // eksportToolStripMenuItem
            // 
            this.eksportToolStripMenuItem.Name = "eksportToolStripMenuItem";
            this.eksportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eksportToolStripMenuItem.Text = "Eksport";
            this.eksportToolStripMenuItem.Click += new System.EventHandler(this.eksportToolStripMenuItem_Click);
            // 
            // DetailsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 337);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DetailsInformation";
            this.Text = "Historia obsiań";
            ((System.ComponentModel.ISupportInitialize)(this.vFULLSOWNLOGBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sownLogDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIONNODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vFULLSOWNLOGBindingSource;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView sownLogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRTICLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cERTIFICATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksportToolStripMenuItem;
    }
}