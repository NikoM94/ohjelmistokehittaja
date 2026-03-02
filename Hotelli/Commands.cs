using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    internal class Commands
    {
        public static string GetCustomersCommand = "SELECT customerid, firstname, lastname, address, postcode, postalarea FROM customers";

        public static string DeleteCustomerCommand = "DELETE FROM customers WHERE customerid = @id";

        public static string AddCustomerCommand = "INSERT INTO customers " +
                                                    "(firstname, lastname, address, postcode, postalarea, username, password) " +
                                                    "VALUES (@fn, @ln, @addr, @pscode, @psarea, @usn, @pw)";

        public static string UpdateCustomerCommand = @"UPDATE customers 
                                                     SET firstname = @fn, 
                                                         lastname = @ln, 
                                                         address = @addr, 
                                                         postcode = @pc, 
                                                         postalarea = @pa, 
                                                         username = @user, 
                                                         `password` = @pass 
                                                     WHERE customerid = @id";
    }
}
