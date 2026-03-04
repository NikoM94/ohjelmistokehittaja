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
        DataTable rooms = new DataTable();
        public HotelRoomFM()
        {
            InitializeComponent();
        }

        private void RoomAddBT_Click(object sender, EventArgs e)
        {
            RoomInfo newRoom = new RoomInfo
            {
                Number = RoomRoomNumberTB.Text,
                RoomType = Room.ConvertToRoomType(RoomRoomTypeCB.Text),
                Free = RoomFreeNoRB.Checked ? false : true,
                Phone = RoomPhoneTB.Text,
            };

            if (rooms.Columns.Contains(RoomRoomNumberTB.Text))
            {
                MessageBox.Show("Room number already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Room.AddRoom(newRoom);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Room added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rooms = Room.GetRooms();
            RoomDG.DataSource = rooms;
        }

        private void RoomUpdateBT_Click(object sender, EventArgs e)
        {
            if (RoomDG.CurrentRow == null)
            {
                return;
            }

            string? id = RoomDG.CurrentRow.Cells["id"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RoomInfo roomToUpdate = new RoomInfo
            {
                Number = RoomRoomNumberTB.Text,
                RoomType = Room.ConvertToRoomType(RoomRoomTypeCB.Text),
                Free = RoomFreeNoRB.Checked ? false : true,
                Phone = RoomPhoneTB.Text,
            };

            if (rooms.Columns.Contains(RoomRoomNumberTB.Text))
            {
                MessageBox.Show("Room number already exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Room.UpdateRoom(roomToUpdate, id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Room deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rooms = Room.GetRooms();
            RoomDG.DataSource = rooms;
        }

        private void RoomDeleteBT_Click(object sender, EventArgs e)
        {
            if (RoomDG.CurrentRow == null)
            {
                return;
            }

            string? id = RoomDG.CurrentRow.Cells["id"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Room.DeleteRoom(id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Room deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rooms = Room.GetRooms();
            RoomDG.DataSource = rooms;
        }

        private void RoomEmptyFieldsBT_Click(object sender, EventArgs e)
        {
            RoomRoomNumberTB.Text = "";
            RoomPhoneTB.Text = "";
            RoomFreeNoRB.Checked = false;
            RoomFreeYesRB.Checked = false;
        }

        private void HotelRoomFM_Load(object sender, EventArgs e)
        {
            RoomDG.DataSource = Room.GetRooms();
            FillRoomTypeCBFields();
            RoomFreeYesRB.Checked = true;
        }

        private void FillRoomTypeCBFields()
        {
            RoomRoomTypeCB.Items.Add(RoomType.Single);
            RoomRoomTypeCB.Items.Add(RoomType.Double);
            RoomRoomTypeCB.Items.Add(RoomType.Family);
            RoomRoomTypeCB.Items.Add(RoomType.Suite);
        }

        private void RoomFreeYesRB_CheckedChanged(object sender, EventArgs e)
        {
            RoomFreeNoRB.Checked = !RoomFreeYesRB.Checked;
        }

        private void RoomFreeNoRB_CheckedChanged(object sender, EventArgs e)
        {
            RoomFreeYesRB.Checked = !RoomFreeNoRB.Checked;
        }

        private void RoomDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var roomValues = RoomDG.Rows[e.RowIndex].Cells;
            RoomRoomNumberTB.Text = roomValues["roomnumber"].Value.ToString();
            RoomRoomTypeCB.Text = roomValues["roomtype"].Value.ToString();
            bool free = roomValues["isfree"].Value.ToString() == "Kyllä";
            if (free)
            {
                RoomFreeYesRB.Checked = true;
                RoomFreeNoRB.Checked = false;
            }
            else
            {
                RoomFreeYesRB.Checked = false;
                RoomFreeNoRB.Checked = true;
            }
            RoomPhoneTB.Text = roomValues["phone"].Value.ToString();
        }
    }
}
