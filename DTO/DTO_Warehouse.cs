using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Warehouse
    {
        public string WarehouseReceiptNumber { get; set; }
        public DateTime DateReceived { get; set; }
        public string SupplierID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public DTO_Warehouse(string warehouseReceiptNumber, DateTime dateReceived, string supplierID, string productID, int quantity)
        {
            WarehouseReceiptNumber = warehouseReceiptNumber;
            DateReceived = dateReceived;
            SupplierID = supplierID;
            ProductID = productID;
            Quantity = quantity;
        }
        public DTO_Warehouse()
        {
        }
    }
}
