using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    internal class Commands
    {
        public readonly static string GetCustomersCommand = "SELECT customerid, firstname, lastname, address, postcode, postalarea FROM customers";

        public readonly static string DeleteCustomerCommand = "DELETE FROM customers WHERE customerid = @id";

        public readonly static string AddCustomerCommand = "INSERT INTO customers " +
                                                    "(firstname, lastname, address, postcode, postalarea, username, password) " +
                                                    "VALUES (@fn, @ln, @addr, @pscode, @psarea, @usn, @pw)";

        public readonly static string UpdateCustomerCommand = @"UPDATE customers 
                                                     SET firstname = @fn, 
                                                         lastname = @ln, 
                                                         address = @addr, 
                                                         postcode = @pc, 
                                                         postalarea = @pa, 
                                                         username = @user, 
                                                         `password` = @pass 
                                                     WHERE customerid = @id";

        public readonly static string AddRoomCommand = "INSERT INTO rooms" +
                                              "(roomnumber, roomtype, isfree, phone) " +
                                              "VALUES (@num, @rt, @free, @phn)";

        public readonly static string GetRoomsCommand = "SELECT id, roomnumber, roomtype, CASE WHEN isfree = 1 THEN 'Kyllä' ELSE 'Ei' END AS isfree, phone FROM rooms";

        public readonly static string DeleteRoomCommand = "DELETE FROM rooms WHERE id = @id";

        public readonly static string UpdateRoomCommand = @"UPDATE rooms 
                                                     SET roomnumber = @num, 
                                                         roomtype = @rt, 
                                                         isfree = @free, 
                                                         phone = @phn, 
                                                     WHERE roomid = @id";

        public static string AddReservationCommand = "TODO";

        public static string GetReservationsCommand = "TODO";

        public static string DeleteReservationCommand = "TODO";

        public static string UpdateReservationCommand = "TODO";
    }
}
