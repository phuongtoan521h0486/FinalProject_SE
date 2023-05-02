using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Supplier
    {
        DAL_Supplier supplier;

        public BUS_Supplier()
        {
            supplier = new DAL_Supplier();
        }

        public BUS_Supplier(string supplierID, string supplierName, string contactInfo)
        {
            supplier = new DAL_Supplier(supplierID, supplierName, contactInfo);
        }

        public void add()
        {
            supplier.add();
        }

        public void update()
        {
            supplier.update();
        }
        public void delete()
        {
            supplier.delete();
        }
        public DataTable select()
        {
            return supplier.select();
        }

        public string generateNewSupplierID()
        {
            using (DataTable table = supplier.getTopDescSupplierID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "SP";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "SP001";
            }
        }
    }
}
