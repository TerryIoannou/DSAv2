namespace DataS
{
    partial class Form4
    {/// <summary>
     /// Required designer variable.
     /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.binarySearchButton = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.combSortButton = new System.Windows.Forms.Button();
            this.LinearSearchButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.inputArea = new System.Windows.Forms.ListBox();
            this.importCSV = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outPut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // binarySearchButton
            // 
            this.binarySearchButton.Location = new System.Drawing.Point(326, 78);
            this.binarySearchButton.Name = "binarySearchButton";
            this.binarySearchButton.Size = new System.Drawing.Size(150, 34);
            this.binarySearchButton.TabIndex = 7;
            this.binarySearchButton.Text = "Binary Search";
            this.binarySearchButton.Click += new System.EventHandler(this.binarySearchButton_Click_1);
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(326, 182);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(150, 37);
            this.bubbleSortButton.TabIndex = 8;
            this.bubbleSortButton.Text = "Bubble Sort";
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click_1);
            // 
            // combSortButton
            // 
            this.combSortButton.Location = new System.Drawing.Point(326, 237);
            this.combSortButton.Name = "combSortButton";
            this.combSortButton.Size = new System.Drawing.Size(150, 38);
            this.combSortButton.TabIndex = 9;
            this.combSortButton.Text = "Comb Sort";
            this.combSortButton.Click += new System.EventHandler(this.combSortButton_Click_1);
            // 
            // LinearSearchButton
            // 
            this.LinearSearchButton.Location = new System.Drawing.Point(326, 130);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(150, 36);
            this.LinearSearchButton.TabIndex = 10;
            this.LinearSearchButton.Text = "Linear Search";
            this.LinearSearchButton.Click += new System.EventHandler(this.LinearSearchButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(631, 121);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(157, 244);
            this.outputListBox.TabIndex = 11;
            // 
            // inputArea
            // 
            this.inputArea.FormattingEnabled = true;
            this.inputArea.ItemHeight = 16;
            this.inputArea.Location = new System.Drawing.Point(33, 38);
            this.inputArea.Name = "inputArea";
            this.inputArea.Size = new System.Drawing.Size(172, 116);
            this.inputArea.TabIndex = 13;
            // 
            // importCSV
            // 
            this.importCSV.Location = new System.Drawing.Point(671, 18);
            this.importCSV.Name = "importCSV";
            this.importCSV.Size = new System.Drawing.Size(105, 30);
            this.importCSV.TabIndex = 14;
            this.importCSV.Text = "Import CSV";
            this.importCSV.UseVisualStyleBackColor = true;
            this.importCSV.Click += new System.EventHandler(this.importCSV_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // outPut
            // 
            this.outPut.FormattingEnabled = true;
            this.outPut.ItemHeight = 16;
            this.outPut.Location = new System.Drawing.Point(33, 182);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(157, 244);
            this.outPut.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.importCSV);
            this.Controls.Add(this.inputArea);
            this.Controls.Add(this.binarySearchButton);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.combSortButton);
            this.Controls.Add(this.LinearSearchButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button binarySearchButton;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Button combSortButton;
        private System.Windows.Forms.Button LinearSearchButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.ListBox inputArea;
        private System.Windows.Forms.Button importCSV;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox outPut;

    }
}