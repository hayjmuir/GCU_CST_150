namespace Assignment_7
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
            this.termLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.termBox = new System.Windows.Forms.TextBox();
            this.inputReflectionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(215, 142);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(92, 15);
            this.termLabel.TabIndex = 0;
            this.termLabel.Text = "Enter # of Terms";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(313, 204);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 59);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // termBox
            // 
            this.termBox.Location = new System.Drawing.Point(313, 139);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(256, 23);
            this.termBox.TabIndex = 2;
            // 
            // inputReflectionLabel
            // 
            this.inputReflectionLabel.Location = new System.Drawing.Point(229, 293);
            this.inputReflectionLabel.Name = "inputReflectionLabel";
            this.inputReflectionLabel.Size = new System.Drawing.Size(450, 23);
            this.inputReflectionLabel.TabIndex = 3;
            // 
            // answerLabel
            // 
            this.answerLabel.Location = new System.Drawing.Point(229, 347);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(450, 23);
            this.answerLabel.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(457, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 59);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.inputReflectionLabel);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.termLabel);
            this.Name = "Form1";
            this.Text = "Pi Approximator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label termLabel;
        private Button calculateButton;
        private TextBox termBox;
        private Label inputReflectionLabel;
        private Label answerLabel;
        private Button clearButton;
    }
}