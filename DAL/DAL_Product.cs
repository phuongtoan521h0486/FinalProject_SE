using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product
    {
        public DTO_Product product;
        public DAL_Product()
        {
            product = new DTO_Product();
        }
        public DAL_Product(string productID, string productName, decimal price, string supplierID)
        {
            product = new DTO_Product(productID, productName, price, supplierID);
        }

        public DAL_Supplier DAL_Supplier
        {
            get => default;
            set
            {
            }
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Product VALUES('{0}', '{1}', {2}, {3})",
                product.ProductID, product.ProductName, product.Price, product.SupplierID);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Product SET ProductName = '{1}', Price = {2}, SupplierID = '{3}' WHERE ProductID = '{0}'",
                product.ProductID, product.ProductName, product.Price, product.SupplierID);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Product WHERE ProductID = '{0}'",
                product.ProductID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Product";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescProductID()
        {
            string sql = "SELECT TOP 1 ProductID FROM Product ORDER BY ProductID DESC";
            return Connection.selectQuery(sql);
        }

        public DataTable getIdByProductName(string productName)
        {
            string sql = string.Format("SELECT ProductID FROM Product WHERE ProductName = '{0}'", productName);
            return Connection.selectQuery(sql);
        }
    }
}
