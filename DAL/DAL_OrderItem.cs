using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_OrderItem
    {
        public DTO_OrderItem orderitem;
        public DAL_OrderItem()
        {
            orderitem = new DTO_OrderItem();
        }
        public DAL_OrderItem(string orderID, string productID, int quantity, decimal price)
        {
            orderitem = new DTO_OrderItem(orderID, productID, quantity, price);
        }

        public DAL_Order DAL_Order
        {
            get => default;
            set
            {
            }
        }

        public DAL_Product DAL_Product
        {
            get => default;
            set
            {
            }
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO [OrderItem] VALUES('{0}', '{1}', {2}, {3})",
                orderitem.OrderID, orderitem.ProductID, orderitem.Quantity, orderitem.Price);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE [OrderItem] SET Quantity = {2}, Price = {3} WHERE OrderID = '{0}' AND ProductID = '{1}'",
                orderitem.OrderID, orderitem.ProductID, orderitem.Quantity, orderitem.Price);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM [OrderItem] WHERE OrderID = '{0}' AND ProductID = '{1}'",
                orderitem.OrderID, orderitem.ProductID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM [OrderItem]";
            return Connection.selectQuery(sql);
        }

        /*public DataTable getTopDescOrderID()
        {
            string sql = "SELECT TOP 1 OrderID FROM [OrderItem] ORDER BY OrderID DESC";
            return Connection.selectQuery(sql);
        }*/
    }
}
