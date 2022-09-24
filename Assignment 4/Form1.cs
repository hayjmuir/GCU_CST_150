using System.Configuration;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   //holds seconds results

            double seconds;

            
            //grabs the seconds and assigns it to the var seconds
            seconds = double.Parse(timeTextBox.Text);

            //If the number of seconds is greater than or equal to 86,400, display the number of days in that many seconds.
            if (seconds >= 86400)

            {
                double days;
                //divides seconds by the number of seconds in a day
                days = seconds / 86400;
                //rounds the number to two decimal places
                days = Math.Round(days, 2);
                //concats the text to string and add days
                answerLabel.Text = days.ToString() + " Days";

            }
            //If the number of seconds is greater than or equal to 3600, display the number of hours in that many seconds.
            else if (seconds >= 3600)
            {
                double hours;
                //divides secounds by number of seconds in an hour
                hours = seconds / 3600;
                //rounds the number to two decimal places
                hours = Math.Round(hours, 2);
                //concats the text to string and add hours
                answerLabel.Text = hours.ToString() + " Hours";

            }




            //If the number of seconds is greater than or equal to 60, display the number of minutes in that many seconds.


            else if (seconds >= 60)
            {

                double minutes;
                //divides secounds by number of seconds in an minutes
                minutes = seconds / 60;
                //rounds the number to two decimal places
                minutes = Math.Round(minutes, 2);
                //concats the text to string and add minutes
                answerLabel.Text = minutes.ToString() + " Minutes";


            }

            else
            {   //any number less than 60 will be caught by this line of code
                answerLabel.Text = seconds.ToString() + " Seconds";

            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {   //clears the text box and answer label so you do not have to re run the program
            answerLabel.Text = "";
           
            timeTextBox.Text = "";
        }
    }
}