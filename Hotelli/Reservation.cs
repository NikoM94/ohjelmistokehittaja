using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    internal class Reservation
    {
        public static DataTable GetReservations()
        {
            Connection connection = new Connection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(Commands.GetReservationsCommand, connection.GetConnection());
            connection.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            connection.CloseConnection();
            return table;
        }

        public static bool AddReservation(ReservationInfo reservation)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.AddReservationCommand, connection.GetConnection());
            command.Parameters.Add("@resnum", MySqlDbType.VarChar).Value = reservation.ReservationNumber;
            command.Parameters.Add("@cnum", MySqlDbType.VarChar).Value = reservation.CustomerNumber;
            command.Parameters.Add("@rt", MySqlDbType.VarChar).Value = reservation.RoomType;
            command.Parameters.Add("@rnum", MySqlDbType.VarChar).Value = reservation.RoomNumber;
            command.Parameters.Add("@ind", MySqlDbType.Date).Value = reservation.In;
            command.Parameters.Add("@outd", MySqlDbType.Date).Value = reservation.Out;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        public static bool DeleteReservation(string id)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.DeleteReservationCommand, connection.GetConnection());

            command.Parameters.AddWithValue("@id", id);

            connection.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        public static bool UpdateReservation(ReservationInfo reservation, string id)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.UpdateReservationCommand, connection.GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.Add("@resnum", MySqlDbType.VarChar).Value = reservation.ReservationNumber;
            command.Parameters.Add("@cnum", MySqlDbType.VarChar).Value = reservation.CustomerNumber;
            command.Parameters.Add("@rt", MySqlDbType.VarChar).Value = reservation.RoomType;
            command.Parameters.Add("@rnum", MySqlDbType.VarChar).Value = reservation.RoomNumber;
            command.Parameters.Add("@ind", MySqlDbType.Date).Value = reservation.In;
            command.Parameters.Add("@outd", MySqlDbType.Date).Value = reservation.Out;

            connection.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }
    }
}
