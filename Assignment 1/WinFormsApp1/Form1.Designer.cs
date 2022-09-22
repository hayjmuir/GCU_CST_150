namespace WinFormsApp1
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
            this.mesesageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mesesageButton
            // 
            this.mesesageButton.Location = new System.Drawing.Point(24, 12);
            this.mesesageButton.Name = "mesesageButton";
            this.mesesageButton.Size = new System.Drawing.Size(89, 37);
            this.mesesageButton.TabIndex = 0;
            this.mesesageButton.Text = "Push Me";
            this.mesesageButton.UseVisualStyleBackColor = true;
            this.mesesageButton.Click += new System.EventHandler(this.mesesageButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "No, Push Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 61);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mesesageButton);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button mesesageButton;
        private Button button1;
    }
}