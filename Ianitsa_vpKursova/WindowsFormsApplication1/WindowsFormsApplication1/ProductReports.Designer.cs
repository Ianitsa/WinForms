namespace WindowsFormsApplication1
{
    partial class ProductReports
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
            this.lblProd = new System.Windows.Forms.Label();
            this.lblSaleQ = new System.Windows.Forms.Label();
            this.dgv_ReportP = new System.Windows.Forms.DataGridView();
            this.txtTSaleQ = new System.Windows.Forms.TextBox();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.btnSearchP = new System.Windows.Forms.Button();
            this.kursovaSQLDataSet = new WindowsFormsApplication1.kursovaSQLDataSet();
            this.kursovaSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WindowsFormsApplication1.kursovaSQLDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(30, 35);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(82, 13);
            this.lblProd.TabIndex = 0;
            this.lblProd.Text = "Choose product";
            // 
            // lblSaleQ
            // 
            this.lblSaleQ.AutoSize = true;
            this.lblSaleQ.Location = new System.Drawing.Point(267, 298);
            this.lblSaleQ.Name = "lblSaleQ";
            this.lblSaleQ.Size = new System.Drawing.Size(101, 13);
            this.lblSaleQ.TabIndex = 1;
            this.lblSaleQ.Text = "Total sales quantity:";
            // 
            // dgv_ReportP
            // 
            this.dgv_ReportP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReportP.Location = new System.Drawing.Point(33, 75);
            this.dgv_ReportP.Name = "dgv_ReportP";
            this.dgv_ReportP.Size = new System.Drawing.Size(604, 145);
            this.dgv_ReportP.TabIndex = 2;
            // 
            // txtTSaleQ
            // 
            this.txtTSaleQ.Location = new System.Drawing.Point(393, 291);
            this.txtTSaleQ.Name = "txtTSaleQ";
            this.txtTSaleQ.Size = new System.Drawing.Size(139, 20);
            this.txtTSaleQ.TabIndex = 3;
            // 
            // cbProd
            // 
            this.cbProd.DataSource = this.productBindingSource;
            this.cbProd.DisplayMember = "Product_name";
            this.cbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(133, 32);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(121, 21);
            this.cbProd.TabIndex = 4;
            this.cbProd.ValueMember = "Product_id";
            // 
            // btnSearchP
            // 
            this.btnSearchP.Location = new System.Drawing.Point(323, 35);
            this.btnSearchP.Name = "btnSearchP";
            this.btnSearchP.Size = new System.Drawing.Size(75, 23);
            this.btnSearchP.TabIndex = 5;
            this.btnSearchP.Text = "Search";
            this.btnSearchP.UseVisualStyleBackColor = true;
            this.btnSearchP.Click += new System.EventHandler(this.btnSearchP_Click);
            // 
            // kursovaSQLDataSet
            // 
            this.kursovaSQLDataSet.DataSetName = "kursovaSQLDataSet";
            this.kursovaSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursovaSQLDataSetBindingSource
            // 
            this.kursovaSQLDataSetBindingSource.DataSource = this.kursovaSQLDataSet;
            this.kursovaSQLDataSetBindingSource.Position = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.kursovaSQLDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // ProductReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 339);
            this.Controls.Add(this.btnSearchP);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.txtTSaleQ);
            this.Controls.Add(this.dgv_ReportP);
            this.Controls.Add(this.lblSaleQ);
            this.Controls.Add(this.lblProd);
            this.Name = "ProductReports";
            this.Text = "ProductReports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductReports_FormClosing);
            this.Load += new System.EventHandler(this.ProductReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovaSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblSaleQ;
        private System.Windows.Forms.DataGridView dgv_ReportP;
        private System.Windows.Forms.TextBox txtTSaleQ;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.BindingSource kursovaSQLDataSetBindingSource;
        private kursovaSQLDataSet kursovaSQLDataSet;
        private System.Windows.Forms.Button btnSearchP;
        private System.Windows.Forms.BindingSource productBindingSource;
        private kursovaSQLDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}