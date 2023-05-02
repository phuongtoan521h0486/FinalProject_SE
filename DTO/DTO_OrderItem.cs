using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_OrderItem
    {
        public string OrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DTO_OrderItem(string orderID, string productID, int quantity, decimal price)
        {
            OrderID = orderID;
            ProductID = productID;
            Quantity = quantity;
            Price = price;
        }
        public DTO_OrderItem()
        {
        }
    }
}
