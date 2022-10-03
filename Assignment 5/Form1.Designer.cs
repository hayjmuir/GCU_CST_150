namespace Assignment_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSelectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstWordTextBox = new System.Windows.Forms.TextBox();
            this.lastWordTextBox = new System.Windows.Forms.TextBox();
            this.longWordTextBox = new System.Windows.Forms.TextBox();
            this.vowelTextBox = new System.Windows.Forms.TextBox();
            this.lowercaseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileSelectionButton
            // 
            this.fileSelectionButton.Location = new System.Drawing.Point(90, 48);
            this.fileSelectionButton.Name = "fileSelectionButton";
            this.fileSelectionButton.Size = new System.Drawing.Size(157, 61);
            this.fileSelectionButton.TabIndex = 0;
            this.fileSelectionButton.Text = "Select Document";
            this.fileSelectionButton.UseVisualStyleBackColor = true;
            this.fileSelectionButton.Click += new System.EventHandler(this.wordProcessingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longest Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Most Vowels";
            // 
            // firstWordTextBox
            // 
            this.firstWordTextBox.Location = new System.Drawing.Point(182, 192);
            this.firstWordTextBox.Name = "firstWordTextBox";
            this.firstWordTextBox.Size = new System.Drawing.Size(152, 23);
            this.firstWordTextBox.TabIndex = 6;
            // 
            // lastWordTextBox
            // 
            this.lastWordTextBox.Location = new System.Drawing.Point(182, 227);
            this.lastWordTextBox.Name = "lastWordTextBox";
            this.lastWordTextBox.Size = new System.Drawing.Size(152, 23);
            this.lastWordTextBox.TabIndex = 7;
            // 
            // longWordTextBox
            // 
            this.longWordTextBox.Location = new System.Drawing.Point(182, 270);
            this.longWordTextBox.Name = "longWordTextBox";
            this.longWordTextBox.Size = new System.Drawing.Size(152, 23);
            this.longWordTextBox.TabIndex = 8;
            // 
            // vowelTextBox
            // 
            this.vowelTextBox.Location = new System.Drawing.Point(182, 323);
            this.vowelTextBox.Name = "vowelTextBox";
            this.vowelTextBox.Size = new System.Drawing.Size(152, 23);
            this.vowelTextBox.TabIndex = 9;
            // 
            // lowercaseTextBox
            // 
            this.lowercaseTextBox.Location = new System.Drawing.Point(520, 173);
            this.lowercaseTextBox.Multiline = true;
            this.lowercaseTextBox.Name = "lowercaseTextBox";
            this.lowercaseTextBox.Size = new System.Drawing.Size(189, 168);
            this.lowercaseTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lowercaseTextBox);
            this.Controls.Add(this.vowelTextBox);
            this.Controls.Add(this.longWordTextBox);
            this.Controls.Add(this.lastWordTextBox);
            this.Controls.Add(this.firstWordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSelectionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button fileSelectionButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox firstWordTextBox;
        private TextBox lastWordTextBox;
        private TextBox longWordTextBox;
        private TextBox vowelTextBox;
        private TextBox lowercaseTextBox;
    }
}