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
            this.menuBFS_btn = new System.Windows.Forms.Button();
            this.bfsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBFS_btn
            // 
            this.menuBFS_btn.BackColor = System.Drawing.Color.Plum;
            this.menuBFS_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBFS_btn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBFS_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuBFS_btn.Location = new System.Drawing.Point(122, 79);
            this.menuBFS_btn.Name = "menuBFS_btn";
            this.menuBFS_btn.Size = new System.Drawing.Size(235, 75);
            this.menuBFS_btn.TabIndex = 0;
            this.menuBFS_btn.Text = "DFS";
            this.menuBFS_btn.UseVisualStyleBackColor = false;
            this.menuBFS_btn.Click += new System.EventHandler(this.menuStartBtn_Click);
            // 
            // bfsBtn
            // 
            this.bfsBtn.BackColor = System.Drawing.Color.Plum;
            this.bfsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bfsBtn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.bfsBtn.Location = new System.Drawing.Point(122, 160);
            this.bfsBtn.Name = "bfsBtn";
            this.bfsBtn.Size = new System.Drawing.Size(235, 75);
            this.bfsBtn.TabIndex = 1;
            this.bfsBtn.Text = "BFS";
            this.bfsBtn.UseVisualStyleBackColor = false;
            this.bfsBtn.Click += new System.EventHandler(this.bfsBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(476, 344);
            this.Controls.Add(this.bfsBtn);
            this.Controls.Add(this.menuBFS_btn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBFS_btn;
        private System.Windows.Forms.Button bfsBtn;
    }
}