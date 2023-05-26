using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS203
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuDFS_btn_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            DFS_Form form1 = new DFS_Form();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();

        }
        private void menuBfs_btn_Click(object sender, EventArgs e)
        {
            BFS_Form form1 = new BFS_Form();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();

        }
        private void menuUcs_btn_Click(object sender, EventArgs e)
        {
            UCS_Form form1 = new UCS_Form();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();

        }            
    }
}
