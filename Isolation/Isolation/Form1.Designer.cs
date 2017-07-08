namespace Isolation
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
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.labelGameArea = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelWinner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Location = new System.Drawing.Point(12, 9);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(59, 13);
            this.labelPlayerOne.TabIndex = 0;
            this.labelPlayerOne.Text = "Player One";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Location = new System.Drawing.Point(12, 34);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(60, 13);
            this.labelPlayerTwo.TabIndex = 1;
            this.labelPlayerTwo.Text = "Player Two";
            // 
            // labelGameArea
            // 
            this.labelGameArea.AutoSize = true;
            this.labelGameArea.Location = new System.Drawing.Point(15, 65);
            this.labelGameArea.Name = "labelGameArea";
            this.labelGameArea.Size = new System.Drawing.Size(79, 13);
            this.labelGameArea.TabIndex = 2;
            this.labelGameArea.Text = "labelGameArea";
            this.labelGameArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(15, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test Move Player One";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Location = new System.Drawing.Point(482, 9);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(41, 13);
            this.labelWinner.TabIndex = 5;
            this.labelWinner.Text = "Winner";
            this.labelWinner.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 346);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGameArea);
            this.Controls.Add(this.labelPlayerTwo);
            this.Controls.Add(this.labelPlayerOne);
            this.Name = "Form1";
            this.Text = "Isolation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerOne;
        private System.Windows.Forms.Label labelPlayerTwo;
        private System.Windows.Forms.Label labelGameArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWinner;
    }
}

