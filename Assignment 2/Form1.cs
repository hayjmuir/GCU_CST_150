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
            // holds fahrenheit temperature
            double fahrenheit;

            //holds celsius result
            double celsius;

            // takes the fahrenheit and assigns to the variable fahreheit
            fahrenheit = double.Parse(fahernheitTextBox.Text);




            //converts fahrenheit to celsius
            celsius = (fahrenheit - 32) * 5 / 9;

            //rounds decimal place to 2
            celsius = Math.Round(celsius, 2);

            //displays celsius in the label 
            celciusLabel.Text = celsius.ToString();




        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
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