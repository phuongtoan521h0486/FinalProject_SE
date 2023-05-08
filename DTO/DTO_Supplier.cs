using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Supplier
    {
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactInfo { get; set; }

        public DTO_Product DTO_Product
        {
            get => default;
            set
            {
            }
        }

        public DTO_Supplier(string supplierID, string supplierName, string contactInfo)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            ContactInfo = contactInfo;
        }
        public DTO_Supplier()
        {
        }
    }
}
