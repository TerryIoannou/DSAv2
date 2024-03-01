namespace DataS
{
    partial class Form3
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
            searchBox = new TextBox();
            timeLabelBT = new Label();
            ImportButton = new Button();
            linearbutton = new Button();
            binarybutton = new Button();
            bubblebutton = new Button();
            compbutton = new Button();
            ListBox1 = new ListBox();
            searchboxtwo = new TextBox();
            resetButton = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(242, 182);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(110, 23);
            searchBox.TabIndex = 16;
            // 
            // timeLabelBT
            // 
            timeLabelBT.AutoSize = true;
            timeLabelBT.Location = new Point(281, 77);
            timeLabelBT.Name = "timeLabelBT";
            timeLabelBT.Size = new Size(45, 15);
            timeLabelBT.TabIndex = 15;
            timeLabelBT.Text = "TEsting";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(558, 10);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(112, 52);
            ImportButton.TabIndex = 14;
            ImportButton.Text = "Import CSV";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += importButtonform3_Click;
            // 
            // linearbutton
            // 
            linearbutton.Location = new Point(86, 258);
            linearbutton.Name = "linearbutton";
            linearbutton.Size = new Size(112, 52);
            linearbutton.TabIndex = 12;
            linearbutton.Text = "Linear Search";
            linearbutton.UseVisualStyleBackColor = true;
            linearbutton.Click += linearbutton_Click;
            // 
            // binarybutton
            // 
            binarybutton.Location = new Point(86, 166);
            binarybutton.Name = "binarybutton";
            binarybutton.Size = new Size(112, 52);
            binarybutton.TabIndex = 11;
            binarybutton.Text = "Binery Search";
            binarybutton.UseVisualStyleBackColor = true;
            binarybutton.Click += binarybutton_Click;
            // 
            // bubblebutton
            // 
            bubblebutton.Location = new Point(86, 85);
            bubblebutton.Name = "bubblebutton";
            bubblebutton.Size = new Size(112, 52);
            bubblebutton.TabIndex = 10;
            bubblebutton.Text = "BubbleSort";
            bubblebutton.UseVisualStyleBackColor = true;
            bubblebutton.Click += bubblebutton_Click;
            // 
            // compbutton
            // 
            compbutton.Location = new Point(86, 10);
            compbutton.Name = "compbutton";
            compbutton.Size = new Size(112, 52);
            compbutton.TabIndex = 9;
            compbutton.Text = "CombSort";
            compbutton.UseVisualStyleBackColor = true;
            compbutton.Click += compbutton_Click;
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(432, 92);
            ListBox1.Margin = new Padding(3, 2, 3, 2);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(238, 169);
            ListBox1.TabIndex = 17;
            // 
            // searchboxtwo
            // 
            searchboxtwo.Location = new Point(242, 274);
            searchboxtwo.Margin = new Padding(3, 2, 3, 2);
            searchboxtwo.Name = "searchboxtwo";
            searchboxtwo.Size = new Size(110, 23);
            searchboxtwo.TabIndex = 18;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(574, 301);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 19;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(resetButton);
            Controls.Add(searchboxtwo);
            Controls.Add(ListBox1);
            Controls.Add(searchBox);
            Controls.Add(timeLabelBT);
            Controls.Add(ImportButton);
            Controls.Add(linearbutton);
            Controls.Add(binarybutton);
            Controls.Add(bubblebutton);
            Controls.Add(compbutton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Label timeLabelBT;
        private Button ImportButton;
        private Button linearbutton;
        private Button binarybutton;
        private Button bubblebutton;
        private Button compbutton;
        private ListBox ListBox1;
        private TextBox searchboxtwo;
        private Button resetButton;
    }
}