namespace CS203
{
    partial class Menu
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
            this.menuDFS_btn = new System.Windows.Forms.Button();
            this.menuBfs_btn = new System.Windows.Forms.Button();
            this.menuUcs_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuDFS_btn
            // 
            this.menuDFS_btn.BackColor = System.Drawing.Color.Plum;
            this.menuDFS_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuDFS_btn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDFS_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuDFS_btn.Location = new System.Drawing.Point(122, 129);
            this.menuDFS_btn.Name = "menuDFS_btn";
            this.menuDFS_btn.Size = new System.Drawing.Size(235, 75);
            this.menuDFS_btn.TabIndex = 0;
            this.menuDFS_btn.Text = "DFS";
            this.menuDFS_btn.UseVisualStyleBackColor = false;
            this.menuDFS_btn.Click += new System.EventHandler(this.menuDFS_btn_Click);
            // 
            // menuBfs_btn
            // 
            this.menuBfs_btn.BackColor = System.Drawing.Color.Plum;
            this.menuBfs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBfs_btn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.menuBfs_btn.Location = new System.Drawing.Point(122, 48);
            this.menuBfs_btn.Name = "menuBfs_btn";
            this.menuBfs_btn.Size = new System.Drawing.Size(235, 75);
            this.menuBfs_btn.TabIndex = 1;
            this.menuBfs_btn.Text = "BFS";
            this.menuBfs_btn.UseVisualStyleBackColor = false;
            this.menuBfs_btn.Click += new System.EventHandler(this.menuBfs_btn_Click);
            // 
            // menuUcs_btn
            // 
            this.menuUcs_btn.BackColor = System.Drawing.Color.Plum;
            this.menuUcs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuUcs_btn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUcs_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuUcs_btn.Location = new System.Drawing.Point(122, 210);
            this.menuUcs_btn.Name = "menuUcs_btn";
            this.menuUcs_btn.Size = new System.Drawing.Size(235, 75);
            this.menuUcs_btn.TabIndex = 2;
            this.menuUcs_btn.Text = "UCS";
            this.menuUcs_btn.UseVisualStyleBackColor = false;
            this.menuUcs_btn.Click += new System.EventHandler(this.menuUcs_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(476, 344);
            this.Controls.Add(this.menuUcs_btn);
            this.Controls.Add(this.menuBfs_btn);
            this.Controls.Add(this.menuDFS_btn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuDFS_btn;
        private System.Windows.Forms.Button menuBfs_btn;
        private System.Windows.Forms.Button menuUcs_btn;
    }
}