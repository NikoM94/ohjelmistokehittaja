namespace Ikälaskuri
{
    public partial class IkalaskuriFM : Form
    {
        public IkalaskuriFM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = SynttariDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);

            VuosiLB.Text = Math.Ceiling(erotus / 365.25).ToString() + " vuotta";
            KuukausiLB.Text = Math.Ceiling(erotus / 12).ToString() + " kuukautta";
            PaivaLB.Text = erotus.ToString() + " päivää";
            TuntiLB.Text = (erotus * 24).ToString() + " tuntia";
            MinuuttiLB.Text = (erotus * 24 * 60 ).ToString() + " minuuttia";
            SekuntiLB.Text = (erotus * 24 * 60 * 60 ).ToString() + " sekuntia";

            VuosiLB.Visible = true;
            KuukausiLB.Visible = true;
            PaivaLB.Visible = true;
            TuntiLB.Visible = true;
            MinuuttiLB.Visible = true;
            SekuntiLB.Visible = true;
        }

        private void MinuuttiLB_Click(object sender, EventArgs e)
        {

        }
    }
}