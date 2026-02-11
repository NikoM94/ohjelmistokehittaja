namespace Nimilista2
{
    struct NameInfo
    {
        public int index;
        public string gender;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            string[] fileNames = new string[]{"pojat", "tytot"};
            var nameLists = new List<List<string>>();
            string nameToFind = NimiTB.Text;
            foreach (string fileName in fileNames)
            {
                nameLists.Add(new StreamReader($"./{fileName}.txt", System.Text.Encoding.UTF8)
                    .ReadToEnd()
                    .Split("\n")
                    .Select(x => x.Trim())
                    .ToList());
            }
            foreach (var n in nameLists[1])
            {
                    VastausLB.Text += n.Trim();
            }
            NameInfo nameInfo = FindInfo(nameToFind, nameLists);
            VastausLB.Text = $"Nimesi on {nameInfo.index + 1} suosituin {nameInfo.gender} nimi vuonna 2020";
            VastausLB.Visible = true;
        }

        private NameInfo FindInfo(string nameToFind, List<List<string>> nameLists)
        {
            int nameIndex = 0;
            var info = new NameInfo();
            for (int i = 0; i < nameLists.Count(); i++)
            {
                var n = nameLists[i].AsEnumerable();
                if (nameLists[i].Where(n => n == nameToFind).Count() != 0)
                {
                    info.gender = i == 0 ? "pojan" : "tytön";
                    info.index = nameLists[i].FindIndex(n => n == nameToFind);
                    break;
                }
            }
            return info;
        }
    }
}