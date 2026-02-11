namespace Ajastin
{
    public partial class Form1 : Form
    {
        private int totalTime;
        public Form1()
        {
            InitializeComponent();
            StopBT.Enabled = false;
            for (int i = 0; i <= 59; i++)
            {
                MinutesCB.Items.Add(i.ToString());
                SecondsCB.Items.Add(i.ToString());
            }
            MinutesCB.SelectedIndex = 1; 
            SecondsCB.SelectedIndex = 7;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minutes = int.Parse(MinutesCB.SelectedItem.ToString());
            int seconds = int.Parse(SecondsCB.SelectedItem.ToString());
            totalTime = (minutes * 60) + seconds;
            timer1.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            totalTime = 0;
            timer1.Enabled = false;
            TimerLB.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalTime > 0)
            {
                totalTime--;
                int minutes = totalTime / 60;
                int seconds = totalTime - (minutes * 60);
                string minutesDisplay = minutes.ToString().Length == 1 ? $"0{minutes}" : $"{minutes}";
                string secondsDisplay = seconds.ToString().Length == 1 ? $"0{seconds}" : $"{seconds}";
                TimerLB.Text = $"{minutesDisplay}:{secondsDisplay}";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}