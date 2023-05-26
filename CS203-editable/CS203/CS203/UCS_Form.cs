using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace CS203
{
    public partial class UCS_Form : Form
    {

        bool stopcreate;
        int[,] matrix; //serves as the adjacent matrix
        int countnodes; //counter
        string[] vertices; //nodes
        Graphics graph;
        //ComboBox item;

        public UCS_Form()
        {
            InitializeComponent();
        }

        public void setClear()
        {
            // set the initialization of variables to clear
            graph = picGraph.CreateGraphics();
            stopcreate = true;
            matrix = new int[50, 50];
            vertices = new string[50];
            countnodes = 0;


        }

        private void btnCreateNodes_Click(object sender, EventArgs e)
        {
            stopcreate = false;
        }

        private bool isDrawingLine = false;
        private int edge1 = -1; // initialize to an invalid index
        private int edge2 = -1; // initialize to an invalid index

        private void btnAdjacentNodes_Click(object sender, EventArgs e)
        {

            if (stopcreate == true)
            {
                //set or define the adjacent of two nodes
                int edge1 = Convert.ToInt32(comboBox1.Text);
                int edge2 = Convert.ToInt32(comboBox2.Text);

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
                setAdjacentMatrix(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));


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

                comboBox1.Items.Add((countnodes - 1).ToString());
                comboBox2.Items.Add((countnodes - 1).ToString());
                comboBox3.Items.Add((countnodes - 1).ToString());
                comboBox4.Items.Add((countnodes - 1).ToString());

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
            lblpath4.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
        }
        public void setAdjacentMatrix(int edge1, int edge2)
        {
            //Overwrite the specific cell that are adjacent
            for (int row = 0; row < countnodes; row++)
            {
                for (int col = 0; col < countnodes; col++)
                {
                    if (row == edge1 && edge2 == col)
                    {
                        dataGridView1.Rows[edge1].Cells[edge2].Value = 1;
                        dataGridView1.Rows[edge2].Cells[edge1].Value = 1;
                    }
                }
            }

        }
        public void setAdjacentMatrixToZero(int countNode)
        {
            for (int i = 0; i < countNode; i++)
            {
                for (int j = 0; j < countNode; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
        }

        private void uCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucsTraversal();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize a save dialog box with a .txt file extension 
            SaveFileDialog sd = new SaveFileDialog(); //initialize the save dialog
            sd.Filter = " Text Document(.txt)|.txt"; //file extension

            // Check if the user selected a file and clicked OK
            if (sd.ShowDialog() == DialogResult.OK)
            {
                // Open a StreamWriter to write to the selected 
                StreamWriter sw = new StreamWriter(sd.FileName, true);
                String nodes = "";



                // Loop through the vertices
                for (int i = 0; i < countnodes; i++)
                {
                    // Append the current vertex and its label to 
                    nodes = i + "-" + vertices[i];
                    // Loop through the vertices again
                    for (int j = 0; j < countnodes; j++)
                    {
                        // If there is an edge between the current vertex and the current 
                        if (matrix[i, j] != 0)
                        {
                            // Append the neighbor and its label to 
                            nodes = nodes + "\t" + j + "-" + vertices[j];
                        }

                    }
                    // Write nodes to the file and start a new 
                    sw.WriteLine(nodes);
                }
                // Display a message box to indicate that the file was 
                MessageBox.Show("FileSave");
                sw.Close();
            }
        }



        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog(); //initialize
            od.Filter = "Text Document(*.txt)|*.txt"; //file extension
            od.ValidateNames = true; //validation

            if (od.ShowDialog() == DialogResult.OK)
            {
                setClear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                comboBox3.Items.Clear();
                lblpath4.Text = "The traversal Path is: ";
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                Graphics g = picGraph.CreateGraphics();
                g.Clear(Color.LightPink);

                try
                {
                    String line = "";
                    StreamReader sr = new StreamReader(od.FileName);

                    while (sr.Peek() != -1)
                    {


                        comboBox1.Items.Add(countnodes);
                        comboBox2.Items.Add(countnodes);
                        comboBox4.Items.Add(countnodes);
                        comboBox3.Items.Add(countnodes);


                        countnodes++;

                        dataGridView1.Columns.Add("", (countnodes - 1).ToString());
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[countnodes - 1].HeaderCell.Value = (countnodes - 1).ToString();
                        dataGridView1.AutoResizeRows();


                        line = sr.ReadLine();
                        String[] adjacent = line.Split('\t');
                        String[] nodes = adjacent[0].Split('-');
                        int node1 = Convert.ToInt32(nodes[0]);
                        int x1 = Convert.ToInt32(nodes[1]);
                        int y1 = Convert.ToInt32(nodes[2]);
                        vertices[node1] = x1 + "-" + y1;

                        Rectangle rect = new Rectangle(x1, y1, 35, 35);
                        g.FillEllipse(Brushes.Pink, rect);
                        g.DrawString(node1.ToString(), new Font("Arial", 12), Brushes.Purple, x1 + 12, y1 + 12);

                        for (int i = 1; i < adjacent.Length; i++)
                        {
                            nodes = adjacent[i].Split('-');
                            int node2 = Convert.ToInt32(nodes[0]);
                            int x2 = Convert.ToInt32(nodes[1]);
                            int y2 = Convert.ToInt32(nodes[2]);

                            vertices[node2] = x2 + "-" + y2;

                            rect = new Rectangle(x2, y2, 35, 35);
                            g.FillEllipse(Brushes.Pink, rect);
                            g.DrawString(node2.ToString(), new Font("Arial", 12), Brushes.Purple, x2 + 12, y2 + 12);
                            g.DrawLine(new Pen(Brushes.Purple, 2), (float)(x1 + 12), (float)(y1 + 12), (float)(x2 + 12), (float)(y2 + 12));


                            //calculate Distance
                            double x = (double)(x2 - x1);
                            double y = (double)(y2 - y1);
                            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                            int a = (int)(x1 + x2) / 2;
                            int queue = ((int)(y1 + y2) / 2) - 5;
                            g.DrawString(Math.Round(d, 2).ToString(), new Font("Arial", 12), Brushes.Purple, a, queue);

                            //adjacenct matrix 
                            matrix[node1, node2] = Convert.ToInt32(d);
                            matrix[node2, node1] = Convert.ToInt32(d);

                            setAdjacentMatrix(node1, node2);
                        }
                        setAdjacentMatrixToZero(countnodes);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of Menu
            Menu form1 = new Menu();

            // Hide the menu form
            this.Hide();

            // Show Form1
            form1.Show();
        }


        public void ucsTraversal()
        {
            int source = Convert.ToInt32(comboBox4.Text); // root
            int destination = Convert.ToInt32(comboBox3.Text);
            colornodes(source, Brushes.MediumSlateBlue);
            colornodes(destination, Brushes.DarkSlateBlue);

            PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>(); // create priority queue
            int[] visited = new int[countnodes]; // create visited nodes
            visited[source] = 1; // mark root as visited
            priorityQueue.Enqueue(new Node(source, 0)); // insert root node to the priority queue

            while (priorityQueue.Count > 0) // loop if not empty
            {
                Node currentNode = priorityQueue.Dequeue();
                int x = currentNode.NodeIndex;
                Thread.Sleep(500);
                colornodes(x, Brushes.Navy);

                if (x == destination)
                {
                    // Destination found
                    lblpath4.Text += "" + x + "";
                    break;
                }

                // loop for your immediate neighbors of x
                for (int i = 0; i < countnodes; i++)
                {
                    Thread.Sleep(150);
                    if (matrix[x, i] != 0 && visited[i] != 1)
                    {
                        // If matrix is not equal to zero and not visited yet
                        visited[i] = 1; // mark i as visited

                        int newCost = currentNode.Cost + matrix[x, i]; // calculate new cost
                        priorityQueue.Enqueue(new Node(i, newCost)); // insert it into the priority queue
                    }
                }
                lblpath4.Text += "" + x + "";
            }
        }
    }

    // Node class to store node index and cost
    class Node : IComparable<Node>
    {
        public int NodeIndex { get; }
        public int Cost { get; }

        public Node(int nodeIndex, int cost)
        {
            NodeIndex = nodeIndex;
            Cost = cost;
        }

        public int CompareTo(Node other)
        {
            // Compare nodes based on their costs
            return Cost.CompareTo(other.Cost);
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> heap;

        public int Count => heap.Count;

        public PriorityQueue()
        {
            heap = new List<T>();
        }

        public void Enqueue(T item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        public T Dequeue()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            T item = heap[0];
            int lastIndex = heap.Count - 1;
            heap[0] = heap[lastIndex];
            heap.RemoveAt(lastIndex);
            HeapifyDown(0);

            return item;
        }

        private void HeapifyUp(int childIndex)
        {
            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (heap[childIndex].CompareTo(heap[parentIndex]) >= 0)
                    break;

                Swap(childIndex, parentIndex);
                childIndex = parentIndex;
            }
        }

        private void HeapifyDown(int parentIndex)
        {
            int leftChildIndex = 2 * parentIndex + 1;
            int rightChildIndex = 2 * parentIndex + 2;
            int smallestIndex = parentIndex;

            if (leftChildIndex < heap.Count && heap[leftChildIndex].CompareTo(heap[smallestIndex]) < 0)
                smallestIndex = leftChildIndex;

            if (rightChildIndex < heap.Count && heap[rightChildIndex].CompareTo(heap[smallestIndex]) < 0)
                smallestIndex = rightChildIndex;

            if (smallestIndex != parentIndex)
            {
                Swap(parentIndex, smallestIndex);
                HeapifyDown(smallestIndex);
            }
        }

        private void Swap(int index1, int index2)
        {
            T temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }

}
