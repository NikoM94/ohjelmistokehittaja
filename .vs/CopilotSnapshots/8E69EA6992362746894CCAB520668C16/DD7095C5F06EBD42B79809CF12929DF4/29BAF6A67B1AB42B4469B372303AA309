using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

struct ValidFields
{
    public bool FirstName;
    public bool LastName;
    public bool Address;
    public bool Postcode;
    public bool City;
    public bool Username;
    public bool Password;
}

namespace Hotelli.Utilities
{
    static internal class InputValidator
    {
        private const string NameRegex = @"^[a-zA-ZåäöÅÄÖ]{1,25}$";
        private const string AddressRegex = @"^[a-zA-Z0-9åäöÅÄÖ\s]{1,40}$";
        private const string PostcodeRegex = @"^\d{1,10}$";
        private const string CityRegex = @"^[a-zA-ZåäöÅÄÖ\s]{1,25}$";
        private const string UserNameRegex = @"^[a-zA-Z0-9åäöÅÄÖ]{3,25}$";
        private const string PassWordRegex = @"^.{12,25}$";

        public static ValidFields ValidateUserRegistration(CustomerInfo customer)
        {
            return new ValidFields
            {
                FirstName = Regex.IsMatch(customer.FirstName, NameRegex),
                LastName = Regex.IsMatch(customer.LastName, NameRegex),
                Address = Regex.IsMatch(customer.Address, AddressRegex),
                Postcode = Regex.IsMatch(customer.Postcode, PostcodeRegex),
                City = Regex.IsMatch(customer.City, CityRegex),
                Username = Regex.IsMatch(customer.Username, UserNameRegex),
                Password = Regex.IsMatch(customer.Password, PassWordRegex)
            };
        }
        public static string BuildErrorMessage(ValidFields fields)
        {
            StringBuilder sb = new StringBuilder();
            if (!fields.FirstName)
            {
                sb.Append("invalid first name, ");
            }
            if (!fields.LastName)
            {
                sb.Append("invalid last name, ");
            }
            if (!fields.Address)
            {
                sb.Append("invalid address, ");
            }
            if (!fields.Postcode)
            {
                sb.Append("invalid post code, ");
            }
            if (!fields.City)
            {
                sb.Append("invalid city, ");
            }
            if (!fields.Username)
            {
                sb.Append("invalid invalid user name, ");
            }
            if (!fields.Password)
            {
                sb.Append("invalid password, ");
            }
            
            if (sb.ToString().Length > 0)
            {
                return sb.ToString().Trim();
            }
            return "";
        }
    }
}
