using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataS
{
    public partial class Form2 : Form
    {
        private MyArrayList<string> data; // Change data type to string

        public Form2()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                data = new MyArrayList<string>(); // Change to string type

                foreach (string line in lines)
                {
                    data.Add(line); // Add each line as a string
                    test.Items.Add(line); // Add each line to the ListBox
                }

                MessageBox.Show("CSV file imported!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data.import CSV file first.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CombSorting.CombSort(data);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            timeLabel.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";
            DisplaySortedData();
            UpdateListBox();
        }

        private void DisplaySortedData()
        {
            string sortedData = string.Join(", ", data);
        }

        private void bubblesort_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data.import CSV file first.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSorting.BubbleSort(data);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            timeLabel.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";

            DisplaySortedData();
            UpdateListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data. Import CSV file first.");
                return;
            }

            string target = searchBox.Text; // Parse target as string
            int index = BinarySearchAlgorithm.BinarySearch(data, target); // Perform binary search with string target

            if (index != -1)
            {
                string foundItem = data[index];
                searchLabel.Text = $"Item found: {foundItem}";
            }
            else
            {
                searchLabel.Text = $"Item does not found.";
            }

            UpdateListBox();
        }


        private void UpdateListBox()
        {
            test.Items.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                test.Items.Add(data[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data. Import CSV file first.");
                return;
            }

            string target = linearSearch.Text; // Change to string type
            int result = LinearSearch.LinearSearchAlgorithm(data, target); // Change to string type

            if (result != -1)
                MessageBox.Show("Target found at index: " + result);
            else
                MessageBox.Show("Target not found.");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            data = null; // Clear the data
            test.Items.Clear(); // Clear the ListBox
            timeLabel.Text = "Elapsed Time: "; // Clear the time label
            searchLabel.Text = " "; // Clear the search label
        }
    }
}
