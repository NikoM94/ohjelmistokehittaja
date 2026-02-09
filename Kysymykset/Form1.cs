namespace Kysymykset
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "A", "B", "B", "C", "A", "D", "D", "A", "B", "C" };
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            A_RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            B_RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            C_RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            D_RB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void radiobutton_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri <= 10)
            {
                var radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = $"Vastaus {laskuri}. kysymykseen";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                A_RB.Enabled = false;
                B_RB.Enabled = false;
                C_RB.Enabled = false;
                D_RB.Enabled = false;
                for (int j = 1; j <= 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = $"Oikeita vastauksia oli: {oikein}";
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if (A_RB.Checked)
            {
                A_RB.Checked = false;
                laskuri--;
            }
            if (B_RB.Checked)
            {
                B_RB.Checked = false;
                laskuri--;
            }
            if (C_RB.Checked)
            {
                C_RB.Checked = false;
                laskuri--;
            }
            if (D_RB.Checked)
            {
                D_RB.Checked = false;
                laskuri--;
            }
        }

        private void A_RB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}