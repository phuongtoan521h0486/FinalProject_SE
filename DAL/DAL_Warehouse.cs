using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Warehouse
    {
        public DTO_Warehouse warehouse;
        public DAL_Warehouse()
        {
            warehouse = new DTO_Warehouse();
        }
        public DAL_Warehouse(string warehouseReceiptNumber, DateTime dateReceived, string productID, int quantity)
        {
            warehouse = new DTO_Warehouse(warehouseReceiptNumber, dateReceived, productID, quantity);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Warehouse VALUES('{0}', '{1:yyyy-MM-dd}', '{2}', {3})",
                warehouse.WarehouseReceiptNumber, warehouse.DateReceived, warehouse.ProductID, warehouse.Quantity);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Warehouse SET DateReceived = '{1:yyyy-MM-dd}', Quantity = {3} WHERE WarehouseReceiptNumber = '{0}' AND ProductID = '{2}'",
                warehouse.WarehouseReceiptNumber, warehouse.DateReceived, warehouse.ProductID, warehouse.Quantity);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Warehouse WHERE WarehouseReceiptNumber = '{0}' AND ProductID = '{2}'",
                warehouse.WarehouseReceiptNumber, warehouse.ProductID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Warehouse";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescWarehouseReceiptNumber()
        {
            string sql = "SELECT TOP 1 WarehouseReceiptNumber FROM Warehouse ORDER BY WarehouseReceiptNumber DESC";
            return Connection.selectQuery(sql);
        }
    }
}
