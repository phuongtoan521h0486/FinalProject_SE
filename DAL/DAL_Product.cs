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
        public DAL_Product(string productID, string productName, decimal price)
        {
            product = new DTO_Product(productID, productName, price);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Supplier VALUES('{0}', '{1}', {2})",
                product.ProductID, product.ProductName, product.Price);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Product SET ProductName = '{1}', Price = {2} WHERE ProductID = '{0}'",
                product.ProductID, product.ProductName, product.Price);
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
    }
}
