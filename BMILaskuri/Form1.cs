namespace BMILaskuri
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

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(PainoTB.Text);
            double height = Convert.ToDouble(PituusTB.Text);

            double bmi = weight / (height * height);
            VastausLB.Text = $"Painoindeksisi on: {Math.Round(bmi, 2)}\n";

            if (bmi < 18.5)
            {
                VastausLB.ForeColor = Color.Cyan;
                VastausLB.Text += "Alipaino";
            } 
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                VastausLB.ForeColor = Color.Green;
                VastausLB.Text += "Normaalipaino";
            }
            else if (bmi > 24.9 && bmi <= 39.9)
            {
                VastausLB.ForeColor = Color.Yellow;
                VastausLB.Text += "Ylipaino";
            }
            else
            {
                VastausLB.ForeColor = Color.Red;
                VastausLB.Text += "Huomattava ylipaino";
            }
            VastausLB.Visible = true;
        }
    }
}