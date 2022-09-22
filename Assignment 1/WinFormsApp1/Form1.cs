namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void mesesageButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Thanks for clicking the button!");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Thanks for clicking the second button!");
    }
}