using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CS203
{
    public partial class MainMenu : Form
    {
        BFS bfs = new BFS();
        DFS dfs = new DFS();
        UCS ucs = new UCS();

   
        public MainMenu()
        {
            InitializeComponent();           
        }


        private void loading_Screen() 
        {
            panel2.Visible = false;
            lblLoading.Visible = true;
            progressBar1.Visible = true;
            
            progressBar1.Maximum= 100;
            progressBar1.Minimum= 0;

            for (int i = 0; i<=100; i++) 
            {
                Application.DoEvents();
                progressBar1.Value =+ i;
                Thread.Sleep(25);
            }
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loading_Screen();
            ucs.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
           loading_Screen();    
           bfs.Visible = true;
           this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loading_Screen();    
            dfs.Visible = true;
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DFS algorithm in the data structure is a recursive algorithm to search all the vertices of a tree data structure or a graph. The depth-first search (DFS) algorithm starts with the initial node of graph G and goes deeper until we find the goal node or the node with no children.\r\n\r\nBecause of the recursive nature, stack data structure can be used to implement the DFS algorithm. The process of implementing the DFS is similar to the BFS algorithm.", "DFS (Depth First Search) algorithm");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            panel1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are sure you want to EXIT ?", "EXIT.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        public void panel1Visible(bool r)
        {
           this.panel1.Visible = r;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.FlatStyle = FlatStyle.Standard;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.FlatStyle = FlatStyle.Flat;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.FlatStyle = FlatStyle.Standard;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.FlatStyle = FlatStyle.Flat;
        }


        // bfs button
        private void btnBFS_MouseEnter(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Breadth First Search";
            travinfo.Hide();
            bfsinfo.Show();
        }
        private void btnBFS_MouseLeave(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Traversal";
            bfsinfo.Hide();
            travinfo.Show();
        }
    
        // dfs button
        private void btnDFS_MouseEnter(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Depth First Search";
            travinfo.Hide();
            dfsinfo.Show();
        }
        private void btnDFS_MouseLeave(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Traversal";
            dfsinfo.Hide();
            travinfo.Show();
        }
        // ucs button 
        private void button9_MouseEnter(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Uniform Cost Search";
            travinfo.Hide();
            ucsinfo.Show();
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            infoGroupbox.Text = "Traversals";
            ucsinfo.Hide();
            travinfo.Show();
        }

        private void travinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
