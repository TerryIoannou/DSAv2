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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(178, 64);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 69);
            button1.TabIndex = 0;
            button1.Text = "CombSort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bubblesort
            // 
            bubblesort.Location = new Point(178, 164);
            bubblesort.Margin = new Padding(3, 4, 3, 4);
            bubblesort.Name = "bubblesort";
            bubblesort.Size = new Size(128, 69);
            bubblesort.TabIndex = 1;
            bubblesort.Text = "BubbleSort";
            bubblesort.UseVisualStyleBackColor = true;
            bubblesort.Click += bubblesort_Click;
            // 
            // button4
            // 
            button4.Location = new Point(178, 399);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 69);
            button4.TabIndex = 3;
            button4.Text = "Linear Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(718, 64);
            ImportButton.Margin = new Padding(3, 4, 3, 4);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(128, 69);
            ImportButton.TabIndex = 5;
            ImportButton.Text = "Import CSV";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += importButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(405, 138);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 20);
            timeLabel.TabIndex = 6;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(357, 294);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(125, 27);
            searchBox.TabIndex = 7;
            // 
            // test
            // 
            test.FormattingEnabled = true;
            test.ItemHeight = 20;
            test.Location = new Point(718, 164);
            test.Name = "test";
            test.Size = new Size(128, 304);
            test.TabIndex = 9;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(471, 344);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(0, 20);
            searchLabel.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(178, 266);
            button3.Name = "button3";
            button3.Size = new Size(128, 82);
            button3.TabIndex = 12;
            button3.Text = "Binary Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linearSearch
            // 
            linearSearch.Location = new Point(357, 411);
            linearSearch.Name = "linearSearch";
            linearSearch.Size = new Size(125, 27);
            linearSearch.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}