using System.Text;
namespace RoomalaisetNumerot
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> latinToRoman = new Dictionary<int, string>() {
            { 1,    "I" },
            { 4,    "IV" },
            { 5,    "V" },
            { 9,    "IX" },
            { 10,   "X" },
            { 19,   "XIX" },
            { 50,   "L" },
            { 90,   "XC" },
            { 100,  "C" },
            { 400,  "CD" },
            { 500,  "D" },
            { 900,  "CM" },
            { 1000, "M" },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            string latin = InputTB.Text;
            if (!AllDigits(latin))
            {
                return;
            }

            if (Convert.ToInt32(latin) > 3999 || Convert.ToInt32(latin) < 1)
            {
                VastausLB.Text = "Numero liian suuri tai liian pieni";
                VastausLB.Visible = true;
                return;
            }

            var sb = new StringBuilder();
            int currIndex = 0;
            char[] chars = latin.ToCharArray();
            int iters = chars[currIndex] - 48;

            int len = latin.Length;

            // tuhannet
            if (len == 4)
            {
                for (int i = 0; i < iters; i++)
                {
                    sb.Append(latinToRoman.GetValueOrDefault(1000));
                }
                len--;
                currIndex++;
            }
            // sadat
            if (len == 3)
            {
                sb.Append(AppendNths(chars[currIndex], 100, 400, 500, 900));
                len--;
                currIndex++;
            }

            if (len == 2)
            {
                sb.Append(AppendNths(chars[currIndex], 10, 40, 50, 90));
                len--;
                currIndex++;
            }
            if (len == 1)
            {
                sb.Append(AppendNths(chars[currIndex], 1, 4, 5, 9));
            }
            VastausLB.Text = sb.ToString();
            VastausLB.Visible = true;
        }

        private string AppendNths(char curr, int ones, int fours, int fives, int nines)
        {
            var sb = new StringBuilder();
            if (curr - 48 <= 3)
            {
                int iters = (curr - 48) - 5;
                for (int i = 0; i < iters; i++)
                {
                    sb.Append(latinToRoman.GetValueOrDefault(ones));
                }
            }
            else if (curr - 48 == 4)
            {
                sb.Append(latinToRoman.GetValueOrDefault(fours));
            }

            else if (curr - 48 == 5)
            {
                sb.Append(latinToRoman.GetValueOrDefault(fives));
            }
            else if (curr - 48 > 5 && curr - 48 < 9)
            {
                sb.Append(latinToRoman.GetValueOrDefault(fives));
                for (int i = 0; i < curr - 48 - 5; i++)
                {
                    sb.Append(latinToRoman.GetValueOrDefault(ones));
                }
            }
            else if (curr - 48 == 9)
            {
                sb.Append(latinToRoman.GetValueOrDefault(nines));
            }
            return sb.ToString();
        }

        private bool AllDigits(string latin)
        {
            char[] chars = latin.ToCharArray();
            foreach (char c in chars)
            {
                // numeroiden 0-9 ASCII-arvot ovat 48-57
                if (c < 48 || c > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}