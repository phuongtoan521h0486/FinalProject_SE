using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_OrderItem
    {
        DAL_OrderItem orderItem;

        public BUS_OrderItem()
        {
            orderItem = new DAL_OrderItem();
        }

        public BUS_OrderItem(string orderID, string productID, int quantity, decimal price)
        {
            orderItem = new DAL_OrderItem(orderID, productID, quantity, price);
        }

        public void add()
        {
            orderItem.add();
        }

        public void update()
        {
            orderItem.update();
        }
        public void delete()
        {
            orderItem.delete();
        }
        public DataTable select()
        {
            return orderItem.select();
        }
    }
}
