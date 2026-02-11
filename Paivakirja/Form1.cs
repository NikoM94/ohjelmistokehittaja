namespace Paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InputTB.Text = File.ReadAllText("./diary.txt");
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string text = $"{InputTB.Text} {DateTime.Now.ToString("dd:MM:yyyy HH:mm")}\n";
            var tw = new StreamWriter("./diary.txt");
            tw.Write(text);
            tw.Close();
            Application.Exit();
        }
    }
}