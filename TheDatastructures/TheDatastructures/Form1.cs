using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheDatastructures
{
    public partial class Form1 : Form
    {

        private LinkedList<int> data;

        public Form1()
        {
            InitializeComponent();
            data = new LinkedList<int>();

        }

        private int GetTargetValue()
        {
            throw new NotImplementedException();
        }

        //bubble sort input data 
        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
          
        }
        
        private int[] ThebubbleSort()
        {
            outPut.Items.Clear();

            int[] data = ParseInputArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            data = BubbleSort.Sort(data);
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalSeconds;

            outPut.Items.Add("bubble Sort Result:");
            outPut.Items.Add("Sorted array: " + string.Join(", ", data));
            outPut.Items.Add("Sorting time: " + elapsedTime.ToString("0.000") + " seconds");

            outPut.Items.Clear();
            foreach (int item in data)
            {
                outPut.Items.Add(item.ToString());
            }

            return data;
        }

        //comb sort input data

        private int[] TheCombSort()
        {
            outPut.Items.Clear();

            int[] data = ParseInputArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            data = CombSort.Sort(data);
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalSeconds;
          
            outPut.Items.Add("Comb Sort Result:");
            outPut.Items.Add("Sorted array: " + string.Join(", ", data));
            outPut.Items.Add("Sorting time: " + elapsedTime.ToString("0.000") + " seconds");

            outPut.Items.Clear();
            foreach (int item in data)
            {
                outPut.Items.Add(item.ToString());
            }

            return data;
        }
       
        // Parse the input data from the inputArea and return it as an array
        private int[] ParseInputArray()
        {
            //string[] inputArray = inputArea.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //int[] data = Array.ConvertAll(inputArray, int.Parse);

            int[] data = new int[outputListBox.Items.Count];
            for (int i = 0; i < outputListBox.Items.Count; i++)
            {
                data[i] = int.Parse(outputListBox.Items[i].ToString());
                //MessageBox.Show(data[i].ToString());
            }
            
            return data;
        }


        private void importCSV_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string[]> data = ReadCSV(filePath);

                outputListBox.Items.Clear();
                foreach (string[] row in data)
                {
                    outputListBox.Items.Add(string.Join(", ", row));
                }
            }
        }

        private List<string[]> ReadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.Add(values);
                }
            }
            return data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LinearSearchButton_Click(object sender, EventArgs e)
        {
            int target;
            if (!int.TryParse(textBox1.Text, out target))
            {
                MessageBox.Show("Invalid search value. Please enter a valid integer.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int index = -1;
            for (int i = 0; i < outputListBox.Items.Count; i++)
            {
                if (outputListBox.Items[i].ToString() == target.ToString())
                {
                    index = i;
                    break;
                }
            }
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalSeconds;

            if (index != -1)
            {
                MessageBox.Show("Linear Search Result:\n\n" +
                    "Element " + target + " is found at index: " + index + ".\n" +
                    "Search time: " + elapsedTime.ToString("0.000") + " seconds");
            }
            else
            {
                MessageBox.Show("Linear Search Result:\n\n" +
                    "Element " + target + " is not present in the dataset.\n" +
                    "Search time: " + elapsedTime.ToString("0.000") + " seconds");
            }
        }

        private void binarySearchButton_Click_1(object sender, EventArgs e)
        {
            int target;
            if (!int.TryParse(textBox2.Text, out target))
            {
                MessageBox.Show("Invalid search value. Please enter a valid integer.");
                return;
            }

            int[] data = new int[outputListBox.Items.Count];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            data = TheCombSort();

            int index = BinarySearch.Search(data, target);
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalSeconds;

            if (index != -1)
            {
                MessageBox.Show("Binary Search Result:\n\n" +
                    "Element " + target + " is found at index: " + index + ".\n" +
                    "Search time: " + elapsedTime.ToString("0.000") + " seconds");
            }
            else
            {
                MessageBox.Show("Binary Search Result:\n\n" +
                    "Element " + target + " is not present in the dataset.\n" +
                    "Search time: " + elapsedTime.ToString("0.000") + " seconds");
            }
        }

        private void combSortButton_Click_1(object sender, EventArgs e)
        {
            TheCombSort();
        }

        private void bubbleSortButton_Click_1(object sender, EventArgs e)
        {
            ThebubbleSort();
        }
    }
}
