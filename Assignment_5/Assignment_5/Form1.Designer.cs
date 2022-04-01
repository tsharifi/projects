
namespace Assignment_5
{
    partial class Form1
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.AdressLbl = new System.Windows.Forms.Label();
            this.TelephoneNumLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNumLbl = new System.Windows.Forms.Label();
            this.CumulativePurchaseLbl = new System.Windows.Forms.Label();
            this.OnMailListCbx = new System.Windows.Forms.CheckBox();
            this.AddressTbx = new System.Windows.Forms.TextBox();
            this.TelephonNumTbx = new System.Windows.Forms.TextBox();
            this.CustomerNumTbx = new System.Windows.Forms.TextBox();
            this.CumulativePurchaseTbx = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SummaryTbx = new System.Windows.Forms.TextBox();
            this.NameErrorLbl = new System.Windows.Forms.Label();
            this.AddressErrorLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TelephoneErrorLbl = new System.Windows.Forms.Label();
            this.CustomerNumErrorLbl = new System.Windows.Forms.Label();
            this.CumulativePurchaseErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(104, 51);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(151, 44);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(111, 20);
            this.NameTbx.TabIndex = 1;
            // 
            // AdressLbl
            // 
            this.AdressLbl.AutoSize = true;
            this.AdressLbl.Location = new System.Drawing.Point(94, 103);
            this.AdressLbl.Name = "AdressLbl";
            this.AdressLbl.Size = new System.Drawing.Size(45, 13);
            this.AdressLbl.TabIndex = 3;
            this.AdressLbl.Text = "Address";
            // 
            // TelephoneNumLbl
            // 
            this.TelephoneNumLbl.AutoSize = true;
            this.TelephoneNumLbl.Location = new System.Drawing.Point(47, 157);
            this.TelephoneNumLbl.Name = "TelephoneNumLbl";
            this.TelephoneNumLbl.Size = new System.Drawing.Size(98, 13);
            this.TelephoneNumLbl.TabIndex = 6;
            this.TelephoneNumLbl.Text = "Telephone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // CustomerNumLbl
            // 
            this.CustomerNumLbl.AutoSize = true;
            this.CustomerNumLbl.Location = new System.Drawing.Point(54, 207);
            this.CustomerNumLbl.Name = "CustomerNumLbl";
            this.CustomerNumLbl.Size = new System.Drawing.Size(91, 13);
            this.CustomerNumLbl.TabIndex = 8;
            this.CustomerNumLbl.Text = "Customer Number";
            this.CustomerNumLbl.Click += new System.EventHandler(this.CustomerNumLbl_Click);
            // 
            // CumulativePurchaseLbl
            // 
            this.CumulativePurchaseLbl.AutoSize = true;
            this.CumulativePurchaseLbl.Location = new System.Drawing.Point(38, 262);
            this.CumulativePurchaseLbl.Name = "CumulativePurchaseLbl";
            this.CumulativePurchaseLbl.Size = new System.Drawing.Size(107, 13);
            this.CumulativePurchaseLbl.TabIndex = 9;
            this.CumulativePurchaseLbl.Text = "Cumulative Purchase";
            // 
            // OnMailListCbx
            // 
            this.OnMailListCbx.AutoSize = true;
            this.OnMailListCbx.Checked = true;
            this.OnMailListCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnMailListCbx.Location = new System.Drawing.Point(97, 318);
            this.OnMailListCbx.Name = "OnMailListCbx";
            this.OnMailListCbx.Size = new System.Drawing.Size(124, 17);
            this.OnMailListCbx.TabIndex = 10;
            this.OnMailListCbx.Text = "Enroll On Mailing List";
            this.OnMailListCbx.UseVisualStyleBackColor = true;
            // 
            // AddressTbx
            // 
            this.AddressTbx.Location = new System.Drawing.Point(151, 96);
            this.AddressTbx.Name = "AddressTbx";
            this.AddressTbx.Size = new System.Drawing.Size(111, 20);
            this.AddressTbx.TabIndex = 11;
            this.AddressTbx.TextChanged += new System.EventHandler(this.AdressTbx_TextChanged);
            // 
            // TelephonNumTbx
            // 
            this.TelephonNumTbx.Location = new System.Drawing.Point(151, 150);
            this.TelephonNumTbx.Name = "TelephonNumTbx";
            this.TelephonNumTbx.Size = new System.Drawing.Size(111, 20);
            this.TelephonNumTbx.TabIndex = 12;
            this.TelephonNumTbx.TextChanged += new System.EventHandler(this.TelephonNumTbx_TextChanged);
            // 
            // CustomerNumTbx
            // 
            this.CustomerNumTbx.Location = new System.Drawing.Point(151, 204);
            this.CustomerNumTbx.Name = "CustomerNumTbx";
            this.CustomerNumTbx.Size = new System.Drawing.Size(111, 20);
            this.CustomerNumTbx.TabIndex = 13;
            // 
            // CumulativePurchaseTbx
            // 
            this.CumulativePurchaseTbx.Location = new System.Drawing.Point(151, 255);
            this.CumulativePurchaseTbx.Name = "CumulativePurchaseTbx";
            this.CumulativePurchaseTbx.Size = new System.Drawing.Size(111, 20);
            this.CumulativePurchaseTbx.TabIndex = 14;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(97, 341);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(124, 48);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add or Update Customer";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SummaryTbx
            // 
            this.SummaryTbx.Location = new System.Drawing.Point(25, 395);
            this.SummaryTbx.Multiline = true;
            this.SummaryTbx.Name = "SummaryTbx";
            this.SummaryTbx.Size = new System.Drawing.Size(260, 139);
            this.SummaryTbx.TabIndex = 16;
            // 
            // NameErrorLbl
            // 
            this.NameErrorLbl.AutoSize = true;
            this.NameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLbl.Location = new System.Drawing.Point(148, 28);
            this.NameErrorLbl.Name = "NameErrorLbl";
            this.NameErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.NameErrorLbl.TabIndex = 17;
            // 
            // AddressErrorLbl
            // 
            this.AddressErrorLbl.AutoSize = true;
            this.AddressErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.AddressErrorLbl.Location = new System.Drawing.Point(148, 80);
            this.AddressErrorLbl.Name = "AddressErrorLbl";
            this.AddressErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.AddressErrorLbl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(148, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // TelephoneErrorLbl
            // 
            this.TelephoneErrorLbl.AutoSize = true;
            this.TelephoneErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.TelephoneErrorLbl.Location = new System.Drawing.Point(148, 134);
            this.TelephoneErrorLbl.Name = "TelephoneErrorLbl";
            this.TelephoneErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.TelephoneErrorLbl.TabIndex = 20;
            // 
            // CustomerNumErrorLbl
            // 
            this.CustomerNumErrorLbl.AutoSize = true;
            this.CustomerNumErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.CustomerNumErrorLbl.Location = new System.Drawing.Point(148, 188);
            this.CustomerNumErrorLbl.Name = "CustomerNumErrorLbl";
            this.CustomerNumErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.CustomerNumErrorLbl.TabIndex = 21;
            // 
            // CumulativePurchaseErrorLbl
            // 
            this.CumulativePurchaseErrorLbl.AutoSize = true;
            this.CumulativePurchaseErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.CumulativePurchaseErrorLbl.Location = new System.Drawing.Point(149, 240);
            this.CumulativePurchaseErrorLbl.Name = "CumulativePurchaseErrorLbl";
            this.CumulativePurchaseErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.CumulativePurchaseErrorLbl.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 572);
            this.Controls.Add(this.CumulativePurchaseErrorLbl);
            this.Controls.Add(this.CustomerNumErrorLbl);
            this.Controls.Add(this.TelephoneErrorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressErrorLbl);
            this.Controls.Add(this.NameErrorLbl);
            this.Controls.Add(this.SummaryTbx);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CumulativePurchaseTbx);
            this.Controls.Add(this.CustomerNumTbx);
            this.Controls.Add(this.TelephonNumTbx);
            this.Controls.Add(this.AddressTbx);
            this.Controls.Add(this.OnMailListCbx);
            this.Controls.Add(this.CumulativePurchaseLbl);
            this.Controls.Add(this.CustomerNumLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelephoneNumLbl);
            this.Controls.Add(this.AdressLbl);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form1";
            this.Text = "Customer Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.Label AdressLbl;
        private System.Windows.Forms.Label TelephoneNumLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerNumLbl;
        private System.Windows.Forms.Label CumulativePurchaseLbl;
        private System.Windows.Forms.CheckBox OnMailListCbx;
        private System.Windows.Forms.TextBox AddressTbx;
        private System.Windows.Forms.TextBox TelephonNumTbx;
        private System.Windows.Forms.TextBox CustomerNumTbx;
        private System.Windows.Forms.TextBox CumulativePurchaseTbx;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox SummaryTbx;
        private System.Windows.Forms.Label NameErrorLbl;
        private System.Windows.Forms.Label AddressErrorLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TelephoneErrorLbl;
        private System.Windows.Forms.Label CustomerNumErrorLbl;
        private System.Windows.Forms.Label CumulativePurchaseErrorLbl;
    }
}

