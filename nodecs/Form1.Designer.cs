namespace nodecs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            algorithmToolStripMenuItem = new ToolStripMenuItem();
            bFSToolStripMenuItem = new ToolStripMenuItem();
            dFSToolStripMenuItem = new ToolStripMenuItem();
            createNodeBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            adjacentNodeBtn = new Button();
            textBox3 = new TextBox();
            destinationBtn = new Button();
            textBox4 = new TextBox();
            srcBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, algorithmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1244, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, clearToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(128, 26);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // algorithmToolStripMenuItem
            // 
            algorithmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bFSToolStripMenuItem, dFSToolStripMenuItem });
            algorithmToolStripMenuItem.Name = "algorithmToolStripMenuItem";
            algorithmToolStripMenuItem.Size = new Size(90, 24);
            algorithmToolStripMenuItem.Text = "Algorithm";
            // 
            // bFSToolStripMenuItem
            // 
            bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            bFSToolStripMenuItem.Size = new Size(118, 26);
            bFSToolStripMenuItem.Text = "BFS";
            // 
            // dFSToolStripMenuItem
            // 
            dFSToolStripMenuItem.Name = "dFSToolStripMenuItem";
            dFSToolStripMenuItem.Size = new Size(118, 26);
            dFSToolStripMenuItem.Text = "DFS";
            // 
            // createNodeBtn
            // 
            createNodeBtn.BackColor = SystemColors.GradientInactiveCaption;
            createNodeBtn.FlatStyle = FlatStyle.Popup;
            createNodeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createNodeBtn.Location = new Point(67, 37);
            createNodeBtn.Name = "createNodeBtn";
            createNodeBtn.Size = new Size(301, 40);
            createNodeBtn.TabIndex = 1;
            createNodeBtn.Text = "Create Node";
            createNodeBtn.UseVisualStyleBackColor = false;
            createNodeBtn.Click += createNodeBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 27);
            textBox2.TabIndex = 4;
            // 
            // adjacentNodeBtn
            // 
            adjacentNodeBtn.BackColor = SystemColors.GradientInactiveCaption;
            adjacentNodeBtn.FlatStyle = FlatStyle.Popup;
            adjacentNodeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adjacentNodeBtn.Location = new Point(33, 114);
            adjacentNodeBtn.Name = "adjacentNodeBtn";
            adjacentNodeBtn.Size = new Size(300, 40);
            adjacentNodeBtn.TabIndex = 3;
            adjacentNodeBtn.Text = "Adjacent";
            adjacentNodeBtn.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // destinationBtn
            // 
            destinationBtn.BackColor = SystemColors.GradientInactiveCaption;
            destinationBtn.FlatStyle = FlatStyle.Popup;
            destinationBtn.Location = new Point(207, 45);
            destinationBtn.Name = "destinationBtn";
            destinationBtn.Size = new Size(93, 61);
            destinationBtn.TabIndex = 7;
            destinationBtn.Text = "End";
            destinationBtn.UseVisualStyleBackColor = false;
            destinationBtn.Click += destinationBtn_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // srcBtn
            // 
            srcBtn.BackColor = SystemColors.GradientInactiveCaption;
            srcBtn.FlatStyle = FlatStyle.Popup;
            srcBtn.Location = new Point(17, 45);
            srcBtn.Name = "srcBtn";
            srcBtn.Size = new Size(93, 61);
            srcBtn.TabIndex = 5;
            srcBtn.Text = "Start";
            srcBtn.UseVisualStyleBackColor = false;
            srcBtn.Click += srcBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Edge 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(232, 31);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Edge 2";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(365, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(adjacentNodeBtn);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 178);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connect Edges";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(destinationBtn);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(srcBtn);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(35, 599);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 196);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Path";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 135);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Traversal:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(createNodeBtn);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(805, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(427, 812);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Location = new Point(19, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 812);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1244, 874);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "net";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem algorithmToolStripMenuItem;
        private ToolStripMenuItem bFSToolStripMenuItem;
        private ToolStripMenuItem dFSToolStripMenuItem;
        private Button createNodeBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button adjacentNodeBtn;
        private TextBox textBox3;
        private Button destinationBtn;
        private TextBox textBox4;
        private Button srcBtn;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox3;
        private Panel panel1;
    }
}