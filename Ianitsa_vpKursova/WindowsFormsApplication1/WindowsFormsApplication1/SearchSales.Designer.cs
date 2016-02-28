namespace WindowsFormsApplication1
{
    partial class SearchSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSales));
            this.btnExitLS = new System.Windows.Forms.Button();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.dgv_SearchS = new System.Windows.Forms.DataGridView();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.ts_Sales = new System.Windows.Forms.ToolStrip();
            this.tsbtnRedaction = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchS)).BeginInit();
            this.ts_Sales.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitLS
            // 
            this.btnExitLS.Location = new System.Drawing.Point(112, 301);
            this.btnExitLS.Name = "btnExitLS";
            this.btnExitLS.Size = new System.Drawing.Size(75, 23);
            this.btnExitLS.TabIndex = 0;
            this.btnExitLS.Text = "Exit";
            this.btnExitLS.UseVisualStyleBackColor = true;
            this.btnExitLS.Click += new System.EventHandler(this.btnExitLS_Click);
            // 
            // btnSearchS
            // 
            this.btnSearchS.Location = new System.Drawing.Point(329, 301);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(75, 23);
            this.btnSearchS.TabIndex = 1;
            this.btnSearchS.Text = "Search";
            this.btnSearchS.UseVisualStyleBackColor = true;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // dgv_SearchS
            // 
            this.dgv_SearchS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchS.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_SearchS.Location = new System.Drawing.Point(254, 61);
            this.dgv_SearchS.Name = "dgv_SearchS";
            this.dgv_SearchS.Size = new System.Drawing.Size(403, 201);
            this.dgv_SearchS.TabIndex = 2;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(41, 61);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(47, 13);
            this.lblOrderNo.TabIndex = 3;
            this.lblOrderNo.Text = "Order №";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(41, 131);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(58, 13);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "Last Name";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(131, 61);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNo.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(131, 131);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 8;
            // 
            // ts_Sales
            // 
            this.ts_Sales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRedaction,
            this.tsbtnDel,
            this.tsbtnSave});
            this.ts_Sales.Location = new System.Drawing.Point(0, 24);
            this.ts_Sales.Name = "ts_Sales";
            this.ts_Sales.Size = new System.Drawing.Size(669, 25);
            this.ts_Sales.TabIndex = 34;
            this.ts_Sales.Text = "Add";
            // 
            // tsbtnRedaction
            // 
            this.tsbtnRedaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRedaction.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRedaction.Image")));
            this.tsbtnRedaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRedaction.Name = "tsbtnRedaction";
            this.tsbtnRedaction.Size = new System.Drawing.Size(64, 22);
            this.tsbtnRedaction.Text = "Redaction";
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDel.Image")));
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(44, 22);
            this.tsbtnDel.Text = "Delete";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(35, 22);
            this.tsbtnSave.Text = "Save";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.updateToolStripMenuItem.Text = "Redaction";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redactionToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.newToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // redactionToolStripMenuItem
            // 
            this.redactionToolStripMenuItem.Name = "redactionToolStripMenuItem";
            this.redactionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redactionToolStripMenuItem.Text = "Redaction";
            this.redactionToolStripMenuItem.Click += new System.EventHandler(this.redactionToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // SearchSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 358);
            this.Controls.Add(this.ts_Sales);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtCLName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.dgv_SearchS);
            this.Controls.Add(this.btnSearchS);
            this.Controls.Add(this.btnExitLS);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchSales";
            this.Text = "SearchSales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListOfSales_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchS)).EndInit();
            this.ts_Sales.ResumeLayout(false);
            this.ts_Sales.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitLS;
        private System.Windows.Forms.Button btnSearchS;
        private System.Windows.Forms.DataGridView dgv_SearchS;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.ToolStrip ts_Sales;
        private System.Windows.Forms.ToolStripButton tsbtnRedaction;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}