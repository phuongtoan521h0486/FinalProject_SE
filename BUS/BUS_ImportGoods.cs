using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ImportGoods
    {
        public DataTable listSuppliers { get; private set; }
        public DataTable listProducts { get; private set; }

        private void loadListSuppliers()
        {
            var supplierList = new BUS_Supplier();
            listSuppliers =  supplierList.select();     
        }

        public void LoadListProducts(string supplierID)
        {
            
            var cn = new SqlConnection(Connection.strConn);
            cn.Open();
            var cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = @"SELECT ProductName, Price
                                FROM Product
                                WHERE SupplierID = @supplierID";

            if (supplierID == "SP000")
            {
                cm.CommandText = @"SELECT ProductName, Price
                                FROM Product";
            }
            else
            {
                cm.Parameters.Add("@supplierID", System.Data.SqlDbType.VarChar).Value = supplierID;
                
            }

            SqlDataReader dr = cm.ExecuteReader();
            if (dr.HasRows)
            {
                listProducts = new DataTable();
                listProducts.Load(dr);
            }

        }

        public void loadData()
        {
            loadListSuppliers();
        }
    }
}
