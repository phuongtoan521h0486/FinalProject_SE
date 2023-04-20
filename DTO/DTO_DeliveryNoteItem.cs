using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DeliveryNoteItem
    {
        public string DeliveryNoteNumber { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public DTO_DeliveryNoteItem(string deliveryNoteNumber, string productID, int quantity)
        {
            DeliveryNoteNumber = deliveryNoteNumber;
            ProductID = productID;
            Quantity = quantity;
        }

        public DTO_DeliveryNoteItem()
        {
        }
    }
}
