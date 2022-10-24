namespace Asssignment_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //checkBox array
            checkBoxes = new CheckBox[5] { pepBox, hamBox, susBox, mushBox, cheeBox };

            //radioButton array
            radioButton = new RadioButton[4] { smallButton, medButton, largeButton, xtraLargeButton };
        }

        private  CheckBox[] checkBoxes;
        private  RadioButton[] radioButton;   

        private void addButton_Click(object sender, EventArgs e)
        {
            //adds checkbox items to orderBox
            foreach (CheckBox cb in checkBoxes)
            { if (cb.Checked)
                {
               orderBox.Items.Add(cb.Text);
                }
            }
            //adds radiobutton items to orderBox
            foreach (RadioButton rb in radioButton)
            { if (rb.Checked)
                { 
                    orderBox.Items.Add(rb.Text); 
                }
                        
            }




        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            orderBox.Items.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}