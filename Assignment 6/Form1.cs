using System.Linq.Expressions;

namespace WinFormsAppMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                double fahrenheit;


                double celsius;

                // takes the fahrenheit and assigns to the variable fahreheit
                fahrenheit = double.Parse(fahernheitTextBox.Text);




                //converts fahrenheit to celsius
                celsius = (fahrenheit - 32) * 5 / 9;

                //rounds decimal place to 3
                celsius = Math.Round(celsius, 3);

                //displays celsius in the label 
                celciusLabel.Text = celsius.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }





        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
          

        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            //clears the text so that you can reuse the form without restarting it
            fahernheitTextBox.Text = "";

            celciusLabel.Text = "";
        }


    }
}