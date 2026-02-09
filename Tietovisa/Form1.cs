namespace Tietovisa
{
    public partial class Form1 : Form
    {
        string[] answers = new string[4];
        string[] correct = new string[]{"A", "C", "D", "B"};
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckAnswersBT_Click(object sender, EventArgs e)
        {
            answers[0] = GetAnswer(Q1GB);
            answers[1] = GetAnswer(Q2GB);
            answers[2] = GetAnswer(Q3GB);
            answers[3] = GetAnswer(Q4GB);

            int score = CountAnswers();
            ResultLB.Text = $"Sait {score} / 4 vastausta oikein.";
            ResultLB.Visible = true;
        }

        private int CountAnswers()
        {
            int count = 0;
            for (int i = 0; i < correct.Length; i++)
            {
                if (correct[i] == answers[i])
                {
                    count++;
                }
            }
            return count;
        }

        private string GetAnswer(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        return rb.Text.Substring(0, 1);
                    }
                }
            }
            return "";
        }
    }
}