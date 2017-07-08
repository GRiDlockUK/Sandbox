namespace Compare2List
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxWant = new System.Windows.Forms.TextBox();
            this.textBoxSwap = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWantList = new System.Windows.Forms.Label();
            this.labelSwapList = new System.Windows.Forms.Label();
            this.labelSwaps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.Location = new System.Drawing.Point(297, 408);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calc";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxWant
            // 
            this.textBoxWant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWant.Location = new System.Drawing.Point(16, 29);
            this.textBoxWant.Multiline = true;
            this.textBoxWant.Name = "textBoxWant";
            this.textBoxWant.Size = new System.Drawing.Size(437, 161);
            this.textBoxWant.TabIndex = 1;
            this.textBoxWant.Text = "1, 2, 3, 5 ";
            // 
            // textBoxSwap
            // 
            this.textBoxSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSwap.Location = new System.Drawing.Point(16, 220);
            this.textBoxSwap.Multiline = true;
            this.textBoxSwap.Name = "textBoxSwap";
            this.textBoxSwap.Size = new System.Drawing.Size(437, 86);
            this.textBoxSwap.TabIndex = 2;
            this.textBoxSwap.Text = "2, 3, 4, 6 ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(16, 340);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(437, 54);
            this.textBoxResult.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(378, 408);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWantList
            // 
            this.labelWantList.AutoSize = true;
            this.labelWantList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWantList.Location = new System.Drawing.Point(13, 10);
            this.labelWantList.Name = "labelWantList";
            this.labelWantList.Size = new System.Drawing.Size(80, 16);
            this.labelWantList.TabIndex = 6;
            this.labelWantList.Text = "WANT LIST";
            // 
            // labelSwapList
            // 
            this.labelSwapList.AutoSize = true;
            this.labelSwapList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwapList.Location = new System.Drawing.Point(13, 204);
            this.labelSwapList.Name = "labelSwapList";
            this.labelSwapList.Size = new System.Drawing.Size(79, 16);
            this.labelSwapList.TabIndex = 7;
            this.labelSwapList.Text = "SWAP LIST";
            // 
            // labelSwaps
            // 
            this.labelSwaps.AutoSize = true;
            this.labelSwaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwaps.Location = new System.Drawing.Point(12, 321);
            this.labelSwaps.Name = "labelSwaps";
            this.labelSwaps.Size = new System.Drawing.Size(57, 16);
            this.labelSwaps.TabIndex = 8;
            this.labelSwaps.Text = "SWAPS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 443);
            this.Controls.Add(this.labelSwaps);
            this.Controls.Add(this.labelSwapList);
            this.Controls.Add(this.labelWantList);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSwap);
            this.Controls.Add(this.textBoxWant);
            this.Controls.Add(this.buttonCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Panini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxWant;
        private System.Windows.Forms.TextBox textBoxSwap;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWantList;
        private System.Windows.Forms.Label labelSwapList;
        private System.Windows.Forms.Label labelSwaps;
    }
}

