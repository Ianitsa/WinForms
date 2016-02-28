namespace WindowsFormsApplication1
{
    partial class SearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomer));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitLC = new System.Windows.Forms.Button();
            this.dgv_SearchCustomer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSearchC = new System.Windows.Forms.Button();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Customer = new System.Windows.Forms.ToolStrip();
            this.tsbtnRedaction = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCustomer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ts_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer №";
            // 
            // btnExitLC
            // 
            this.btnExitLC.Location = new System.Drawing.Point(43, 305);
            this.btnExitLC.Name = "btnExitLC";
            this.btnExitLC.Size = new System.Drawing.Size(75, 23);
            this.btnExitLC.TabIndex = 27;
            this.btnExitLC.Text = "Exit";
            this.btnExitLC.UseVisualStyleBackColor = true;
            this.btnExitLC.Click += new System.EventHandler(this.btnExitLC_Click);
            // 
            // dgv_SearchCustomer
            // 
            this.dgv_SearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchCustomer.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_SearchCustomer.Location = new System.Drawing.Point(258, 63);
            this.dgv_SearchCustomer.Name = "dgv_SearchCustomer";
            this.dgv_SearchCustomer.Size = new System.Drawing.Size(365, 211);
            this.dgv_SearchCustomer.TabIndex = 29;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redactionToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.newToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // redactionToolStripMenuItem
            // 
            this.redactionToolStripMenuItem.Name = "redactionToolStripMenuItem";
            this.redactionToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.redactionToolStripMenuItem.Text = "Redaction";
            this.redactionToolStripMenuItem.Click += new System.EventHandler(this.redactionToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // BtnSearchC
            // 
            this.BtnSearchC.Location = new System.Drawing.Point(246, 305);
            this.BtnSearchC.Name = "BtnSearchC";
            this.BtnSearchC.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchC.TabIndex = 28;
            this.BtnSearchC.Text = "Search";
            this.BtnSearchC.UseVisualStyleBackColor = true;
            this.BtnSearchC.Click += new System.EventHandler(this.BtnSearchC_Click);
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(125, 139);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 32;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(125, 105);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 31;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(125, 72);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(71, 20);
            this.txtCNo.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 36;
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
            // ts_Customer
            // 
            this.ts_Customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRedaction,
            this.tsbtnDel,
            this.tsbtnSave});
            this.ts_Customer.Location = new System.Drawing.Point(0, 24);
            this.ts_Customer.Name = "ts_Customer";
            this.ts_Customer.Size = new System.Drawing.Size(623, 25);
            this.ts_Customer.TabIndex = 37;
            this.ts_Customer.Text = "Add";
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
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 352);
            this.Controls.Add(this.ts_Customer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtCLName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCNo);
            this.Controls.Add(this.dgv_SearchCustomer);
            this.Controls.Add(this.BtnSearchC);
            this.Controls.Add(this.btnExitLC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchCustomer";
            this.Text = "SearchCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListCustomer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchCustomer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ts_Customer.ResumeLayout(false);
            this.ts_Customer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitLC;
        private System.Windows.Forms.DataGridView dgv_SearchCustomer;
        private System.Windows.Forms.Button BtnSearchC;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_Customer;
        private System.Windows.Forms.ToolStripButton tsbtnRedaction;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}