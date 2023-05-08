﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string SupplierID { get; set; }

        public DTO_Product(string productID, string productName, decimal price, string supplierID)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            SupplierID = supplierID;
        }
        public DTO_Product()
        {
        }
    }
}
