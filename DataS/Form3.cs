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
                data = new BinaryTree<int>(); // Modify data type to BinaryTree<int> to handle integers

                foreach (string line in lines)
                {
                    // Split the line by comma to handle CSV format
                    string[] values = line.Split(',');

                    foreach (string value in values)
                    {
                        // Parse each value to integer and add it to the binary tree and ListBox
                        if (int.TryParse(value, out int intValue))
                        {
                            data.Insert(intValue);
                            ListBox1.Items.Add(intValue);
                        }
                        else
                        {
                            // Handle parsing error if necessary
                            MessageBox.Show($"Failed to parse value: {value} as an integer.");
                        }
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

            ListBox1.Items.Clear();
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

            ListBox1.Items.Clear();
            InorderTraversal(data.Root);

            timeLabelBT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";

        }

        private void InorderTraversal(BinaryTreeNode<int> currentNode)
        {
            if (currentNode == null)
                return;

            InorderTraversal(currentNode.Left);
            ListBox1.Items.Add(currentNode.Data);
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            data = null; // Clear the binary tree data
            ListBox1.Items.Clear(); // Clear the ListBox
            timeLabelBT.Text = "Elapsed Time: "; // Clear the time label
            searchBox.Text = ""; // Clear the search box
            searchboxtwo.Text = ""; // Clear the second search box
        }
    }


}






