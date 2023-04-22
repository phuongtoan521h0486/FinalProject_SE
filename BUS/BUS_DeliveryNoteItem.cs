using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DeliveryNoteItem
    {
        DAL_DeliveryNoteItem deliveryNoteItem;

        public BUS_DeliveryNoteItem()
        {
            deliveryNoteItem = new DAL_DeliveryNoteItem();
        }

        public BUS_DeliveryNoteItem(string deliveryNoteNumber, string productID, int quantity)
        {
            deliveryNoteItem = new DAL_DeliveryNoteItem(deliveryNoteNumber, productID, quantity);
        }

        public void add()
        {
            deliveryNoteItem.add();
        }

        public void update()
        {
            deliveryNoteItem.update();
        }
        public void delete()
        {
            deliveryNoteItem.delete();
        }
        public DataTable select()
        {
            return deliveryNoteItem.select();
        }
    }
}
