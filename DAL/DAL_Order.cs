using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Order
    {
        public DTO_Order order;
        public DAL_Order()
        {
            order = new DTO_Order();
        }
        public DAL_Order(string orderID, string orderNumber, DateTime dateOrdered, string resellerID, string orderStatus)
        {
            order = new DTO_Order(orderID, orderNumber, dateOrdered, resellerID, orderStatus);
        }

        public DAL_Reseller DAL_Reseller
        {
            get => default;
            set
            {
            }
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO [Order] VALUES('{0}', '{1}', '{2:yyyy-MM-dd}', '{3}', '{4}')",
                order.OrderID, order.OrderNumber, order.DateOrdered, order.ResellerID, order.OrderStatus);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE [Order] SET OrderNumber = '{1}', DateOrdered = '{2:yyyy-MM-dd}', ResellerID = '{3}', OrderStatus = '{4}' WHERE OrderID = '{0}'",
                order.OrderID, order.OrderNumber, order.DateOrdered, order.ResellerID, order.OrderStatus);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM [Order] WHERE OrderID = '{0}'",
                order.OrderID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM [Order]";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescOrderID()
        {
            string sql = "SELECT TOP 1 OrderID FROM [Order] ORDER BY OrderID DESC";
            return Connection.selectQuery(sql);
        }
    }
}
