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
    public partial class Form3 : Form
    {
         private Hashtable data;

    public Form3()
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
            // Read the CSV file and populate the data Hashtable
            string[] lines = File.ReadAllLines(openFileDialog.FileName);
            data = new Hashtable();

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int value))
                {
                    if (!data.ContainsKey(value))
                    {
                        data.Add(value, null);
                    }
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

            CombSortHashTable.SortHashtableValues(data);

            stopwatch.Stop();

            // Display the sorted data and sorting time
            timeLabel.Text = $"Time taken: {stopwatch.ElapsedMilliseconds} milliseconds";
            DisplaySortedData();
        }
        private void DisplaySortedData()
        {
            // Create a string to store the sorted data
            StringBuilder sortedData = new StringBuilder();

            // Iterate through the sorted keys of the Hashtable
            foreach (var key in data.Keys)
            {
                sortedData.Append(key.ToString());
                sortedData.Append(", ");
            }

            // Remove the trailing comma and space
            if (sortedData.Length > 2)
            {
                sortedData.Length -= 2;
            }

            // Display the sorted data in the label
            outPut.Text = sortedData.ToString();
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

            BubbleSortHashTable.SortHashtableValues(data);

            stopwatch.Stop();

            // Display the sorted data and sorting time
            timeLabel.Text = $"Time taken: {stopwatch.ElapsedMilliseconds} milliseconds";
            DisplaySortedData();
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

            // Perform the binary search on the hashtable
            bool found = BinarySearchHashTable.HashTableBinarySearch(data, target);

            if (found)
            {
                MessageBox.Show($"Target {target} found.");
            }
            else
            {
                MessageBox.Show($"Target {target} not found.");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
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

            // Perform the hash table search
            bool found = HashSearch.PerformSearch(data, target);

            if (found)
            {
                MessageBox.Show($"Target {target} found.");
            }
            else
            {
                MessageBox.Show($"Target {target} not found.");
            }
        }
    }
}
