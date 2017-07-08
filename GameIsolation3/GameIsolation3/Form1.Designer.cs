namespace GameIsolation3
{
    partial class Isolation
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
            this.labelAction = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.labelAction.ForeColor = System.Drawing.Color.White;
            this.labelAction.Location = new System.Drawing.Point(10, 10);
            this.labelAction.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(137, 30);
            this.labelAction.TabIndex = 4;
            this.labelAction.Text = "labelAction";
            // 
            // buttonNew
            // 
            this.buttonNew.Enabled = false;
            this.buttonNew.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.buttonNew.Location = new System.Drawing.Point(15, 53);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(150, 40);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New Game";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Visible = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // Isolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 491);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelAction);
            this.Name = "Isolation";
            this.Text = "Isolation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Button buttonNew;
    }
}

