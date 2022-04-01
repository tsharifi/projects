
namespace Assignment4
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
            this.numRandLBL = new System.Windows.Forms.Label();
            this.numRandTBX = new System.Windows.Forms.TextBox();
            this.numRandBTN = new System.Windows.Forms.Button();
            this.writeBTN = new System.Windows.Forms.Button();
            this.ReadBTN = new System.Windows.Forms.Button();
            this.dataTBX = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.totalRandNumLBL = new System.Windows.Forms.Label();
            this.SumLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numRandLBL
            // 
            this.numRandLBL.AutoSize = true;
            this.numRandLBL.Location = new System.Drawing.Point(206, 23);
            this.numRandLBL.Name = "numRandLBL";
            this.numRandLBL.Size = new System.Drawing.Size(350, 20);
            this.numRandLBL.TabIndex = 0;
            this.numRandLBL.Text = "Enter Number of Random Number File Can Hold";
            // 
            // numRandTBX
            // 
            this.numRandTBX.Location = new System.Drawing.Point(210, 55);
            this.numRandTBX.Name = "numRandTBX";
            this.numRandTBX.Size = new System.Drawing.Size(346, 26);
            this.numRandTBX.TabIndex = 1;
            this.numRandTBX.TextChanged += new System.EventHandler(this.numRandTBX_TextChanged);
            // 
            // numRandBTN
            // 
            this.numRandBTN.Location = new System.Drawing.Point(210, 99);
            this.numRandBTN.Name = "numRandBTN";
            this.numRandBTN.Size = new System.Drawing.Size(346, 52);
            this.numRandBTN.TabIndex = 2;
            this.numRandBTN.Text = "Enter";
            this.numRandBTN.UseVisualStyleBackColor = true;
            this.numRandBTN.Click += new System.EventHandler(this.numRandBTN_Click);
            // 
            // writeBTN
            // 
            this.writeBTN.Location = new System.Drawing.Point(23, 243);
            this.writeBTN.Name = "writeBTN";
            this.writeBTN.Size = new System.Drawing.Size(196, 69);
            this.writeBTN.TabIndex = 3;
            this.writeBTN.Text = "Write Random Numbers";
            this.writeBTN.UseVisualStyleBackColor = true;
            this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
            // 
            // ReadBTN
            // 
            this.ReadBTN.Location = new System.Drawing.Point(23, 380);
            this.ReadBTN.Name = "ReadBTN";
            this.ReadBTN.Size = new System.Drawing.Size(196, 73);
            this.ReadBTN.TabIndex = 4;
            this.ReadBTN.Text = "Read Random Number";
            this.ReadBTN.UseVisualStyleBackColor = true;
            this.ReadBTN.Click += new System.EventHandler(this.ReadBTN_Click);
            // 
            // dataTBX
            // 
            this.dataTBX.Location = new System.Drawing.Point(293, 243);
            this.dataTBX.Multiline = true;
            this.dataTBX.Name = "dataTBX";
            this.dataTBX.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTBX.Size = new System.Drawing.Size(436, 275);
            this.dataTBX.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // totalRandNumLBL
            // 
            this.totalRandNumLBL.AutoSize = true;
            this.totalRandNumLBL.Location = new System.Drawing.Point(92, 570);
            this.totalRandNumLBL.Name = "totalRandNumLBL";
            this.totalRandNumLBL.Size = new System.Drawing.Size(51, 20);
            this.totalRandNumLBL.TabIndex = 6;
            this.totalRandNumLBL.Text = "label1";
            this.totalRandNumLBL.Click += new System.EventHandler(this.totalRandNumLBL_Click);
            // 
            // SumLBL
            // 
            this.SumLBL.AutoSize = true;
            this.SumLBL.Location = new System.Drawing.Point(92, 612);
            this.SumLBL.Name = "SumLBL";
            this.SumLBL.Size = new System.Drawing.Size(51, 20);
            this.SumLBL.TabIndex = 7;
            this.SumLBL.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.SumLBL);
            this.Controls.Add(this.totalRandNumLBL);
            this.Controls.Add(this.dataTBX);
            this.Controls.Add(this.ReadBTN);
            this.Controls.Add(this.writeBTN);
            this.Controls.Add(this.numRandBTN);
            this.Controls.Add(this.numRandTBX);
            this.Controls.Add(this.numRandLBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numRandLBL;
        private System.Windows.Forms.TextBox numRandTBX;
        private System.Windows.Forms.Button numRandBTN;
        private System.Windows.Forms.Button writeBTN;
        private System.Windows.Forms.Button ReadBTN;
        private System.Windows.Forms.TextBox dataTBX;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label totalRandNumLBL;
        private System.Windows.Forms.Label SumLBL;
    }
}

