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

namespace Hotelli
{
    static internal class InputValidator
    {
        private const string NameRegex = @"^[a-zA-ZåäöÅÄÖ]{1,25}$";
        private const string AddressRegex = @"^[a-zA-Z0-9åäöÅÄÖ\s]{1,40}$";
        private const string PostcodeRegex = @"^\d{1,10}$";
        private const string CityRegex = @"^[a-zA-ZåäöÅÄÖ\s]{1,25}$";
        private const string UserNameRegex = @"^[a-zA-Z0-9åäöÅÄÖ]{3,25}$";
        private const string PassWordRegex = @"^.{12,25}$";

        public static ValidFields ValidateUserRegistration(string firstName, string lastName, string address, string postcode, string city, string userName, string password)
        {
            return new ValidFields
            {
                FirstName = Regex.IsMatch(firstName, NameRegex),
                LastName = Regex.IsMatch(lastName, NameRegex),
                Address = Regex.IsMatch(address, AddressRegex),
                Postcode = Regex.IsMatch(postcode, PostcodeRegex),
                City = Regex.IsMatch(city, CityRegex),
                Username = Regex.IsMatch(userName, UserNameRegex),
                Password = Regex.IsMatch(password, PassWordRegex)
            };
        }
    }
}
