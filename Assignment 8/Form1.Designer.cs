namespace Assignment_8
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
            this.caloriesFromFat = new System.Windows.Forms.TextBox();
            this.caloriesFromCarbs = new System.Windows.Forms.TextBox();
            this.calculateCaloriesFromFat = new System.Windows.Forms.Button();
            this.calculateCaloriesFromCarbs = new System.Windows.Forms.Button();
            this.caloriesFromFatLabel = new System.Windows.Forms.Label();
            this.caloriesFromCarbsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caloriesFromFat
            // 
            this.caloriesFromFat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesFromFat.Location = new System.Drawing.Point(53, 87);
            this.caloriesFromFat.Name = "caloriesFromFat";
            this.caloriesFromFat.Size = new System.Drawing.Size(198, 23);
            this.caloriesFromFat.TabIndex = 0;
            // 
            // caloriesFromCarbs
            // 
            this.caloriesFromCarbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesFromCarbs.Location = new System.Drawing.Point(53, 281);
            this.caloriesFromCarbs.Name = "caloriesFromCarbs";
            this.caloriesFromCarbs.Size = new System.Drawing.Size(198, 23);
            this.caloriesFromCarbs.TabIndex = 1;
            // 
            // calculateCaloriesFromFat
            // 
            this.calculateCaloriesFromFat.Location = new System.Drawing.Point(93, 116);
            this.calculateCaloriesFromFat.Name = "calculateCaloriesFromFat";
            this.calculateCaloriesFromFat.Size = new System.Drawing.Size(111, 55);
            this.calculateCaloriesFromFat.TabIndex = 2;
            this.calculateCaloriesFromFat.Text = "Calculate From Fat";
            this.calculateCaloriesFromFat.UseVisualStyleBackColor = true;
            this.calculateCaloriesFromFat.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculateCaloriesFromCarbs
            // 
            this.calculateCaloriesFromCarbs.Location = new System.Drawing.Point(93, 310);
            this.calculateCaloriesFromCarbs.Name = "calculateCaloriesFromCarbs";
            this.calculateCaloriesFromCarbs.Size = new System.Drawing.Size(111, 55);
            this.calculateCaloriesFromCarbs.TabIndex = 3;
            this.calculateCaloriesFromCarbs.Text = "Calculate From Carbs";
            this.calculateCaloriesFromCarbs.UseVisualStyleBackColor = true;
            this.calculateCaloriesFromCarbs.Click += new System.EventHandler(this.button2_Click);
            // 
            // caloriesFromFatLabel
            // 
            this.caloriesFromFatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesFromFatLabel.Location = new System.Drawing.Point(450, 88);
            this.caloriesFromFatLabel.Name = "caloriesFromFatLabel";
            this.caloriesFromFatLabel.Size = new System.Drawing.Size(214, 28);
            this.caloriesFromFatLabel.TabIndex = 4;
            this.caloriesFromFatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caloriesFromCarbsLabel
            // 
            this.caloriesFromCarbsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesFromCarbsLabel.Location = new System.Drawing.Point(450, 281);
            this.caloriesFromCarbsLabel.Name = "caloriesFromCarbsLabel";
            this.caloriesFromCarbsLabel.Size = new System.Drawing.Size(214, 28);
            this.caloriesFromCarbsLabel.TabIndex = 5;
            this.caloriesFromCarbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calories From Fat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calories From Carbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caloriesFromCarbsLabel);
            this.Controls.Add(this.caloriesFromFatLabel);
            this.Controls.Add(this.calculateCaloriesFromCarbs);
            this.Controls.Add(this.calculateCaloriesFromFat);
            this.Controls.Add(this.caloriesFromCarbs);
            this.Controls.Add(this.caloriesFromFat);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox caloriesFromFat;
        private TextBox caloriesFromCarbs;
        private Button calculateCaloriesFromFat;
        private Button calculateCaloriesFromCarbs;
        private Label caloriesFromFatLabel;
        private Label caloriesFromCarbsLabel;
        private Label label1;
        private Label label2;
    }
}