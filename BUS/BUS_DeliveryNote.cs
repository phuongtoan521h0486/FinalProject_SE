using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_DeliveryNote
    {
        DAL_DeliveryNote deliveryNote;

        public BUS_DeliveryNote()
        {
            deliveryNote = new DAL_DeliveryNote();
        }

        public BUS_DeliveryNote(string deliveryNoteNumber, DateTime dateDelivered, string resellerID)
        {
            deliveryNote = new DAL_DeliveryNote(deliveryNoteNumber, dateDelivered, resellerID);
        }

        public BUS_Reseller BUS_Reseller
        {
            get => default;
            set
            {
            }
        }

        public void add()
        {
            deliveryNote.add();
        }

        public void update()
        {
            deliveryNote.update();
        }
        public void delete()
        {
            deliveryNote.delete();
        }
        public DataTable select()
        {
            return deliveryNote.select();
        }

        public string generateNewDeliveryNoteNumber()
        {
            using (DataTable table = deliveryNote.getTopDescDeliveryNoteNumber())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "DN";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "DN001";
            }
        }
    }
}
