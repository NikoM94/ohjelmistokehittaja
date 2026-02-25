using System.Data;

namespace OppilaitoksenTiedot { 
   public partial class OppilaitosFM : Form { 

        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable yhteys = new DataTable();

        public OppilaitosFM()
        {
            InitializeComponent();
        }

        private void OppilaitosFM_Load(object sender, EventArgs e)
        {
            TaytaOppilaitosTaulukko();
            TaytaVastuuHenkilotTaulukko();
            oppiLaitosCB.DataSource = oppilaitos;
            oppiLaitosCB.DisplayMember = "ONimi";
        }

        private void oppiLaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? viite = oppilaitos.Rows[oppiLaitosCB.SelectedIndex]["OID"].ToString(); 
            katuosoiteLB.Text = oppilaitos.Rows[oppiLaitosCB.SelectedIndex]["OKatuosoite"].ToString();
            postinumeroLB.Text = oppilaitos.Rows[oppiLaitosCB.SelectedIndex]["OPostinumero"].ToString();
            postitoimipaikkaLB.Text = oppilaitos.Rows[oppiLaitosCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            puhelinLB.Text = oppilaitos.Rows[oppiLaitosCB.SelectedIndex]["OPuhelin"].ToString();

            yhteys = vastuuHenkilot.Select("OID =" + viite).CopyToDataTable();
            vastuuHloCB.DataSource = yhteys;
            vastuuHloCB.DisplayMember = "VNimi";

        }
        private void vastuuHloCB_TextChanged(object sender, EventArgs e)
        {
            titteliLB.Text = yhteys.Rows[vastuuHloCB.SelectedIndex]["VTitteli"].ToString();
            sijaintiLB.Text = yhteys.Rows[vastuuHloCB.SelectedIndex]["VSijainti"].ToString();
            emailLB.Text = yhteys.Rows[vastuuHloCB.SelectedIndex]["VSahkoposti"].ToString();
            phoneLB.Text = yhteys.Rows[vastuuHloCB.SelectedIndex]["VPuhelin"].ToString();
        }

        private void TaytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID", typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksenkatu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");
        }

        private void TaytaVastuuHenkilotTaulukko()
        {
            vastuuHenkilot.Columns.Add("OID", typeof(int));
            vastuuHenkilot.Columns.Add("VNimi");
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VSijainti");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");

            vastuuHenkilot.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050, 540, 4434");
            vastuuHenkilot.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kampus 2", "hanna.laurila@hel.fi", "040 676 5583");
            vastuuHenkilot.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            vastuuHenkilot.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            vastuuHenkilot.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            vastuuHenkilot.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "Ei puhelinnumeroa");
            vastuuHenkilot.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            vastuuHenkilot.Rows.Add(2, "Tuukka Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            vastuuHenkilot.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            vastuuHenkilot.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija.aaltola@omnia.fi", "050 384 9354");
            vastuuHenkilot.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            vastuuHenkilot.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            vastuuHenkilot.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "Ei sijaintia", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            vastuuHenkilot.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "Ei sijaintia", "anne.heinonen@vantaa.fi", "040 524 1242");
            vastuuHenkilot.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "Ei sijaintia", "tuula.kiistinen@vantaa.fi", "040 193 9048");
            vastuuHenkilot.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            vastuuHenkilot.Rows.Add(4, "Anne Mari Leinonen", "Rehtori", "Hallinto", "anne-mari.leinonen@keuda.fi", "040 174 4523");
            vastuuHenkilot.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            vastuuHenkilot.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            vastuuHenkilot.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }
    }
}