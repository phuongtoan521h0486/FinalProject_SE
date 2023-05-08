using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Warehouse
    {
        DAL_Warehouse warehouse;

        public BUS_Warehouse()
        {
            warehouse = new DAL_Warehouse();
        }

        public BUS_Warehouse(string warehouseReceiptNumber, DateTime dateReceived, string productID, int quantity)
        {
            warehouse = new DAL_Warehouse(warehouseReceiptNumber, dateReceived, productID, quantity);
        }

        public BUS_Product BUS_Product
        {
            get => default;
            set
            {
            }
        }

        public void add()
        {
            warehouse.add();
        }

        public void update()
        {
            warehouse.update();
        }
        public void delete()
        {
            warehouse.delete();
        }
        public DataTable select()
        {
            return warehouse.select();
        }

        public string generateNewWarehouseReceiptNumber()
        {
            using (DataTable table = warehouse.getTopDescWarehouseReceiptNumber())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "WR";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "WR001";
            }
        }
    }
}
