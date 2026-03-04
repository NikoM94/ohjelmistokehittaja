using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct ReservationInfo
{
    public string ReservationNumber;
    public string CustomerNumber;
    public RoomType RoomType;
    public string RoomNumber;
    public DateTime In;
    public DateTime Out;
}

namespace Hotelli
{
    public partial class HotelReservationFM : Form
    {
        DataTable reservations = new DataTable();
        public HotelReservationFM()
        {
            InitializeComponent();
        }

        private void ReservationAddBT_Click(object sender, EventArgs e)
        {
            ReservationInfo newReservation = new ReservationInfo
            {
                ReservationNumber = ReservationNumberTB.Text,
                CustomerNumber = ReservationCustomerNumberCB.Text,
                RoomType = Room.ConvertToRoomType(ReservationRoomTypeCB.Text),
                RoomNumber = ReservationRoomNumberCB.Text,
                In = ReservationInDTP.Value,
                Out = ReservationOutDTP.Value
            };

            bool result = Reservation.AddReservation(newReservation);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Reservation added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reservations = Reservation.GetReservations();
            ReservationDG.DataSource = reservations;
            PopulateOnUpdate();
        }

        private void ReservationUpdateBT_Click(object sender, EventArgs e)
        {
            if (ReservationDG.CurrentRow == null)
            {
                return;
            }

            string? id = ReservationDG.CurrentRow.Cells["id"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReservationInfo reservationToUpdate = new ReservationInfo
            {
                ReservationNumber = ReservationNumberTB.Text,
                CustomerNumber = ReservationCustomerNumberCB.Text,
                RoomType = Room.ConvertToRoomType(ReservationRoomTypeCB.Text),
                RoomNumber = ReservationRoomNumberCB.Text,
                In = ReservationInDTP.Value,
                Out = ReservationOutDTP.Value
            };

            bool result = Reservation.UpdateReservation(reservationToUpdate, id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Reservation updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reservations = Reservation.GetReservations();
            ReservationDG.DataSource = reservations;
            PopulateOnUpdate();
        }

        private void ReservationDeleteBT_Click(object sender, EventArgs e)
        {
            if (ReservationDG.CurrentRow == null)
            {
                return;
            }

            string? id = ReservationDG.CurrentRow.Cells["id"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Reservation.DeleteReservation(id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Reservation deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reservations = Reservation.GetReservations();
            ReservationDG.DataSource = reservations;
            PopulateOnUpdate();
        }

        private void ReservationEmptyFieldsBT_Click(object sender, EventArgs e)
        {
            ReservationNumberTB.Text = "";
            ReservationCustomerNumberCB.Text = "";
            ReservationRoomTypeCB.Text = "";
            ReservationRoomNumberCB.Text = "";
            ReservationInDTP.Value = DateTime.Now;
            ReservationOutDTP.Value = DateTime.Now;
        }

        private void HotelReservationFM_Load(object sender, EventArgs e)
        {
            reservations = Reservation.GetReservations();
            ReservationDG.DataSource = reservations;
            PopulateOnUpdate();
        }

        private void PopulateOnUpdate()
        {
            PopulateRoomTypeCB();
            PopulateCustomerNumberCB();
            PopulateRoomNumberCB();
        }

        private void PopulateCustomerNumberCB()
        {
            ReservationCustomerNumberCB.DisplayMember = "customernumber";
            ReservationCustomerNumberCB.DataSource = reservations;
        }

        private void PopulateRoomTypeCB()
        {
            ReservationRoomTypeCB.DataSource = new List<string>
            {
                "Single",
                "Double",
                "Family",
                "Suite"
            };
        }

        private void PopulateRoomNumberCB()
        {
            ReservationRoomNumberCB.DisplayMember = "roomnumber";
            ReservationRoomNumberCB.DataSource = reservations;
        }

        private void ReservationDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var reservationValues = ReservationDG.Rows[e.RowIndex].Cells;
            ReservationNumberTB.Text = reservationValues["reservationnumber"].Value.ToString();
            ReservationCustomerNumberCB.Text = reservationValues["customernumber"].Value.ToString();
            ReservationRoomTypeCB.Text = reservationValues["roomtype"].Value.ToString();
            ReservationRoomNumberCB.Text = reservationValues["roomnumber"].Value.ToString();
            ReservationInDTP.Value = (DateTime)reservationValues["indate"].Value;
            ReservationOutDTP.Value = (DateTime)reservationValues["outdate"].Value;
        }
    }
}
