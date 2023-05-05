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
            button1 = new Button();
            textBox4 = new TextBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, algorithmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 28);
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
            createNodeBtn.BackColor = SystemColors.InactiveBorder;
            createNodeBtn.FlatStyle = FlatStyle.Popup;
            createNodeBtn.Location = new Point(831, 79);
            createNodeBtn.Name = "createNodeBtn";
            createNodeBtn.Size = new Size(105, 40);
            createNodeBtn.TabIndex = 1;
            createNodeBtn.Text = "Create Node";
            createNodeBtn.UseVisualStyleBackColor = false;
            createNodeBtn.Click += createNodeBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(759, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(759, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 27);
            textBox2.TabIndex = 4;
            // 
            // adjacentNodeBtn
            // 
            adjacentNodeBtn.BackColor = SystemColors.InactiveBorder;
            adjacentNodeBtn.FlatStyle = FlatStyle.Popup;
            adjacentNodeBtn.Location = new Point(831, 136);
            adjacentNodeBtn.Name = "adjacentNodeBtn";
            adjacentNodeBtn.Size = new Size(105, 40);
            adjacentNodeBtn.TabIndex = 3;
            adjacentNodeBtn.Text = "Adjacent";
            adjacentNodeBtn.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(759, 566);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 27);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(831, 559);
            button1.Name = "button1";
            button1.Size = new Size(105, 40);
            button1.TabIndex = 7;
            button1.Text = "Adjacent";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(759, 509);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 27);
            textBox4.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveBorder;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(831, 502);
            button2.Name = "button2";
            button2.Size = new Size(105, 40);
            button2.TabIndex = 5;
            button2.Text = "Create Node";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(969, 652);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(adjacentNodeBtn);
            Controls.Add(textBox1);
            Controls.Add(createNodeBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "net";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button button1;
        private TextBox textBox4;
        private Button button2;
    }
}