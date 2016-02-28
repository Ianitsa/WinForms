namespace WindowsFormsApplication1
{
    partial class NewSales
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
            this.btnExitNS = new System.Windows.Forms.Button();
            this.btnNS = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.txtCCountry = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCLNo = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovaSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovaSQLDataSet = new WindowsFormsApplication1.kursovaSQLDataSet();
            this.productTableAdapter = new WindowsFormsApplication1.kursovaSQLDataSetTableAdapters.ProductTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNS
            // 
            this.btnExitNS.Location = new System.Drawing.Point(49, 304);
            this.btnExitNS.Name = "btnExitNS";
            this.btnExitNS.Size = new System.Drawing.Size(75, 23);
            this.btnExitNS.TabIndex = 0;
            this.btnExitNS.Text = "Exit";
            this.btnExitNS.UseVisualStyleBackColor = true;
            this.btnExitNS.Click += new System.EventHandler(this.btnExitNS_Click);
            // 
            // btnNS
            // 
            this.btnNS.Location = new System.Drawing.Point(338, 304);
            this.btnNS.Name = "btnNS";
            this.btnNS.Size = new System.Drawing.Size(75, 23);
            this.btnNS.TabIndex = 1;
            this.btnNS.Text = "Save";
            this.btnNS.UseVisualStyleBackColor = true;
            this.btnNS.Click += new System.EventHandler(this.btnNS_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(356, 90);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(72, 13);
            this.ProductName.TabIndex = 3;
            this.ProductName.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(446, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(446, 123);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtQuantity, "\"Моля, попълнете стойност!");
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            this.txtQuantity.Validated += new System.EventHandler(this.cbProduct_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data of order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SheepedDate";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(47, 192);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 38;
            this.lblCountry.Text = "Country";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(151, 260);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCAddress.TabIndex = 37;
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(151, 224);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(100, 20);
            this.txtCCity.TabIndex = 36;
            // 
            // txtCCountry
            // 
            this.txtCCountry.Location = new System.Drawing.Point(151, 192);
            this.txtCCountry.Name = "txtCCountry";
            this.txtCCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCCountry.TabIndex = 35;
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(151, 157);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 34;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(151, 123);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 33;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(151, 90);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(71, 20);
            this.txtCNo.TabIndex = 32;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(47, 224);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(45, 263);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Address";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(46, 160);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 29;
            this.lblLName.Text = "Last Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Name";
            // 
            // lblCLNo
            // 
            this.lblCLNo.AutoSize = true;
            this.lblCLNo.Location = new System.Drawing.Point(46, 90);
            this.lblCLNo.Name = "lblCLNo";
            this.lblCLNo.Size = new System.Drawing.Size(65, 13);
            this.lblCLNo.TabIndex = 27;
            this.lblCLNo.Text = "Customer №";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(362, 245);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 39;
            this.lblSum.Text = "Sum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(446, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(456, 238);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 42;
            // 
            // cbProduct
            // 
            this.cbProduct.DataSource = this.productBindingSource;
            this.cbProduct.DisplayMember = "Product_name";
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(446, 89);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 43;
            this.toolTip1.SetToolTip(this.cbProduct, "\"Моля, изберете стойност!");
            this.cbProduct.ValueMember = "Product_id";
            this.cbProduct.BindingContextChanged += new System.EventHandler(this.cbProduct_BindingContextChanged);
            this.cbProduct.Validating += new System.ComponentModel.CancelEventHandler(this.cbProduct_Validating);
            this.cbProduct.Validated += new System.EventHandler(this.cbProduct_Validated);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.kursovaSQLDataSetBindingSource;
            // 
            // kursovaSQLDataSetBindingSource
            // 
            this.kursovaSQLDataSetBindingSource.DataSource = this.kursovaSQLDataSet;
            this.kursovaSQLDataSetBindingSource.Position = 0;
            // 
            // kursovaSQLDataSet
            // 
            this.kursovaSQLDataSet.DataSetName = "kursovaSQLDataSet";
            this.kursovaSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(162, 34);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(71, 20);
            this.txtOrderID.TabIndex = 45;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(57, 37);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 44;
            this.lblOrderID.Text = "Order №";
            // 
            // NewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 357);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCCity);
            this.Controls.Add(this.txtCCountry);
            this.Controls.Add(this.txtCLName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCNo);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCLNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.btnNS);
            this.Controls.Add(this.btnExitNS);
            this.Name = "NewSales";
            this.Text = "NewSales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSales_FormClosing);
            this.Load += new System.EventHandler(this.NewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNS;
        private System.Windows.Forms.Button btnNS;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.TextBox txtCCountry;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCNo;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCLNo;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.BindingSource kursovaSQLDataSetBindingSource;
        private kursovaSQLDataSet kursovaSQLDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private kursovaSQLDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
    }
}