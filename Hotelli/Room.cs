using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    internal class Room
    {
        public static DataTable GetRooms()
        {
            Connection connection = new Connection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(Commands.GetRoomsCommand, connection.GetConnection());
            connection.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public static bool AddRoom(RoomInfo room)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.AddRoomCommand, connection.GetConnection());
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = room.Number;
            command.Parameters.Add("@rt", MySqlDbType.VarChar).Value = room.RoomType;
            command.Parameters.Add("@free", MySqlDbType.Bit).Value = room.Free;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = room.Phone;

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

        public static bool DeleteRoom(string id)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.DeleteRoomCommand, connection.GetConnection());

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

        public static bool UpdateRoom(RoomInfo room, string id)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(Commands.UpdateRoomCommand, connection.GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = room.Number;
            command.Parameters.Add("@rt", MySqlDbType.VarChar).Value = room.RoomType;
            command.Parameters.Add("@free", MySqlDbType.Bit).Value = room.Free;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = room.Phone;

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
