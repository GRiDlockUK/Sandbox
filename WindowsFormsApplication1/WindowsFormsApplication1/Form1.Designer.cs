namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode51,
            treeNode52,
            treeNode53});
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tmrHeartbeat = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkHeartbeat = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(642, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(15, 271);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tmrHeartbeat
            // 
            this.tmrHeartbeat.Interval = 1000;
            this.tmrHeartbeat.Tick += new System.EventHandler(this.tmrHeartbeat_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Location = new System.Drawing.Point(537, 12);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 253);
            this.txtStatus.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(96, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkHeartbeat
            // 
            this.chkHeartbeat.AutoSize = true;
            this.chkHeartbeat.Location = new System.Drawing.Point(537, 275);
            this.chkHeartbeat.Name = "chkHeartbeat";
            this.chkHeartbeat.Size = new System.Drawing.Size(102, 17);
            this.chkHeartbeat.TabIndex = 5;
            this.chkHeartbeat.Text = "Timer Heartbeat";
            this.chkHeartbeat.UseVisualStyleBackColor = true;
            this.chkHeartbeat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 12);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "Node1";
            treeNode37.Text = "Node1";
            treeNode38.Name = "Node2";
            treeNode38.Text = "Node2";
            treeNode39.Name = "Node0";
            treeNode39.Text = "Node0";
            treeNode40.Name = "Node4";
            treeNode40.Text = "Node4";
            treeNode41.Name = "Node3";
            treeNode41.Text = "Node3";
            treeNode42.Name = "Node6";
            treeNode42.Text = "Node6";
            treeNode43.Name = "Node7";
            treeNode43.Text = "Node7";
            treeNode44.Name = "Node8";
            treeNode44.Text = "Node8";
            treeNode45.Name = "Node5";
            treeNode45.Text = "Node5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode41,
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(255, 253);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(276, 12);
            this.treeView2.Name = "treeView2";
            treeNode46.Name = "Node1";
            treeNode46.Text = "Node1";
            treeNode47.Name = "Node2";
            treeNode47.Text = "Node2";
            treeNode48.Name = "Node0";
            treeNode48.Text = "Node0";
            treeNode49.Name = "Node4";
            treeNode49.Text = "Node4";
            treeNode50.Name = "Node3";
            treeNode50.Text = "Node3";
            treeNode51.Name = "Node6";
            treeNode51.Text = "Node6";
            treeNode52.Name = "Node7";
            treeNode52.Text = "Node7";
            treeNode53.Name = "Node8";
            treeNode53.Text = "Node8";
            treeNode54.Name = "Node5";
            treeNode54.Text = "Node5";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode50,
            treeNode54});
            this.treeView2.Size = new System.Drawing.Size(255, 253);
            this.treeView2.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(178, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 302);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chkHeartbeat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Timer tmrHeartbeat;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkHeartbeat;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

