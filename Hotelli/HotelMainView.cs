using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli
{
    public partial class HotelMainView : Form
    {
        public HotelMainView()
        {
            InitializeComponent();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelCustomerFM customerFM = new HotelCustomerFM();
            customerFM.Show();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelReservationFM reservationFM = new HotelReservationFM();
            reservationFM.Show();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
