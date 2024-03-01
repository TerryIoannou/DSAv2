namespace DataS
{
    partial class Form4
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
            resetButton = new Button();
            searchboxtwo = new TextBox();
            ListBoxList = new ListBox();
            searchBox = new TextBox();
            timeLabelLT = new Label();
            ImportButtonform4 = new Button();
            linearbutton = new Button();
            binarybutton = new Button();
            bubblebuttonbubble = new Button();
            compbutton = new Button();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(596, 334);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 29;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click_1;
            // 
            // searchboxtwo
            // 
            searchboxtwo.Location = new Point(264, 307);
            searchboxtwo.Margin = new Padding(3, 2, 3, 2);
            searchboxtwo.Name = "searchboxtwo";
            searchboxtwo.Size = new Size(110, 23);
            searchboxtwo.TabIndex = 28;
            // 
            // ListBoxList
            // 
            ListBoxList.FormattingEnabled = true;
            ListBoxList.ItemHeight = 15;
            ListBoxList.Location = new Point(454, 125);
            ListBoxList.Margin = new Padding(3, 2, 3, 2);
            ListBoxList.Name = "ListBoxList";
            ListBoxList.Size = new Size(238, 169);
            ListBoxList.TabIndex = 27;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(264, 215);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(110, 23);
            searchBox.TabIndex = 26;
            // 
            // timeLabelLT
            // 
            timeLabelLT.AutoSize = true;
            timeLabelLT.Location = new Point(303, 110);
            timeLabelLT.Name = "timeLabelLT";
            timeLabelLT.Size = new Size(45, 15);
            timeLabelLT.TabIndex = 25;
            timeLabelLT.Text = "TEsting";
            // 
            // ImportButtonform4
            // 
            ImportButtonform4.Location = new Point(580, 43);
            ImportButtonform4.Name = "ImportButtonform4";
            ImportButtonform4.Size = new Size(112, 52);
            ImportButtonform4.TabIndex = 24;
            ImportButtonform4.Text = "Import CSV";
            ImportButtonform4.UseVisualStyleBackColor = true;
            ImportButtonform4.Click += ImportButtonform4_Click;
            // 
            // linearbutton
            // 
            linearbutton.Location = new Point(108, 291);
            linearbutton.Name = "linearbutton";
            linearbutton.Size = new Size(112, 52);
            linearbutton.TabIndex = 23;
            linearbutton.Text = "Linear Search";
            linearbutton.UseVisualStyleBackColor = true;
            linearbutton.Click += linearbutton_Click_1;
            // 
            // binarybutton
            // 
            binarybutton.Location = new Point(108, 199);
            binarybutton.Name = "binarybutton";
            binarybutton.Size = new Size(112, 52);
            binarybutton.TabIndex = 22;
            binarybutton.Text = "Binery Search";
            binarybutton.UseVisualStyleBackColor = true;
            binarybutton.Click += binarybutton_Click;
            // 
            // bubblebuttonbubble
            // 
            bubblebuttonbubble.Location = new Point(108, 118);
            bubblebuttonbubble.Name = "bubblebuttonbubble";
            bubblebuttonbubble.Size = new Size(112, 52);
            bubblebuttonbubble.TabIndex = 21;
            bubblebuttonbubble.Text = "BubbleSort";
            bubblebuttonbubble.UseVisualStyleBackColor = true;
            bubblebuttonbubble.Click += bubblebuttonbubble_Click_1;
            // 
            // compbutton
            // 
            compbutton.Location = new Point(108, 43);
            compbutton.Name = "compbutton";
            compbutton.Size = new Size(112, 52);
            compbutton.TabIndex = 20;
            compbutton.Text = "CombSort";
            compbutton.UseVisualStyleBackColor = true;
            compbutton.Click += compbutton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(resetButton);
            Controls.Add(searchboxtwo);
            Controls.Add(ListBoxList);
            Controls.Add(searchBox);
            Controls.Add(timeLabelLT);
            Controls.Add(ImportButtonform4);
            Controls.Add(linearbutton);
            Controls.Add(binarybutton);
            Controls.Add(bubblebuttonbubble);
            Controls.Add(compbutton);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetButton;
        private TextBox searchboxtwo;
        private ListBox ListBoxList;
        private TextBox searchBox;
        private Label timeLabelLT;
        private Button ImportButtonform4;
        private Button linearbutton;
        private Button binarybutton;
        private Button bubblebuttonbubble;
        private Button compbutton;
    }
}