namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> queue = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char kp = e.KeyChar;
            if (kp == (char)Keys.Enter)
            {
                if (UusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] asArr = queue.ToArray();
                    Array.Sort(asArr);

                    VastausLB.Text = asArr
                        .Select(num => num.ToString())
                        .ToArray()
                        .Aggregate((prev, next) => prev + " " + next);
                }
                else
                {
                    queue.Add(Int32.Parse(UusiLukuTB.Text));
                    UusiLukuTB.Text = "";
                }
            }
            VastausLB.Visible = true;
        }
    }
}