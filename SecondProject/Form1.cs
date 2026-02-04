using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject
{
    public partial class Harjoitus2FM : Form
    {
        public Harjoitus2FM()
        {
            InitializeComponent();
        }

        private void Harjoitus2FM_Load(object sender, EventArgs e)
        {
            
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string text = ViestiTB.Text;
            TulostusLB.Visible = true;
            if (text.Length > 0 )
            {
                TulostusLB.Text = text;
            }
            else
            {
                TulostusLB.Text = "Et syöttänyt tekstiä.";
                ViestiTB.Focus();
            }
        }
    }
}
