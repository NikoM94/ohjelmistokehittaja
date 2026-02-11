using System.Diagnostics;

namespace Ajastin
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}