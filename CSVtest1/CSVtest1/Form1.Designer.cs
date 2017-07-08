namespace CSVtest1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.tbOUTPUT = new System.Windows.Forms.TextBox();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOUTPUT);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(906, 609);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(75, 23);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(825, 609);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // tbOUTPUT
            // 
            this.tbOUTPUT.Location = new System.Drawing.Point(7, 20);
            this.tbOUTPUT.Multiline = true;
            this.tbOUTPUT.Name = "tbOUTPUT";
            this.tbOUTPUT.Size = new System.Drawing.Size(955, 564);
            this.tbOUTPUT.TabIndex = 0;
            // 
            // btnLOAD
            // 
            this.btnLOAD.Location = new System.Drawing.Point(744, 609);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(75, 23);
            this.btnLOAD.TabIndex = 3;
            this.btnLOAD.Text = "LOAD";
            this.btnLOAD.UseVisualStyleBackColor = true;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 644);
            this.Controls.Add(this.btnLOAD);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOUTPUT;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnLOAD;
    }
}

