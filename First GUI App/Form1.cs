namespace First_GUI_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textLB.Visible = true;
            if (textLB.Text == "Hello world!")
            {
                textLB.Text = "Huomenta opiskelijat";
                button1.BackColor = Color.Red;
                BackColor = Color.Yellow;
                textLB.ForeColor = Color.Blue;
            } else
            {
                textLB.Text = "Hello world!";
                button1.BackColor = Color.Yellow;
                BackColor = Color.Red;
                textLB.ForeColor = Color.White;
            }

        }
    }
}