namespace KolmasTehtava
{
    public partial class NelilaskinFM : Form
    {
        public NelilaskinFM()
        {
            InitializeComponent();
        }

        private void NelilaskinFM_Load(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(Luku1TB.Text);
            float luku2 = float.Parse(Luku2TB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;

            switch (merkki) 
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
            }

            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
        }
    }
}