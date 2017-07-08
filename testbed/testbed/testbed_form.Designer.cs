namespace testbed
{
    partial class testbed_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEbayTime = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNRE1 = new System.Windows.Forms.Button();
            this.btnWebservCCY = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnWebservCCY);
            this.panel1.Controls.Add(this.btnNRE1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEbayTime);
            this.panel1.Location = new System.Drawing.Point(657, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 469);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Functions";
            // 
            // btnEbayTime
            // 
            this.btnEbayTime.Location = new System.Drawing.Point(19, 36);
            this.btnEbayTime.Name = "btnEbayTime";
            this.btnEbayTime.Size = new System.Drawing.Size(159, 23);
            this.btnEbayTime.TabIndex = 0;
            this.btnEbayTime.Text = "EBAY API - Time";
            this.btnEbayTime.UseVisualStyleBackColor = true;
            this.btnEbayTime.Click += new System.EventHandler(this.btnEbayTime_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 420);
            this.textBox1.TabIndex = 2;
            // 
            // btnNRE1
            // 
            this.btnNRE1.Location = new System.Drawing.Point(19, 65);
            this.btnNRE1.Name = "btnNRE1";
            this.btnNRE1.Size = new System.Drawing.Size(159, 23);
            this.btnNRE1.TabIndex = 2;
            this.btnNRE1.Text = "NRE API - TBC";
            this.btnNRE1.UseVisualStyleBackColor = true;
            this.btnNRE1.Click += new System.EventHandler(this.btnNRE1_Click);
            // 
            // btnWebservCCY
            // 
            this.btnWebservCCY.Location = new System.Drawing.Point(19, 94);
            this.btnWebservCCY.Name = "btnWebservCCY";
            this.btnWebservCCY.Size = new System.Drawing.Size(159, 23);
            this.btnWebservCCY.TabIndex = 3;
            this.btnWebservCCY.Text = "WEBSERVICES API - CCY";
            this.btnWebservCCY.UseVisualStyleBackColor = true;
            this.btnWebservCCY.Click += new System.EventHandler(this.btnWebservCCY_Click);
            // 
            // testbed_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "testbed_form";
            this.Text = "testbed_form";
            this.Load += new System.EventHandler(this.testbed_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEbayTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNRE1;
        private System.Windows.Forms.Button btnWebservCCY;
    }
}