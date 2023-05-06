namespace CS203
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
            this.btnCreateNodes = new System.Windows.Forms.Button();
            this.btnAdjacentNodes = new System.Windows.Forms.Button();
            this.txtEdge1 = new System.Windows.Forms.TextBox();
            this.txtEdge2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpath1 = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.endbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNodes
            // 
            this.btnCreateNodes.BackColor = System.Drawing.Color.Plum;
            this.btnCreateNodes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNodes.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNodes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCreateNodes.Location = new System.Drawing.Point(40, 22);
            this.btnCreateNodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateNodes.Name = "btnCreateNodes";
            this.btnCreateNodes.Size = new System.Drawing.Size(366, 55);
            this.btnCreateNodes.TabIndex = 0;
            this.btnCreateNodes.Text = "Create Nodes";
            this.btnCreateNodes.UseVisualStyleBackColor = false;
            this.btnCreateNodes.Click += new System.EventHandler(this.btnCreateNodes_Click);
            // 
            // btnAdjacentNodes
            // 
            this.btnAdjacentNodes.BackColor = System.Drawing.Color.Plum;
            this.btnAdjacentNodes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdjacentNodes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjacentNodes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAdjacentNodes.Location = new System.Drawing.Point(22, 98);
            this.btnAdjacentNodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdjacentNodes.Name = "btnAdjacentNodes";
            this.btnAdjacentNodes.Size = new System.Drawing.Size(366, 55);
            this.btnAdjacentNodes.TabIndex = 1;
            this.btnAdjacentNodes.Text = "Adjacent Nodes";
            this.btnAdjacentNodes.UseVisualStyleBackColor = false;
            this.btnAdjacentNodes.Click += new System.EventHandler(this.btnAdjacentNodes_Click);
            // 
            // txtEdge1
            // 
            this.txtEdge1.BackColor = System.Drawing.SystemColors.Control;
            this.txtEdge1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdge1.Location = new System.Drawing.Point(22, 53);
            this.txtEdge1.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdge1.Name = "txtEdge1";
            this.txtEdge1.Size = new System.Drawing.Size(85, 24);
            this.txtEdge1.TabIndex = 2;
            // 
            // txtEdge2
            // 
            this.txtEdge2.BackColor = System.Drawing.SystemColors.Control;
            this.txtEdge2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdge2.Location = new System.Drawing.Point(303, 53);
            this.txtEdge2.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdge2.Name = "txtEdge2";
            this.txtEdge2.Size = new System.Drawing.Size(85, 24);
            this.txtEdge2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEdge1);
            this.groupBox1.Controls.Add(this.txtEdge2);
            this.groupBox1.Controls.Add(this.btnAdjacentNodes);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(18, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edge 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edge 1";
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.LightPink;
            this.picGraph.Location = new System.Drawing.Point(22, 39);
            this.picGraph.Margin = new System.Windows.Forms.Padding(4);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(828, 783);
            this.picGraph.TabIndex = 7;
            this.picGraph.TabStop = false;
            this.picGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picGraph_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.algorithimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1337, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // algorithimToolStripMenuItem
            // 
            this.algorithimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bFSToolStripMenuItem,
            this.dFSToolStripMenuItem});
            this.algorithimToolStripMenuItem.Name = "algorithimToolStripMenuItem";
            this.algorithimToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.algorithimToolStripMenuItem.Text = "Algorithm";
            // 
            // bFSToolStripMenuItem
            // 
            this.bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            this.bFSToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.bFSToolStripMenuItem.Text = "BFS";
            this.bFSToolStripMenuItem.Click += new System.EventHandler(this.bFSToolStripMenuItem_Click);
            // 
            // dFSToolStripMenuItem
            // 
            this.dFSToolStripMenuItem.Name = "dFSToolStripMenuItem";
            this.dFSToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.dFSToolStripMenuItem.Text = "DFS";
            this.dFSToolStripMenuItem.Click += new System.EventHandler(this.dFSToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(413, 307);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox2.Controls.Add(this.lblpath1);
            this.groupBox2.Controls.Add(this.lblpath);
            this.groupBox2.Controls.Add(this.endbtn);
            this.groupBox2.Controls.Add(this.startbtn);
            this.groupBox2.Controls.Add(this.txtDestination);
            this.groupBox2.Controls.Add(this.txtSource);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(18, 595);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 170);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traversal";
            // 
            // lblpath1
            // 
            this.lblpath1.AutoSize = true;
            this.lblpath1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpath1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath1.Location = new System.Drawing.Point(219, 126);
            this.lblpath1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpath1.Name = "lblpath1";
            this.lblpath1.Size = new System.Drawing.Size(113, 17);
            this.lblpath1.TabIndex = 16;
            this.lblpath1.Text = "DFS Traversal:   ";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(19, 126);
            this.lblpath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(111, 17);
            this.lblpath.TabIndex = 15;
            this.lblpath.Text = "BFS Traversal:   ";
            // 
            // endbtn
            // 
            this.endbtn.BackColor = System.Drawing.Color.Plum;
            this.endbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.endbtn.Location = new System.Drawing.Point(222, 25);
            this.endbtn.Margin = new System.Windows.Forms.Padding(4);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(104, 82);
            this.endbtn.TabIndex = 14;
            this.endbtn.Text = "End";
            this.endbtn.UseVisualStyleBackColor = false;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Plum;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.startbtn.Location = new System.Drawing.Point(22, 25);
            this.startbtn.Margin = new System.Windows.Forms.Padding(4);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(104, 83);
            this.startbtn.TabIndex = 13;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = false;
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.SystemColors.Control;
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestination.Location = new System.Drawing.Point(334, 55);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(54, 24);
            this.txtDestination.TabIndex = 12;
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.Control;
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Location = new System.Drawing.Point(134, 55);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(54, 25);
            this.txtSource.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox3.Controls.Add(this.btnCreateNodes);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(872, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 791);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1337, 847);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Breadth-First Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNodes;
        private System.Windows.Forms.Button btnAdjacentNodes;
        private System.Windows.Forms.TextBox txtEdge1;
        private System.Windows.Forms.TextBox txtEdge2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.ToolStripMenuItem algorithimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem dFSToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpath1;
    }
}

