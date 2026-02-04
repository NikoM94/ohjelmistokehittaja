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
<<<<<<< HEAD
                    VastausLB.Visible = true;
=======
>>>>>>> a7969d383d79029cb43d0cd6fcae661277983340
                }
                else
                {
                    queue.Add(Int32.Parse(UusiLukuTB.Text));
                    UusiLukuTB.Text = "";
                }
            }
<<<<<<< HEAD
=======
            VastausLB.Visible = true;
>>>>>>> a7969d383d79029cb43d0cd6fcae661277983340
        }
    }
}