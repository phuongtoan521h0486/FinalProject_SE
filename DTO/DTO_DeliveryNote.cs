using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DeliveryNote
    {
        public string DeliveryNoteNumber { get; set; }
        public DateTime DateDelivered { get; set; }
        public string ResellerID { get; set; }

        public DTO_Reseller DTO_Reseller
        {
            get => default;
            set
            {
            }
        }

        public DTO_DeliveryNote(string deliveryNoteNumber, DateTime dateDelivered, string resellerID)
        {
            DeliveryNoteNumber = deliveryNoteNumber;
            DateDelivered = dateDelivered;
            ResellerID = resellerID;
        }

        public DTO_DeliveryNote()
        {
        }
    }
}
