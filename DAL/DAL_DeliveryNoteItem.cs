using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DeliveryNoteItem
    {
        public DTO_DeliveryNoteItem deliveryNoteItem;
        public DAL_DeliveryNoteItem()
        {
            deliveryNoteItem = new DTO_DeliveryNoteItem();
        }
        public DAL_DeliveryNoteItem(string deliveryNoteNumber, string productID, int quantity)
        {
            deliveryNoteItem = new DTO_DeliveryNoteItem(deliveryNoteNumber, productID, quantity);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO DeliveryNoteItem VALUES('{0}', '{1}', {2})",
                deliveryNoteItem.DeliveryNoteNumber, deliveryNoteItem.ProductID, deliveryNoteItem.Quantity);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE DeliveryNoteItem SET Quantity = {2} WHERE DeliveryNoteNumber = '{0}' AND ProductID = '{1}'",
                deliveryNoteItem.DeliveryNoteNumber, deliveryNoteItem.ProductID, deliveryNoteItem.Quantity);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM DeliveryNoteItem WHERE DeliveryNoteNumber = '{0}' AND ProductID = '{1}'",
                deliveryNoteItem.DeliveryNoteNumber, deliveryNoteItem.ProductID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM DeliveryNoteItem";
            return Connection.selectQuery(sql);
        }

        /*public DataTable getTopDescDeliveryNoteNumber()
        {
            string sql = "SELECT TOP 1 DeliveryNoteNumber FROM DeliveryNoteItem ORDER BY DeliveryNoteNumber DESC";
            return Connection.selectQuery(sql);
        }*/
    }
}
