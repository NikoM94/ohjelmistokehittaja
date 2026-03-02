using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct RoomInfo
{
    public string Number;
    public RoomType RoomType;
    public bool Free;
    public string Phone;
}

enum RoomType
{
    Single,
    Double,
    Family,
    Suite
}

namespace Hotelli
{
    public partial class HotelRoomFM : Form
    {
        public HotelRoomFM()
        {
            InitializeComponent();
        }

        private void RoomAddBT_Click(object sender, EventArgs e)
        {

        }

        private void RoomUpdateBT_Click(object sender, EventArgs e)
        {

        }

        private void RoomDeleteBT_Click(object sender, EventArgs e)
        {

        }

        private void RoomEmptyFieldsBT_Click(object sender, EventArgs e)
        {

        }
    }
}
