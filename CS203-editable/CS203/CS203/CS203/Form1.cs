using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS203
{
    public partial class Form1 : Form
    {
        bool stopcreate;
        int[,] matrix; //serves as the adjacent matrix
        int countnodes; //counter
        string[] vertices; //nodes
        Graphics graph;
        public Form1()
        {
            InitializeComponent();
            setClear();
        }
        //method to set
        public void setClear() 
        {
            // set the initialization of variables to clear
            graph = picGraph.CreateGraphics();
            stopcreate = false;
            matrix = new int[50, 50];
            vertices = new string[50];
            countnodes = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdjacentNodes_Click(object sender, EventArgs e)
        {
            if (stopcreate == true) 
            {
                //set or define the adjacent of two nodes
                int edge1 = Convert.ToInt32(txtEdge1.Text);
                int edge2 = Convert.ToInt32(txtEdge2.Text);

                string[] c1 = vertices[edge1].Split('-');
                string[] c2 = vertices[edge2].Split('-');

                int xcoordinate1 = Convert.ToInt32(c1[0]);
                _ = Convert.ToInt32(c1[1]);

                int xcoordinate2 = Convert.ToInt32(c2[0]);
                int ycoordinate2 = Convert.ToInt32(c2[1]);
                int ycoordinate1;
                //after recieving the x and y we will draw a line
                graph.DrawLine(new Pen(Brushes.Blue, 5), (xcoordinate1 + 12), (ycoordinate1 = 12), (xcoordinate2 + 12), (float)(ycoordinate2 + 12));


                //calculate distance 
                double x =(double)(xcoordinate2 - xcoordinate1);
                double y = (double)(ycoordinate2 - ycoordinate1);
                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                int a = (int)(xcoordinate1 + xcoordinate2) / 2;
                int b = (int)((ycoordinate1 + ycoordinate2) / 2) - 5;
                graph.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 12), Brushes.Maroon, a, b);

                matrix[edge1,edge2] = Convert.ToInt32(d);
                matrix[edge2, edge1] = Convert.ToInt32(d);

            }   
        }

        private void btnCreateNodes_Click(object sender, EventArgs e)
        {
            stopcreate = false;
        }

        private void picGraph_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click the mouse at the letside
            if (e.Button == MouseButtons.Left && stopcreate != true)
            {
                Rectangle rect = new Rectangle(e.X, e.Y, 35, 35);

                //define the locaiton of x and y coordinate and the size of the nodes that created
                graph.FillEllipse(Brushes.DarkRed, rect);

                
                //the maker of color of the nodes
                
                graph.DrawString(countnodes.ToString(), new Font("Arial Black", 10), Brushes.White, e.X + 12, e.Y + 12);
                //the number that will apper based one the counter of the node
                vertices[countnodes] = e.X + "-" + e.Y;

                countnodes++;


                dataGridView1.Columns.Add("",(countnodes-1).ToString());
                dataGridView1.AutoResizeColumns();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[countnodes-1].HeaderCell.Value = (countnodes - 1).ToString();
                dataGridView1.AutoResizeRows();
            }
            else 
            {
                stopcreate = true;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setClear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int totalRowHeight = dataGridView1.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                totalRowHeight += row.Height;

            dataGridView1.Height = totalRowHeight;
            this.Height = dataGridView1.Height + 100;
        }
    }
}
