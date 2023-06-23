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
            timeLabel = new Label();
            ImportButton = new Button();
            outPut = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(277, 243);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(125, 27);
            searchBox.TabIndex = 16;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(319, 113);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(57, 20);
            timeLabel.TabIndex = 15;
            timeLabel.Text = "TEsting";
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(638, 13);
            ImportButton.Margin = new Padding(3, 4, 3, 4);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(128, 69);
            ImportButton.TabIndex = 14;
            ImportButton.Text = "Import CSV";
            ImportButton.UseVisualStyleBackColor = true;
            // 
            // outPut
            // 
            outPut.AutoSize = true;
            outPut.Location = new Point(319, 62);
            outPut.Name = "outPut";
            outPut.Size = new Size(57, 20);
            outPut.TabIndex = 13;
            outPut.Text = "TEsting";
            // 
            // button4
            // 
            button4.Location = new Point(98, 344);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(128, 69);
            button4.TabIndex = 12;
            button4.Text = "Hash Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(98, 222);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(128, 69);
            button3.TabIndex = 11;
            button3.Text = "Binery Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(98, 113);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(128, 69);
            button2.TabIndex = 10;
            button2.Text = "BubbleSort";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(98, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 69);
            button1.TabIndex = 9;
            button1.Text = "CombSort";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBox);
            Controls.Add(timeLabel);
            Controls.Add(ImportButton);
            Controls.Add(outPut);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private Label timeLabel;
        private Button ImportButton;
        private Label outPut;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}