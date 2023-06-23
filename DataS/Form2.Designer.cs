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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            outPut = new Label();
            ImportButton = new Button();
            timeLabel = new Label();
            searchBox = new TextBox();
            label1 = new Label();
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
            // button2
            // 
            button2.Location = new Point(178, 164);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(128, 69);
            button2.TabIndex = 1;
            button2.Text = "BubbleSort";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(178, 273);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(128, 69);
            button3.TabIndex = 2;
            button3.Text = "Binery Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(178, 395);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 69);
            button4.TabIndex = 3;
            button4.Text = "Hash Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // outPut
            // 
            outPut.AutoSize = true;
            outPut.Location = new Point(399, 113);
            outPut.Name = "outPut";
            outPut.Size = new Size(57, 20);
            outPut.TabIndex = 4;
            outPut.Text = "TEsting";
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
            timeLabel.Location = new Point(399, 164);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(57, 20);
            timeLabel.TabIndex = 6;
            timeLabel.Text = "TEsting";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(357, 294);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(125, 27);
            searchBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 468);
            label1.Name = "label1";
            label1.Size = new Size(268, 20);
            label1.TabIndex = 8;
            label1.Text = "ArrayList does not support Hash Search";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(searchBox);
            Controls.Add(timeLabel);
            Controls.Add(ImportButton);
            Controls.Add(outPut);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label outPut;
        private Button ImportButton;
        private Label timeLabel;
        private TextBox searchBox;
        private Label label1;
    }
}