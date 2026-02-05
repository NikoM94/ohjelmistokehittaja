namespace Autokululaskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NesteTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KilometriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, energia, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            energia = Convert.ToDouble(PolttoaineTB.Text);
            kilometrit = Convert.ToDouble(KilometriCB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + huollot + renkaat + energia + muut) / (kilometrit / 12);
            KilometriLaskuLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            KilometriLaskuLB.Visible = true;
        }
    }
}