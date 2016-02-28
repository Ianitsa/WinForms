namespace WindowsFormsApplication1
{
    partial class RedactionSales
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnExitNS = new System.Windows.Forms.Button();
            this.cbProdN = new System.Windows.Forms.ComboBox();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kursovaSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovaSQLDataSet = new WindowsFormsApplication1.kursovaSQLDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.btnDelS = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WindowsFormsApplication1.kursovaSQLDataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(28, 171);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 54;
            this.lblCountry.Text = "Country";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(132, 239);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCAddress.TabIndex = 53;
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(132, 203);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(100, 20);
            this.txtCCity.TabIndex = 52;
            // 
            // txtCCountry
            // 
            this.txtCCountry.Location = new System.Drawing.Point(132, 171);
            this.txtCCountry.Name = "txtCCountry";
            this.txtCCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCCountry.TabIndex = 51;
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(132, 136);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 50;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(132, 102);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 49;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(132, 69);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(71, 20);
            this.txtCNo.TabIndex = 48;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 203);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 47;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 242);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Address";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(27, 139);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 45;
            this.lblLName.Text = "Last Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name";
            // 
            // lblCLNo
            // 
            this.lblCLNo.AutoSize = true;
            this.lblCLNo.Location = new System.Drawing.Point(27, 69);
            this.lblCLNo.Name = "lblCLNo";
            this.lblCLNo.Size = new System.Drawing.Size(65, 13);
            this.lblCLNo.TabIndex = 43;
            this.lblCLNo.Text = "Customer №";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(132, 22);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(71, 20);
            this.txtOrderID.TabIndex = 42;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(27, 25);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 41;
            this.lblOrderID.Text = "Order №";
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(176, 283);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateS.TabIndex = 40;
            this.btnUpdateS.Text = "Update";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnExitNS
            // 
            this.btnExitNS.Location = new System.Drawing.Point(30, 283);
            this.btnExitNS.Name = "btnExitNS";
            this.btnExitNS.Size = new System.Drawing.Size(75, 23);
            this.btnExitNS.TabIndex = 39;
            this.btnExitNS.Text = "Exit";
            this.btnExitNS.UseVisualStyleBackColor = true;
            // 
            // cbProdN
            // 
            this.cbProdN.DataSource = this.productBindingSource2;
            this.cbProdN.DisplayMember = "Product_name";
            this.cbProdN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdN.FormattingEnabled = true;
            this.cbProdN.Location = new System.Drawing.Point(344, 80);
            this.cbProdN.Name = "cbProdN";
            this.cbProdN.Size = new System.Drawing.Size(121, 21);
            this.cbProdN.TabIndex = 66;
            this.cbProdN.ValueMember = "Product_id";
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.kursovaSQLDataSetBindingSource;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 65;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(257, 183);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 62;
            this.lblSum.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "SheepedDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Data of order";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(344, 114);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 59;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(344, 148);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Quantity";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(254, 81);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(72, 13);
            this.ProductName.TabIndex = 55;
            this.ProductName.Text = "ProductName";
            // 
            // btnDelS
            // 
            this.btnDelS.Location = new System.Drawing.Point(325, 283);
            this.btnDelS.Name = "btnDelS";
            this.btnDelS.Size = new System.Drawing.Size(75, 23);
            this.btnDelS.TabIndex = 67;
            this.btnDelS.Text = "Delete Sale";
            this.btnDelS.UseVisualStyleBackColor = true;
            this.btnDelS.Click += new System.EventHandler(this.btnDelS_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.kursovaSQLDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.kursovaSQLDataSetBindingSource;
            // 
            // RedactionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 471);
            this.Controls.Add(this.btnDelS);
            this.Controls.Add(this.cbProdN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName);
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
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnUpdateS);
            this.Controls.Add(this.btnExitNS);
            this.Name = "RedactionSales";
            this.Text = "RedactionSales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedactionSales_FormClosing);
            this.Load += new System.EventHandler(this.RedactionSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnExitNS;
        private System.Windows.Forms.ComboBox cbProdN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Button btnDelS;
        private System.Windows.Forms.BindingSource kursovaSQLDataSetBindingSource;
        private kursovaSQLDataSet kursovaSQLDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private kursovaSQLDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource2;
    }
}