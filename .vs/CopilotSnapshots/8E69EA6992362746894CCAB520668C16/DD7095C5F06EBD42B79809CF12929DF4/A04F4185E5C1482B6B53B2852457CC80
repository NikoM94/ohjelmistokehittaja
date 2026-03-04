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
                                                                 phone = @phn 
                                                             WHERE id = @id";

        public readonly static string AddReservationCommand = "INSERT INTO reservations " +
                                                     "(reservationnumber, customernumber, roomtype, roomnumber, indate, outdate) " + 
                                                     "VALUES (@resnum, @cnum, @rt, @rnum, @ind, @outd)";

        public readonly static string GetReservationsCommand = "SELECT * FROM reservations";

        public readonly static string DeleteReservationCommand = "DELETE FROM reservations WHERE id = @id";

        public readonly static string UpdateReservationCommand = @"UPDATE reservations 
                                                             SET reservationnumber = @resnum, 
                                                                 customernumber = @cnum, 
                                                                 roomtype = @rt, 
                                                                 roomnumber = @rnum, 
                                                                 indate = @ind, 
                                                                 outdate = @outd 
                                                             WHERE id = @id";

    }
}
