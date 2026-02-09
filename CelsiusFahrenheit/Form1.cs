namespace CelsiusFahrenheit
{
    public partial class CelsiusToFahrenheit : Form
    {
        public CelsiusToFahrenheit()
        {
            InitializeComponent();
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "Vastaus: ";
            double degrees = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                VastausLB.Text += GetFToC(degrees);
            }
            if (FahrenheitRB.Checked)
            {
                VastausLB.Text += GetCToF(degrees);
            }
        }

        private string GetFToC(double degrees)
        {
            return Math.Round(degrees * 1.8 + 32, 2).ToString();
        }

        private string GetCToF(double degrees)
        {
            return Math.Round((degrees - 32) / 1.8, 1).ToString();
        }
    }
}