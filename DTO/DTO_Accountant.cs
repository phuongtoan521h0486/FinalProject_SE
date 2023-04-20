using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Accountant
    {
        public string AccountantID { get; set; }
        public string AccountantName { get; set; }
        public string ContactInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public DTO_Accountant(string accountantID, string accountantName, string contactInfo, string username, string password)
        {
            AccountantID = accountantID;
            AccountantName = accountantName;
            ContactInfo = contactInfo;
            Username = username;
            Password = password;
        }

        public DTO_Accountant() { }
        
    }
}
