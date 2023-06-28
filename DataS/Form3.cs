using Aspose.Cells.Drawing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DataS
{
    public partial class Form3 : Form
    {
        private BinaryTree<int> data;


        public Form3()
        {
            InitializeComponent();
        }
        private void importButtonform3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                data = new BinaryTree<int>();

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int value))
                    {
                        data.Insert(value);
                        ListBox.Items.Add(value);
                    }
                }

                MessageBox.Show("CSV file imported!");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the form
        }

        private void compbutton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Root == null)
            {
                MessageBox.Show("No data. Import CSV file first.");
                return;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CompSortBT.CombSort(data);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            ListBox.Items.Clear();
            InorderTraversal(data.Root);

            timeLabelBT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";


        }

        private void bubblebutton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Root == null)
            {
                MessageBox.Show("No data. Import CSV file first.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSortBT.BubbleSort(data);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            ListBox.Items.Clear();
            InorderTraversal(data.Root);

            timeLabelBT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";

        }

        private void InorderTraversal(BinaryTreeNode<int> currentNode)
        {
            if (currentNode == null)
                return;

            InorderTraversal(currentNode.Left);
            ListBox.Items.Add(currentNode.Data);
            InorderTraversal(currentNode.Right);

        }

        private void binarybutton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Root == null)
            {
                MessageBox.Show("Please import a CSV file first.");
                return;
            }

            int target;
            if (int.TryParse(searchBox.Text, out target))
            {
                bool found = data.Search(target);

                if (found)
                {
                    MessageBox.Show("Target found!.");
                }
                else
                {
                    MessageBox.Show("Target have not been found :).");
                }
            }
            else
            {
                MessageBox.Show("Input a proper Interger .");
            }
        }


        private void linearbutton_Click(object sender, EventArgs e)
        {
            if (data == null || data.Root == null)
            {
                MessageBox.Show("Please import a CSV file first.");
                return;
            }

            int target;
            if (int.TryParse(searchboxtwo.Text, out target))
            {
                LinearSearchBT<int> linearSearch = new LinearSearchBT<int>(data);
                bool found = linearSearch.Search(target);

                if (found)
                {
                    MessageBox.Show("Number FOUND!.");
                }
                else
                {
                    MessageBox.Show("This Number does not exist here.");
                }
            }
            else
            {
                MessageBox.Show("enter a valid integer to search.");
            }
        }
    }


}






