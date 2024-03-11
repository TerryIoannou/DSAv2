using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO; // Add this namespace for File operations
using static System.Net.Mime.MediaTypeNames;


namespace DataS
{
    public partial class Form4 : Form
    {
        private LinkedList<String> data;
        private Stopwatch stopwatch;
        public Form4()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void ImportButtonform4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                data = new LinkedList<string>(); // Correct data type to MyLinkList<string>

                foreach (string line in lines)
                {
                    data.AddLast(line); // Add each line as a string
                    ListBoxList.Items.Add(line); // Add each line to the ListBox
                }

                MessageBox.Show("CSV file imported!");
            }
        }

        private void compbutton_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("No data imported. Please import a CSV file first.");
                return;
            }

            stopwatch.Reset(); // Reset the stopwatch
            stopwatch.Start(); // Start the stopwatch

            var dataArray = data.ToArray();
            CombSortLink.Sort(dataArray);

            stopwatch.Stop(); // Stop the stopwatch
            TimeSpan elapsedTime = stopwatch.Elapsed; // Get the elapsed time

            ListBoxList.Items.Clear();
            foreach (var item in dataArray)
            {
                ListBoxList.Items.Add(item);
            }

            timeLabelLT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms"; // Display the elapsed time
        }


        private void bubblebuttonbubble_Click_1(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("No data imported. Please import a CSV file first.");
                return;
            }

            stopwatch.Reset();
            stopwatch.Start();

            var dataArray = data.ToArray();
            BubbleSortLink.Sort(dataArray);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            ListBoxList.Items.Clear();
            foreach (var item in dataArray)
            {
                ListBoxList.Items.Add(item);
            }

            timeLabelLT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";
        }

        private void linearbutton_Click_1(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("No data imported. Please import a CSV file first.");
                return;
            }

            string target = searchboxtwo.Text;
            LinearSearchList<string> linearSearchList = new LinearSearchList<string>();
            var currentNode = data.GetFirstNode();
            while (currentNode != null)
            {
                linearSearchList.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            stopwatch.Reset();
            stopwatch.Start();

            int index = linearSearchList.LinearSearch(target);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            if (index != -1)
            {
                MessageBox.Show($"Number found at index {index}.");
            }
            else
            {
                MessageBox.Show("Number not found.");
            }

            timeLabelLT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";
        }

        private void binarybutton_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("No data imported. Please import a CSV file first.");
                return;
            }

            string target = searchBox.Text;
            var dataArray = data.ToArray();

            stopwatch.Reset();
            stopwatch.Start();

            int index = BinarySearchLink.Search<string>(dataArray, target, Comparer<string>.Default);

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            if (index != -1)
            {
                MessageBox.Show($"Target found at index {index}.");
            }
            else
            {
                MessageBox.Show("Target not found.");
            }

            timeLabelLT.Text = $"Elapsed Time: {elapsedTime.TotalMilliseconds} ms";
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            data = null;
            ListBoxList.Items.Clear();
            searchBox.Clear();
            searchboxtwo.Clear();
            timeLabelLT.Text = "Elapsed Time: ";
        }
    }
}

