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
            ListBox = new ListBox();
            searchboxtwo = new TextBox();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(277, 243);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(125, 27);
            searchBox.TabIndex = 16;
            // 
            // timeLabelBT
            // 
            timeLabelBT.AutoSize = true;
            timeLabelBT.Location = new Point(321, 103);
            timeLabelBT.Name = "timeLabelBT";
            timeLabelBT.Size = new Size(57, 20);
            timeLabelBT.TabIndex = 15;
            timeLabelBT.Text = "TEsting";
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
            ImportButton.Click += importButtonform3_Click;
            // 
            // linearbutton
            // 
            linearbutton.Location = new Point(98, 344);
            linearbutton.Margin = new Padding(3, 4, 3, 4);
            linearbutton.Name = "linearbutton";
            linearbutton.Size = new Size(128, 69);
            linearbutton.TabIndex = 12;
            linearbutton.Text = "Linear Search";
            linearbutton.UseVisualStyleBackColor = true;
            linearbutton.Click += linearbutton_Click;
            // 
            // binarybutton
            // 
            binarybutton.Location = new Point(98, 222);
            binarybutton.Margin = new Padding(3, 4, 3, 4);
            binarybutton.Name = "binarybutton";
            binarybutton.Size = new Size(128, 69);
            binarybutton.TabIndex = 11;
            binarybutton.Text = "Binery Search";
            binarybutton.UseVisualStyleBackColor = true;
            binarybutton.Click += binarybutton_Click;
            // 
            // bubblebutton
            // 
            bubblebutton.Location = new Point(98, 113);
            bubblebutton.Margin = new Padding(3, 4, 3, 4);
            bubblebutton.Name = "bubblebutton";
            bubblebutton.Size = new Size(128, 69);
            bubblebutton.TabIndex = 10;
            bubblebutton.Text = "BubbleSort";
            bubblebutton.UseVisualStyleBackColor = true;
            bubblebutton.Click += bubblebutton_Click;
            // 
            // compbutton
            // 
            compbutton.Location = new Point(98, 13);
            compbutton.Margin = new Padding(3, 4, 3, 4);
            compbutton.Name = "compbutton";
            compbutton.Size = new Size(128, 69);
            compbutton.TabIndex = 9;
            compbutton.Text = "CombSort";
            compbutton.UseVisualStyleBackColor = true;
            compbutton.Click += compbutton_Click;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 20;
            ListBox.Location = new Point(638, 103);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(128, 304);
            ListBox.TabIndex = 17;
            // 
            // searchboxtwo
            // 
            searchboxtwo.Location = new Point(277, 365);
            searchboxtwo.Name = "searchboxtwo";
            searchboxtwo.Size = new Size(125, 27);
            searchboxtwo.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchboxtwo);
            Controls.Add(ListBox);
            Controls.Add(searchBox);
            Controls.Add(timeLabelBT);
            Controls.Add(ImportButton);
            Controls.Add(linearbutton);
            Controls.Add(binarybutton);
            Controls.Add(bubblebutton);
            Controls.Add(compbutton);
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
        private ListBox ListBox;
        private TextBox searchboxtwo;
    }
}