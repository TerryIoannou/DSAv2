namespace DataS
{
    partial class Form2
    {
        /// <summary>
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
            button1 = new Button();
            bubblesort = new Button();
            button4 = new Button();
            ImportButton = new Button();
            timeLabel = new Label();
            searchBox = new TextBox();
            test = new ListBox();
            searchLabel = new Label();
            button3 = new Button();
            linearSearch = new TextBox();
            resetButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(156, 48);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 0;
            button1.Text = "CombSort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bubblesort
            // 
            bubblesort.Location = new Point(156, 123);
            bubblesort.Name = "bubblesort";
            bubblesort.Size = new Size(112, 52);
            bubblesort.TabIndex = 1;
            bubblesort.Text = "BubbleSort";
            bubblesort.UseVisualStyleBackColor = true;
            bubblesort.Click += bubblesort_Click;
            // 
            // button4
            // 
            button4.Location = new Point(156, 299);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 3;
            button4.Text = "Linear Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(628, 48);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(112, 52);
            ImportButton.TabIndex = 5;
            ImportButton.Text = "Import CSV";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += importButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(354, 104);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 15);
            timeLabel.TabIndex = 6;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(312, 220);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(110, 23);
            searchBox.TabIndex = 7;
            // 
            // test
            // 
            test.FormattingEnabled = true;
            test.ItemHeight = 15;
            test.Location = new Point(544, 137);
            test.Margin = new Padding(3, 2, 3, 2);
            test.Name = "test";
            test.Size = new Size(227, 214);
            test.TabIndex = 9;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(412, 258);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(0, 15);
            searchLabel.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(156, 200);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(112, 62);
            button3.TabIndex = 12;
            button3.Text = "Binary Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linearSearch
            // 
            linearSearch.Location = new Point(312, 308);
            linearSearch.Margin = new Padding(3, 2, 3, 2);
            linearSearch.Name = "linearSearch";
            linearSearch.Size = new Size(110, 23);
            linearSearch.TabIndex = 13;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(628, 384);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 14;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetButton);
            Controls.Add(linearSearch);
            Controls.Add(button3);
            Controls.Add(searchLabel);
            Controls.Add(test);
            Controls.Add(searchBox);
            Controls.Add(timeLabel);
            Controls.Add(ImportButton);
            Controls.Add(button4);
            Controls.Add(bubblesort);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button bubblesort;
        private Button button4;
        private Button ImportButton;
        private Label timeLabel;
        private TextBox searchBox;
        private ListBox test;
        private Label searchLabel;
        private Button button3;
        private TextBox linearSearch;
        private Button resetButton;
    }
}