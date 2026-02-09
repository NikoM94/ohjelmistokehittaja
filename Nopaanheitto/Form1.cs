namespace Nopaanheitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            DrawDice(Noppa01PB); 
            DrawDice(Noppa02PB); 
        }

        private void DrawDice(PictureBox DiceBox)
        {
            int dice = new Random().Next(1, 7);

            switch (dice)
            {
                case 1:
                    DiceBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    DiceBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    DiceBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    DiceBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    DiceBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    DiceBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}