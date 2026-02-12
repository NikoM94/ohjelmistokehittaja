namespace Kahvio
{
    public partial class ruokaListaForm : Form
    {
        public ruokaListaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void ruokaListaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n" + 
                            "9:00 - 14:30 joka päivä maanantaista torstaihin ja perjantaisin \n" +
                            "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa lämpimien \n" +
                            "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia. \n" +
                            "Tervetuloa tutustumaan!";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            koriPL.Visible = false;
            herkutPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            koriPL.Visible = false;
            herkutPL.Visible = true;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            koriPL.Visible = true;
            herkutPL.Visible = false;
        }
    }
}