namespace Assignment_7
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
                double numerator;
                double denominator;
                double pi;
                int numberOfTerms;
                numerator = 4;
                denominator = 1;
                pi = 0;
                numberOfTerms = int.Parse(termBox.Text);

                for (int i = 0; i < numberOfTerms; i++)
                {
                    pi += numerator / denominator;
                    numerator = -numerator;
                    denominator += 2;
                }
                answerLabel.Text = "= " + pi.ToString();
                inputReflectionLabel.Text = "The approximate value of pie after " + numberOfTerms.ToString() + " terms";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "";
            inputReflectionLabel.Text = "";
            termBox.Text = "";
        }
    }
}