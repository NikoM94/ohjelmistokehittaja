namespace SalasananTarkistus
{
    public partial class SalasanaFM : Form
    {
        string username = "root";
        string password = "root";
        public SalasanaFM()
        {
            InitializeComponent();
        }

        private void TarkistaTB_Click(object sender, EventArgs e)
        {
            string usernameInput = KayttajaTB.Text;
            string passwordInput = SalasanaTB.Text;

            if (usernameInput == username && passwordInput == password)
            {
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheLB.Text = "V‰‰r‰ k‰ytt‰j‰nimi tai salasana.";
                VirheLB.Visible = true;
            }    
        }
    }
}