using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DeliveryNote
    {
        public DTO_DeliveryNote deliveryNote;
        public DAL_DeliveryNote()
        {
            deliveryNote = new DTO_DeliveryNote();
        }
        public DAL_DeliveryNote(string deliveryNoteNumber, DateTime dateDelivered, string resellerID)
        {
            deliveryNote = new DTO_DeliveryNote(deliveryNoteNumber, dateDelivered, resellerID);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO DeliveryNote VALUES('{0}', '{1:yyyy-MM-dd}', '{2}')",
                deliveryNote.DeliveryNoteNumber, deliveryNote.DateDelivered, deliveryNote.ResellerID);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE DeliveryNote SET DateDelivered = '{1:yyyy-MM-dd}', ResellerID = '{2}'WHERE DeliveryNoteNumber = '{0}'",
                deliveryNote.DeliveryNoteNumber, deliveryNote.DateDelivered, deliveryNote.ResellerID);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM DeliveryNote WHERE DeliveryNoteNumber = '{0}'",
                deliveryNote.DeliveryNoteNumber);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM DeliveryNote";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescDeliveryNoteNumber()
        {
            string sql = "SELECT TOP 1 DeliveryNoteNumber FROM DeliveryNote ORDER BY DeliveryNoteNumber DESC";
            return Connection.selectQuery(sql);
        }
    }
}
