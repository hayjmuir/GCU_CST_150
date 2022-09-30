namespace WinFormsAppMath
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
            this.fahrenheitPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.celciusLabel = new System.Windows.Forms.Label();
            this.fahernheitTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fahrenheitPromptLabel
            // 
            this.fahrenheitPromptLabel.AutoSize = true;
            this.fahrenheitPromptLabel.Location = new System.Drawing.Point(167, 126);
            this.fahrenheitPromptLabel.Name = "fahrenheitPromptLabel";
            this.fahrenheitPromptLabel.Size = new System.Drawing.Size(197, 15);
            this.fahrenheitPromptLabel.TabIndex = 0;
            this.fahrenheitPromptLabel.Text = "Enter the temperature in Fahrenheit:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(233, 201);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(129, 15);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Temperature in Celsius:";
            // 
            // celciusLabel
            // 
            this.celciusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celciusLabel.Location = new System.Drawing.Point(378, 197);
            this.celciusLabel.Name = "celciusLabel";
            this.celciusLabel.Size = new System.Drawing.Size(184, 23);
            this.celciusLabel.TabIndex = 3;
            this.celciusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fahernheitTextBox
            // 
            this.fahernheitTextBox.Location = new System.Drawing.Point(378, 123);
            this.fahernheitTextBox.Name = "fahernheitTextBox";
            this.fahernheitTextBox.Size = new System.Drawing.Size(184, 23);
            this.fahernheitTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(211, 329);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(102, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Temperature";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(486, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearTextButton
            // 
            this.clearTextButton.Location = new System.Drawing.Point(356, 329);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(91, 43);
            this.clearTextButton.TabIndex = 8;
            this.clearTextButton.Text = "Clear Text";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.fahernheitTextBox);
            this.Controls.Add(this.celciusLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.fahrenheitPromptLabel);
            this.Name = "Form1";
            this.Text = "F to C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fahrenheitPromptLabel;
        private Label outputDescriptionLabel;
        private Label celciusLabel;
        private TextBox fahernheitTextBox;
        private Button calculateButton;
        private Button exitButton;
        private Button clearTextButton;
    }
}