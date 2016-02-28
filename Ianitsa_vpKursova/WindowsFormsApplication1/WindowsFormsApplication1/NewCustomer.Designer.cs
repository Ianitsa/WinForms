namespace WindowsFormsApplication1
{
    partial class NewCustomer
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.txtCCountry = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitNC = new System.Windows.Forms.Button();
            this.btnSaveNC = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Country";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(196, 243);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(178, 20);
            this.txtCAddress.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtCAddress, "Моля, попълнете стойност");
            this.txtCAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtCAddress_Validating);
            this.txtCAddress.Validated += new System.EventHandler(this.txtCAddress_Validated);
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(196, 207);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(100, 20);
            this.txtCCity.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtCCity, "Моля, попълнете стойност");
            this.txtCCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCCity_Validating);
            this.txtCCity.Validated += new System.EventHandler(this.txtCCity_Validated);
            // 
            // txtCCountry
            // 
            this.txtCCountry.Location = new System.Drawing.Point(196, 175);
            this.txtCCountry.Name = "txtCCountry";
            this.txtCCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCCountry.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtCCountry, "Моля, попълнете стойност");
            this.txtCCountry.Validating += new System.ComponentModel.CancelEventHandler(this.txtCCountry_Validating);
            this.txtCCountry.Validated += new System.EventHandler(this.txtCCountry_Validated);
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(196, 140);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(166, 20);
            this.txtCLName.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtCLName, "Моля, попълнете стойност");
            this.txtCLName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCLName_Validating);
            this.txtCLName.Validated += new System.EventHandler(this.txtCLName_Validated);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(196, 106);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(166, 20);
            this.txtCName.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtCName, "Моля, попълнете стойност");
            this.txtCName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCName_Validating);
            this.txtCName.Validated += new System.EventHandler(this.txtCName_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // btnExitNC
            // 
            this.btnExitNC.Location = new System.Drawing.Point(41, 292);
            this.btnExitNC.Name = "btnExitNC";
            this.btnExitNC.Size = new System.Drawing.Size(75, 23);
            this.btnExitNC.TabIndex = 27;
            this.btnExitNC.Text = "Exit";
            this.btnExitNC.UseVisualStyleBackColor = true;
            this.btnExitNC.Click += new System.EventHandler(this.btnExitNC_Click);
            // 
            // btnSaveNC
            // 
            this.btnSaveNC.Location = new System.Drawing.Point(175, 292);
            this.btnSaveNC.Name = "btnSaveNC";
            this.btnSaveNC.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNC.TabIndex = 28;
            this.btnSaveNC.Text = "Save";
            this.btnSaveNC.UseVisualStyleBackColor = true;
            this.btnSaveNC.Click += new System.EventHandler(this.btnSaveNC_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 337);
            this.Controls.Add(this.btnSaveNC);
            this.Controls.Add(this.btnExitNC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCCity);
            this.Controls.Add(this.txtCCountry);
            this.Controls.Add(this.txtCLName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewCustomer_FormClosing);
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.TextBox txtCCountry;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitNC;
        private System.Windows.Forms.Button btnSaveNC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}