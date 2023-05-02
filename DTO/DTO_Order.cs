using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Order
    {
        public string OrderID { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateOrdered { get; set; }
        public string ResellerID { get; set; }
        public string OrderStatus { get; set; }
        public DTO_Order(string orderID, string orderNumber, DateTime dateOrdered, string resellerID, string orderStatus)
        {
            OrderID = orderID;
            OrderNumber = orderNumber;
            DateOrdered = dateOrdered;
            ResellerID = resellerID;
            OrderStatus = orderStatus;
        }
        public DTO_Order()
        {
        }
    }
}
