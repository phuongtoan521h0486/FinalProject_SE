using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormLoginWeb.Models
{
    public class Reseller
    {
        public string ResellerID { get; set; }
        public string ResellerName { get; set; }
        public string ContactInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PaymentMethod { get; set; }
    }
}