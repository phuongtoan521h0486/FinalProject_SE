using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Reseller
    {
        public string ResellerID { get; set; }
        public string ResellerName { get; set; }
        public string ContactInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PaymentMethod { get; set; }
        public DTO_Reseller(string resellerID, string resellerName, string contactInfo, string username, string password, string paymentMethod)
        {
            ResellerID = resellerID;
            ResellerName = resellerName;
            ContactInfo = contactInfo;
            Username = username;
            Password = password;
            PaymentMethod = paymentMethod;
        }
        public DTO_Reseller()
        {
        }
    }
}
