namespace CS203
{
    partial class UCS_Form
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
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblpath4 = new System.Windows.Forms.Label();
            this.lblpath1 = new System.Windows.Forms.Label();
            this.endbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdjacentNodes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateNodes = new System.Windows.Forms.Button();
            this.uCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.LightPink;
            this.picGraph.Location = new System.Drawing.Point(17, 35);
            this.picGraph.Margin = new System.Windows.Forms.Padding(4);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(828, 783);
            this.picGraph.TabIndex = 15;
            this.picGraph.TabStop = false;
            this.picGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picGraph_MouseClick);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(334, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 27);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(133, 57);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(55, 27);
            this.comboBox4.TabIndex = 19;
            // 
            // lblpath4
            // 
            this.lblpath4.AutoSize = true;
            this.lblpath4.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblpath4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath4.Location = new System.Drawing.Point(37, 201);
            this.lblpath4.Name = "lblpath4";
            this.lblpath4.Size = new System.Drawing.Size(151, 17);
            this.lblpath4.TabIndex = 18;
            this.lblpath4.Text = "The Traversal Path is: ";
            // 
            // lblpath1
            // 
            this.lblpath1.AutoSize = true;
            this.lblpath1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblpath1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath1.Location = new System.Drawing.Point(18, 162);
            this.lblpath1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpath1.Name = "lblpath1";
            this.lblpath1.Size = new System.Drawing.Size(139, 23);
            this.lblpath1.TabIndex = 16;
            this.lblpath1.Text = "UCS Traversal";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(303, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 27);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 27);
            this.comboBox1.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.lblpath4);
            this.groupBox2.Controls.Add(this.lblpath1);
            this.groupBox2.Controls.Add(this.endbtn);
            this.groupBox2.Controls.Add(this.startbtn);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(18, 490);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 275);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traversal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 21;
            
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(413, 202);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox3.Controls.Add(this.btnCreateNodes);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(867, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 791);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
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
            // uCSToolStripMenuItem
            // 
            this.uCSToolStripMenuItem.Name = "uCSToolStripMenuItem";
            this.uCSToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.uCSToolStripMenuItem.Text = "UCS";
            this.uCSToolStripMenuItem.Click += new System.EventHandler(this.uCSToolStripMenuItem_Click);
            // 
            // algorithimToolStripMenuItem
            // 
            this.algorithimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uCSToolStripMenuItem});
            this.algorithimToolStripMenuItem.Name = "algorithimToolStripMenuItem";
            this.algorithimToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.algorithimToolStripMenuItem.Text = "Algorithm";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.closeToolStripMenuItem.Text = "Restart";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.mainMenuToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
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
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UCS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1333, 830);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCS_Form";
            this.Text = "Uniform-Cost Search";
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblpath4;
        private System.Windows.Forms.Label lblpath1;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdjacentNodes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateNodes;
        private System.Windows.Forms.ToolStripMenuItem uCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
    }
}