using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Product
    {
        DAL_Product product;

        public BUS_Product()
        {
            product = new DAL_Product();
        }

        public BUS_Product(string productID, string productName, decimal price, string supplierID)
        {
            product = new DAL_Product(productID, productName, price, supplierID);
        }

        public void add()
        {
            product.add();
        }

        public void update()
        {
            product.update();
        }
        public void delete()
        {
            product.delete();
        }
        public DataTable select()
        {
            return product.select();
        }

        public string generateNewProductID()
        {
            using (DataTable table = product.getTopDescProductID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "P";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "P001";
            }
        }

        public DataTable getIdByProductName(string productName)
        {
            return product.getIdByProductName(productName);
        }
    }
}
