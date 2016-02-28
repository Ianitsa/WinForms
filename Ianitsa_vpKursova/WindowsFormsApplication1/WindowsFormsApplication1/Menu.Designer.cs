namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStripMenuItem,
            this.klientToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpsToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(598, 24);
            this.menuStripMenu.TabIndex = 1;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.failToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // klientToolStripMenuItem
            // 
            this.klientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCustomersToolStripMenuItem,
            this.newCustomerToolStripMenuItem});
            this.klientToolStripMenuItem.Name = "klientToolStripMenuItem";
            this.klientToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.klientToolStripMenuItem.Text = "Customers";
            // 
            // listOfCustomersToolStripMenuItem
            // 
            this.listOfCustomersToolStripMenuItem.Name = "listOfCustomersToolStripMenuItem";
            this.listOfCustomersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listOfCustomersToolStripMenuItem.Text = "Search Customers";
            this.listOfCustomersToolStripMenuItem.Click += new System.EventHandler(this.listOfCustomersToolStripMenuItem_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfSalesToolStripMenuItem,
            this.newSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // listOfSalesToolStripMenuItem
            // 
            this.listOfSalesToolStripMenuItem.Name = "listOfSalesToolStripMenuItem";
            this.listOfSalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listOfSalesToolStripMenuItem.Text = "Search Sales";
            this.listOfSalesToolStripMenuItem.Click += new System.EventHandler(this.listOfSalesToolStripMenuItem_Click);
            // 
            // newSalesToolStripMenuItem
            // 
            this.newSalesToolStripMenuItem.Name = "newSalesToolStripMenuItem";
            this.newSalesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newSalesToolStripMenuItem.Text = "New Sales";
            this.newSalesToolStripMenuItem.Click += new System.EventHandler(this.newSalesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // productsReportToolStripMenuItem
            // 
            this.productsReportToolStripMenuItem.Name = "productsReportToolStripMenuItem";
            this.productsReportToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productsReportToolStripMenuItem.Text = "ProductsReport";
            this.productsReportToolStripMenuItem.Click += new System.EventHandler(this.productsReportToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.windowsToolStripMenuItem.Text = "Products";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalOrderToolStripMenuItem,
            this.verticalOrdersToolStripMenuItem,
            this.cascadeOrdersToolStripMenuItem,
            this.closeAllWindowsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Windows";
            // 
            // horizontalOrderToolStripMenuItem
            // 
            this.horizontalOrderToolStripMenuItem.Name = "horizontalOrderToolStripMenuItem";
            this.horizontalOrderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.horizontalOrderToolStripMenuItem.Text = "Horizontal Order";
            this.horizontalOrderToolStripMenuItem.Click += new System.EventHandler(this.horizontalOrderToolStripMenuItem_Click);
            // 
            // verticalOrdersToolStripMenuItem
            // 
            this.verticalOrdersToolStripMenuItem.Name = "verticalOrdersToolStripMenuItem";
            this.verticalOrdersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verticalOrdersToolStripMenuItem.Text = "Vertical Orders";
            this.verticalOrdersToolStripMenuItem.Click += new System.EventHandler(this.verticalOrdersToolStripMenuItem_Click);
            // 
            // cascadeOrdersToolStripMenuItem
            // 
            this.cascadeOrdersToolStripMenuItem.Name = "cascadeOrdersToolStripMenuItem";
            this.cascadeOrdersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cascadeOrdersToolStripMenuItem.Text = "Cascade Orders";
            this.cascadeOrdersToolStripMenuItem.Click += new System.EventHandler(this.cascadeOrdersToolStripMenuItem_Click);
            // 
            // closeAllWindowsToolStripMenuItem
            // 
            this.closeAllWindowsToolStripMenuItem.Name = "closeAllWindowsToolStripMenuItem";
            this.closeAllWindowsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeAllWindowsToolStripMenuItem.Text = "Close all windows";
            this.closeAllWindowsToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindowsToolStripMenuItem_Click);
            // 
            // helpsToolStripMenuItem
            // 
            this.helpsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forProductsToolStripMenuItem});
            this.helpsToolStripMenuItem.Name = "helpsToolStripMenuItem";
            this.helpsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpsToolStripMenuItem.Text = "Helps";
            // 
            // forProductsToolStripMenuItem
            // 
            this.forProductsToolStripMenuItem.Name = "forProductsToolStripMenuItem";
            this.forProductsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.forProductsToolStripMenuItem.Text = "For Products";
            this.forProductsToolStripMenuItem.Click += new System.EventHandler(this.forProductsToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 374);
            this.Controls.Add(this.menuStripMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsReportToolStripMenuItem;
    }
}