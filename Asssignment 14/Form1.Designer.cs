namespace Asssignment_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.medButton = new System.Windows.Forms.RadioButton();
            this.pepBox = new System.Windows.Forms.CheckBox();
            this.hamBox = new System.Windows.Forms.CheckBox();
            this.orderBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.susBox = new System.Windows.Forms.CheckBox();
            this.mushBox = new System.Windows.Forms.CheckBox();
            this.cheeBox = new System.Windows.Forms.CheckBox();
            this.largeButton = new System.Windows.Forms.RadioButton();
            this.xtraLargeButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(294, 146);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(47, 19);
            this.smallButton.TabIndex = 0;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "12in";
            this.smallButton.UseVisualStyleBackColor = true;
            // 
            // medButton
            // 
            this.medButton.AutoSize = true;
            this.medButton.Location = new System.Drawing.Point(294, 171);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(47, 19);
            this.medButton.TabIndex = 1;
            this.medButton.TabStop = true;
            this.medButton.Text = "14in";
            this.medButton.UseVisualStyleBackColor = true;
            // 
            // pepBox
            // 
            this.pepBox.AutoSize = true;
            this.pepBox.Location = new System.Drawing.Point(79, 131);
            this.pepBox.Name = "pepBox";
            this.pepBox.Size = new System.Drawing.Size(80, 19);
            this.pepBox.TabIndex = 2;
            this.pepBox.Text = "Pepperoni";
            this.pepBox.UseVisualStyleBackColor = true;
            // 
            // hamBox
            // 
            this.hamBox.AutoSize = true;
            this.hamBox.Location = new System.Drawing.Point(79, 156);
            this.hamBox.Name = "hamBox";
            this.hamBox.Size = new System.Drawing.Size(52, 19);
            this.hamBox.TabIndex = 3;
            this.hamBox.Text = "Ham";
            this.hamBox.UseVisualStyleBackColor = true;
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.ItemHeight = 15;
            this.orderBox.Location = new System.Drawing.Point(473, 117);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(231, 199);
            this.orderBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(178, 377);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(313, 377);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Clear Order";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // susBox
            // 
            this.susBox.AutoSize = true;
            this.susBox.Location = new System.Drawing.Point(79, 181);
            this.susBox.Name = "susBox";
            this.susBox.Size = new System.Drawing.Size(69, 19);
            this.susBox.TabIndex = 7;
            this.susBox.Text = "Sausage";
            this.susBox.UseVisualStyleBackColor = true;
            // 
            // mushBox
            // 
            this.mushBox.AutoSize = true;
            this.mushBox.Location = new System.Drawing.Point(79, 206);
            this.mushBox.Name = "mushBox";
            this.mushBox.Size = new System.Drawing.Size(97, 19);
            this.mushBox.TabIndex = 8;
            this.mushBox.Text = "Mushroooms";
            this.mushBox.UseVisualStyleBackColor = true;
            // 
            // cheeBox
            // 
            this.cheeBox.AutoSize = true;
            this.cheeBox.Location = new System.Drawing.Point(79, 231);
            this.cheeBox.Name = "cheeBox";
            this.cheeBox.Size = new System.Drawing.Size(64, 19);
            this.cheeBox.TabIndex = 9;
            this.cheeBox.Text = "Cheese";
            this.cheeBox.UseVisualStyleBackColor = true;
            // 
            // largeButton
            // 
            this.largeButton.AutoSize = true;
            this.largeButton.Location = new System.Drawing.Point(294, 197);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(47, 19);
            this.largeButton.TabIndex = 10;
            this.largeButton.TabStop = true;
            this.largeButton.Text = "32in";
            this.largeButton.UseVisualStyleBackColor = true;
            // 
            // xtraLargeButton
            // 
            this.xtraLargeButton.AutoSize = true;
            this.xtraLargeButton.Location = new System.Drawing.Point(294, 222);
            this.xtraLargeButton.Name = "xtraLargeButton";
            this.xtraLargeButton.Size = new System.Drawing.Size(47, 19);
            this.xtraLargeButton.TabIndex = 11;
            this.xtraLargeButton.TabStop = true;
            this.xtraLargeButton.Text = "64in";
            this.xtraLargeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pizza Topping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pizza Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Order";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(464, 377);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xtraLargeButton);
            this.Controls.Add(this.largeButton);
            this.Controls.Add(this.cheeBox);
            this.Controls.Add(this.mushBox);
            this.Controls.Add(this.susBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.hamBox);
            this.Controls.Add(this.pepBox);
            this.Controls.Add(this.medButton);
            this.Controls.Add(this.smallButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton smallButton;
        private RadioButton medButton;
        private CheckBox pepBox;
        private CheckBox hamBox;
        private ListBox orderBox;
        private Button addButton;
        private Button removeButton;
        private CheckBox susBox;
        private CheckBox mushBox;
        private CheckBox cheeBox;
        private RadioButton largeButton;
        private RadioButton xtraLargeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button closeButton;
    }
}