namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //runs the FatCalories method and displays the answer in the label
                caloriesFromFatLabel.Text = FatCalories(int.Parse(caloriesFromFat.Text)).ToString();
                
            }
                //displays error if something other than an interger is present in text box
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }


        private double FatCalories(int fatGrams)
        {
            double calories = 0;
            
            //calculates calories from number of fat grams given
            calories = fatGrams * 9;

            return calories;
        }

        private double CarbCalories(int carbGrams)
        {
            double calories = 0;
           
            //calculates calories from number of carb grams given
            calories = carbGrams * 4;

            return calories;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //runs CarbCalories method and displays the answer in the label
                caloriesFromCarbsLabel.Text = CarbCalories(int.Parse(caloriesFromCarbs.Text)).ToString();
            }
            //displays error if something other than an interger is present in text box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}