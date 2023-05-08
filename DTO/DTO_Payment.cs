using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Payment
    {
        public string PaymentID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public string OrderID { get; set; }
        public string ResellerID { get; set; }

        public DTO_Reseller DTO_Reseller
        {
            get => default;
            set
            {
            }
        }

        public DTO_Order DTO_Order
        {
            get => default;
            set
            {
            }
        }

        public DTO_Payment(string paymentID, decimal amount, DateTime paymentDate, string paymentStatus, string orderID, string resellerID)
        {
            PaymentID = paymentID;
            Amount = amount;
            PaymentDate = paymentDate;
            PaymentStatus = paymentStatus;
            OrderID = orderID;
            ResellerID = resellerID;
        }
        public DTO_Payment()
        {
        }
    }
}
