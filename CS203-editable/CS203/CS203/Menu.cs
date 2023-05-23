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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStartBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            DFS_Form form1 = new DFS_Form();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();
        }

        private void bfsBtn_Click(object sender, EventArgs e)
        {
            BFS_Form form1 = new BFS_Form();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();
        }
    }
}
