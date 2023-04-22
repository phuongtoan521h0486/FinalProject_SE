using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Supplier
    {
        public DTO_Supplier supplier;
        public DAL_Supplier()
        {
            supplier = new DTO_Supplier();
        }
        public DAL_Supplier(string supplierID, string supplierName, string contactInfo)
        {
            supplier = new DTO_Supplier(supplierID, supplierName, contactInfo);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Supplier VALUES('{0}', '{1}', '{2}')",
                supplier.SupplierID, supplier.SupplierName, supplier.ContactInfo);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Supplier SET SupplierName = '{1}', ContactInfo = '{2}' WHERE SupplierID = '{0}'",
                supplier.SupplierID, supplier.SupplierName, supplier.ContactInfo);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Supplier WHERE SupplierID = '{0}'",
                supplier.SupplierID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Supplier";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescSupplierID()
        {
            string sql = "SELECT TOP 1 SupplierID FROM Supplier ORDER BY SupplierID DESC";
            return Connection.selectQuery(sql);
        }
    }
}
