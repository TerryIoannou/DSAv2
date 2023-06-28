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
        private MyArrayList<int> data;

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
                data = new MyArrayList<int>();

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int value))
                    {
                        data.Add(value);
                        test.Items.Add(value);
                    }
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
                MessageBox.Show("No data.import CSV file first.");
                return;
            }

            if (!int.TryParse(searchBox.Text, out int target))
            {
                MessageBox.Show("Incorrect number. InPut a valid integer.");
                return;
            }

            int index = BinarySearchAlgorithm.BinarySearch(data, target);

            if (index != -1)
            {
                int foundNumber = data[index];
                searchLabel.Text = $"Number found: {foundNumber}";
            }
            else
            {
                searchLabel.Text = $"Number does not found.";
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

            int target;
            if (int.TryParse(linearSearch.Text, out target))
            {
                int result = LinearSearch.LinearSearchAlgorithm(data, target);

                if (result != -1)
                    MessageBox.Show("Target found at index: " + result);
                else
                    MessageBox.Show("Target not found.");
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }
    }
}
