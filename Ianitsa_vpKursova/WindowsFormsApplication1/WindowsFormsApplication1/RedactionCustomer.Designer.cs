namespace WindowsFormsApplication1
{
    partial class RedactionCustomer
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
            this.BtnUpdateLC = new System.Windows.Forms.Button();
            this.btnExitLC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.txtCCountry = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUpdateLC
            // 
            this.BtnUpdateLC.Location = new System.Drawing.Point(185, 255);
            this.BtnUpdateLC.Name = "BtnUpdateLC";
            this.BtnUpdateLC.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateLC.TabIndex = 42;
            this.BtnUpdateLC.Text = "Update";
            this.BtnUpdateLC.UseVisualStyleBackColor = true;
            this.BtnUpdateLC.Click += new System.EventHandler(this.BtnUpdateLC_Click);
            // 
            // btnExitLC
            // 
            this.btnExitLC.Location = new System.Drawing.Point(67, 255);
            this.btnExitLC.Name = "btnExitLC";
            this.btnExitLC.Size = new System.Drawing.Size(75, 23);
            this.btnExitLC.TabIndex = 41;
            this.btnExitLC.Text = "Exit";
            this.btnExitLC.UseVisualStyleBackColor = true;
            this.btnExitLC.Click += new System.EventHandler(this.btnExitLC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Country";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(189, 183);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCAddress.TabIndex = 39;
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(189, 147);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(100, 20);
            this.txtCCity.TabIndex = 38;
            // 
            // txtCCountry
            // 
            this.txtCCountry.Location = new System.Drawing.Point(189, 115);
            this.txtCCountry.Name = "txtCCountry";
            this.txtCCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCCountry.TabIndex = 37;
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(189, 80);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 36;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(189, 46);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 35;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(189, 13);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(71, 20);
            this.txtCNo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer №";
            // 
            // btnDelC
            // 
            this.btnDelC.Location = new System.Drawing.Point(289, 255);
            this.btnDelC.Name = "btnDelC";
            this.btnDelC.Size = new System.Drawing.Size(75, 22);
            this.btnDelC.TabIndex = 43;
            this.btnDelC.Text = "Delete";
            this.btnDelC.UseVisualStyleBackColor = true;
            this.btnDelC.Click += new System.EventHandler(this.btnDelC_Click);
            // 
            // RedactionCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 313);
            this.Controls.Add(this.btnDelC);
            this.Controls.Add(this.BtnUpdateLC);
            this.Controls.Add(this.btnExitLC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCCity);
            this.Controls.Add(this.txtCCountry);
            this.Controls.Add(this.txtCLName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RedactionCustomer";
            this.Text = "RedactionCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RedactionCustomer_FormClosing);
            this.Load += new System.EventHandler(this.RedactionCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateLC;
        private System.Windows.Forms.Button btnExitLC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.TextBox txtCCountry;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelC;

    }
}