using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Order
    {
        DAL_Order order;

        public BUS_Order()
        {
            order = new DAL_Order();
        }

        public BUS_Order(string orderID, string orderNumber, DateTime dateOrdered, string resellerID, string orderStatus)
        {
            order = new DAL_Order(orderID, orderNumber, dateOrdered, resellerID, orderStatus);
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
            order.add();
        }

        public void update()
        {
            order.update();
        }
        public void delete()
        {
            order.delete();
        }
        public DataTable select()
        {
            return order.select();
        }

        public string generateNewOrderID()
        {
            using (DataTable table = order.getTopDescOrderID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "OR";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "OR001";
            }
        }
    }
}
