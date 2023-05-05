using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
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
            btnCreateNodes.TabStop = false;
            btnCreateNodes.FlatStyle = FlatStyle.Flat;
            btnCreateNodes.FlatAppearance.BorderSize = 0;
            btnAdjacentNodes.TabStop = false;
            btnAdjacentNodes.FlatStyle = FlatStyle.Flat;
            btnAdjacentNodes.FlatAppearance.BorderSize = 0;
        }
        //method to set
        public void setClear()
        {
            // set the initialization of variables to clear
            graph = picGraph.CreateGraphics();
            stopcreate = true;
            matrix = new int[50, 50];
            vertices = new string[50];
            countnodes = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCreateNodes_Click(object sender, EventArgs e)
        {
            stopcreate = false;
        }

        private bool isDrawingLine = false;
        private int edge1 = -1; // initialize to an invalid index
        private int edge2 = -1; // initialize to an invalid index

        /*private void btnAdjacentNodes_Click(object sender, EventArgs e)
        {
            picGraph.Refresh(); // Clear the existing graphics
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.RowIndex == edge1 && cell.ColumnIndex == edge2) // If this is the edge we just added
                    {
                        if (matrix[edge1, edge2] > 0) // If they are adjacent
                        {
                            // Get the coordinates of the nodes
                            string[] c1 = vertices[edge1].Split('-');
                            string[] c2 = vertices[edge2].Split('-');
                            int x1 = Convert.ToInt32(c1[0]) + 35 / 2;
                            int y1 = Convert.ToInt32(c1[1]) + 35 / 2;
                            int x2 = Convert.ToInt32(c2[0]) + 35 / 2;
                            int y2 = Convert.ToInt32(c2[1]) + 35 / 2;

                            // Draw the line
                            graph.DrawLine(new Pen(Brushes.Teal, 2), x1, y1, x2, y2);

                            // Calculate the position to display the distance
                            double distance = Convert.ToInt32(Math.Round((double)matrix[edge1, edge2], 2));
                            int a = (x1 + x2) / 2;
                            int b = (y1 + y2) / 2 - 5;

                            // Display the distance
                            graph.DrawString(distance.ToString(), new Font("Arial", 10), Brushes.MidnightBlue, a, b);
                        }
                    }
                }
            }

        }
        private void picGraph_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click the mouse at the letside
            if (e.Button == MouseButtons.Left && stopcreate != true)
            {
                Rectangle rect = new Rectangle((e.X) - (35 / 2), (e.Y) - (35 / 2), 35, 35);

                //define the locaiton of x and y coordinate and the size of the nodes that created
                graph.FillEllipse(Brushes.PaleVioletRed, rect);

                graph.DrawString(countnodes.ToString(), new Font("Arial Black", 10), Brushes.White, ((e.X) - (35 / 2)) + 10, ((e.Y) - (35 / 2)) + 11);
                //the number that will appear base in the counter if the nodes that been

                vertices[countnodes] = ((e.X) - (35 / 2)) + "-" + ((e.Y) - (35 / 2));

                //the maker of color of the nodes
                countnodes++;

                //increment another node to draw in the datagridview
                dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                dataGridView1.AutoResizeColumns();

                dataGridView1.Rows.Add();
                dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                dataGridView1.AutoResizeRows();

                //Filling every cell to 0
                setAdjacentMatrixToZero(countnodes);
                


            }
            else
            {
                stopcreate = false;
            }

        }*/

        private void btnAdjacentNodes_Click(object sender, EventArgs e)
        {
            
            if (stopcreate == true)
            {
                //set or define the adjacent of two nodes
                int edge1 = Convert.ToInt32(txtEdge1.Text);
                int edge2 = Convert.ToInt32(txtEdge2.Text);

                //split the coordinates of x, and y of the edges
                string[] c1 = vertices[edge1].Split('-');
                string[] c2 = vertices[edge2].Split('-');

                //cast it to integer and store it to another variable
                int xcoordinate1 = Convert.ToInt32(c1[0]);//coordinate of edge1
                int ycoordinate1 = Convert.ToInt32(c1[1]);//coordinate of edge1

                int xcoordinate2 = Convert.ToInt32(c2[0]);//coordinate of edge2
                int ycoordinate2 = Convert.ToInt32(c2[1]);//coordinate of edge2

                //after retrieving the x and y coordinate, we will draw a line
                graph.DrawLine(new Pen(Brushes.PowderBlue, 2), (float)(xcoordinate1 + (35 / 2)), (float)(ycoordinate1 + (35 / 2)), (float)(xcoordinate2 + (35 / 2)), (float)(ycoordinate2 + (35 / 2)));

                //calculate distance
                double x = (double)(xcoordinate2 - xcoordinate1);
                double y = (double)(ycoordinate2 - ycoordinate1);
                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                int a = (int)(xcoordinate1 + xcoordinate2) / 2;
                int b = (int)((ycoordinate1 + ycoordinate2) / 2) - 5;
                graph.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 10), Brushes.DarkSlateGray, a, b);

                //adjacent matrix(undirected graph - no arrows)
                matrix[edge1, edge2] = Convert.ToInt32(d); // the same distance
                matrix[edge2, edge1] = Convert.ToInt32(d);

                //if it is adjacent, display 1 otherwise 0
                setAdjacentMatrix(int.Parse(txtEdge1.Text), int.Parse(txtEdge2.Text));


            }
        }



        private void picGraph_MouseClick(object sender, MouseEventArgs e)
        {
            //when you click the mouse at the letside
            if (e.Button == MouseButtons.Left && stopcreate != false)
            {
                Rectangle rect = new Rectangle((e.X) - (35 / 2), (e.Y) - (35 / 2), 35, 35);

                //define the locaiton of x and y coordinate and the size of the nodes that created
                graph.FillEllipse(Brushes.PaleVioletRed, rect);

                graph.DrawString(countnodes.ToString(), new Font("Arial Black", 10), Brushes.White, ((e.X) - (35 / 2)) + 10, ((e.Y) - (35 / 2)) + 11);
                //the number that will appear base in the counter if the nodes that been

                vertices[countnodes] = ((e.X) - (35 / 2)) + "-" + ((e.Y) - (35 / 2));

                //the maker of color of the nodes
                countnodes++;

                //increment another node to draw in the datagridview
                dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                dataGridView1.AutoResizeColumns();

                dataGridView1.Rows.Add();
                dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                dataGridView1.AutoResizeRows();

                //Filling every cell to 0
                setAdjacentMatrixToZero(countnodes);


            }
            else
            {
                stopcreate = true;
            }

        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setClear();
            picGraph.Image = null;
            // Clear dataGridView1
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            //Application.Restart();
        }
        public void setAdjacentMatrix(int r, int c)
        {
            //Overwrite the specific cell that are adjacent
            dataGridView1.Rows[r].Cells[c].Value = "1";
            dataGridView1.Rows[c].Cells[r].Value = "1";

        }

        public void colornodes(int node, Brush e)
        {
            String[] s = vertices[node].Split('-');
            int x = Convert.ToInt32(s[0]);
            int y = Convert.ToInt32(s[1]);

            Rectangle react = new Rectangle(x, y, 35, 35);
            graph.FillEllipse(e, react);
            graph.DrawString(node.ToString(), new Font("Arial", 12), Brushes.White, new PointF(x + 8, y + 8));
        }


        /*public void colornodes(int node, Brush e)
        {
            String[] s = vertices[node].Split('-');
            int x, y;
            if (s.Length < 2 || !int.TryParse(s[0], out x) || !int.TryParse(s[1], out y))
            {
                // handle error case here, e.g. throw an exception or return early
                return;
            }

            Rectangle react = new Rectangle(x, y, 35, 35);
            graph.FillEllipse(e, react);
            graph.DrawString(node.ToString(), new Font("Arial", 12), Brushes.White, new PointF(x + 8, y + 8));
        }*/


        public void setAdjacentMatrixToZero(int count)
        {
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[count - 1].Cells[i].Value = "0";
                dataGridView1.Rows[i].Cells[count - 1].Value = "0";
            }
        }
        public void bfsTraversal()
        {
            int source = Convert.ToInt32(txtSource.Text); //root
            int destination = Convert.ToInt32(txtDestination.Text);
            colornodes(source, Brushes.MediumSlateBlue);
            colornodes(destination, Brushes.DarkSlateBlue);

            Queue<int> b = new Queue<int>(); //create queue
            int[] visited = new int[countnodes]; //create visited nodes
            visited[source] = 1; //mark root as visited
            b.Enqueue(source); //insert root node to the queue
            int x = source;
            Thread.Sleep(200);

            while (b.Count > 0) //loop if not empty
            {
                x = Convert.ToInt32(b.Dequeue().ToString());
                Thread.Sleep(500);
                colornodes(x, Brushes.Navy);

                //loop for your immediated neighbors of x
                for (int i = 0; i < countnodes; i++)
                {
                    Thread.Sleep(150);
                    if (matrix[x, i] != 0 && visited[i] != 1)
                        //if matrix is not equal to zero and not visited yet
                        if (!b.Contains(i))
                        {
                            b.Enqueue(i); //insert it the queue
                            visited[x] = 1; // mark x as visited

                        }
                }
                lblpath.Text += "" + x + "";
                if (x == destination)
                {
                    break;
                }
            }

        }



        public void dfsTraversal()
        {
            int source = Convert.ToInt32(txtSource.Text); //root
            int destination = Convert.ToInt32(txtDestination.Text);
            colornodes(source, Brushes.MediumSlateBlue);
            colornodes(destination, Brushes.DarkSlateBlue);

            Stack<int> s = new Stack<int>(); //create stack
            int[] visited = new int[countnodes]; //create visited nodes
            visited[source] = 1; //mark root as visited
            s.Push(source); //insert root node to the stack
            int x = source;
            Thread.Sleep(200);

            while (s.Count > 0) //loop if not empty
            {
                x = Convert.ToInt32(s.Pop().ToString());
                Thread.Sleep(500);
                colornodes(x, Brushes.Navy);

                //loop for your immediated neighbors of x
                for (int i = 0; i < countnodes; i++)
                {
                    Thread.Sleep(150);
                    if (matrix[x, i] != 0 && visited[i] != 1)
                        //if matrix is not equal to zero and not visited yet
                        if (!s.Contains(i))
                        {
                            s.Push(i); //insert it the stack
                            visited[x] = 1; // mark x as visited

                        }
                }
                lblpath1.Text += "" + x + "";
                if (x == destination)
                {
                    break;
                }
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bfsTraversal();
        }



        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdge1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dfsTraversal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
