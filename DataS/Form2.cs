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

namespace DataS
{
    public partial class Form2 : Form
    {

        private ArrayList data;

        public Form2()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the form
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the CSV file and populate the data ArrayList
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                data = new ArrayList();

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int value))
                    {
                        data.Add(value);
                    }
                }

                MessageBox.Show("CSV file imported successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data to sort. Please import a CSV file first.");
                return;
            }

            // Perform the sorting and measure the time it takes
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CombSorting.CombSort(data);

            stopwatch.Stop();

            // Display the sorted data and sorting time
            timeLabel.Text = $"Time taken: {stopwatch.ElapsedMilliseconds} milliseconds";
            DisplaySortedData();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data to sort. Please import a CSV file first.");
                return;
            }

            // Perform the sorting and measure the time it takes
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSorting.BubbleSort(data);

            stopwatch.Stop();

            // Display the sorted data and sorting time
            timeLabel.Text = $"Time taken: {stopwatch.ElapsedMilliseconds} milliseconds";
            DisplaySortedData();
        }
        private void DisplaySortedData()
        {
            // Create a string to store the sorted data
            string sortedData = string.Join(", ", data);

            // Display the sorted data in the label
            outPut.Text = sortedData;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data to search. Please import a CSV file first.");
                return;
            }

            if (!int.TryParse(searchBox.Text, out int target))
            {
                MessageBox.Show("Invalid search target. Please enter a valid integer value.");
                return;
            }

            // Perform the binary search
            int index = BinarySearchAlgorithm.BinarySearch(data, target);

            if (index != -1)
            {
                MessageBox.Show($"Target {target} found at index {index}.");
            }
            else
            {
                MessageBox.Show($"Target {target} not found.");
            }
        }
    }
}
