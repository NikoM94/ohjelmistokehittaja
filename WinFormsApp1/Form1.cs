namespace WinFormsApp1; 
public partial class OpiskelijahallintaFM : Form {

    private Opiskelijahallinta.Student student = new Opiskelijahallinta.Student();
    public OpiskelijahallintaFM()
    {
        InitializeComponent();
    }

    private void OpiskelijahallintaFM_Load(object sender, EventArgs e)
    {
        dbviewDG.DataSource = student.GetStudents();
    }

    private void saveBT_Click(object sender, EventArgs e)
    {
        String firstName = etunimiTB.Text;
        String lastName = sukunimiTB.Text;
        String phone = puhelinTB.Text;
        String email = emailTB.Text;
        int sNum = Int32.Parse(oNumeroTB.Text);

        if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals("") || sNum.ToString().Trim().Equals(""))
        {
            MessageBox.Show("VIRHE  Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Boolean addStudent = student.AddStudent(firstName, lastName, phone, email, sNum);
        if (addStudent)
        {
            MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        dbviewDG.DataSource = student.GetStudents();
    }

    private void updateBT_Click(object sender, EventArgs e)
    { 
        String firstName = etunimiTB.Text;
        String lastName = sukunimiTB.Text;
        String phone = puhelinTB.Text;
        String email = emailTB.Text;
        int sNum = Int32.Parse(oNumeroTB.Text);
        int sid = Int32.Parse(idTB.Text);

        if (sid.ToString().Trim().Equals("") || firstName.Trim().Equals("") || lastName.Trim().Equals("") || phone.Trim().Equals("") || email.Trim().Equals("") || sNum.ToString().Trim().Equals(""))
        {
            MessageBox.Show("VIRHE  Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Boolean addStudent = student.UpdateStudent(sid, firstName, lastName, phone, email, sNum);
        if (addStudent)
        {
            MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        dbviewDG.DataSource = student.GetStudents();

    }

    private void deleteBT_Click(object sender, EventArgs e)
    {
        String uName = idTB.Text;
        if (student.DeleteStudent(uName))
        {
            dbviewDG.DataSource = student.GetStudents();
            MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        emptyBT.PerformClick();
    }

    private void dbviewDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        idTB.Text = dbviewDG.CurrentRow.Cells[0].Value.ToString();
        etunimiTB.Text = dbviewDG.CurrentRow.Cells[1].Value.ToString();
        sukunimiTB.Text = dbviewDG.CurrentRow.Cells[2].Value.ToString();
        puhelinTB.Text = dbviewDG.CurrentRow.Cells[3].Value.ToString();
        emailTB.Text = dbviewDG.CurrentRow.Cells[4].Value.ToString();
        oNumeroTB.Text = dbviewDG.CurrentRow.Cells[5].Value.ToString();
    }
}