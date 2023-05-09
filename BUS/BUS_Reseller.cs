using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Reseller
    {
        DAL_Reseller reseller;

        public BUS_Reseller()
        {
            reseller = new DAL_Reseller();
        }

        public BUS_Reseller(string resellerID, string resellerName, string contactInfo, string username, string password, string paymentMethod)
        {
            reseller = new DAL_Reseller(resellerID, resellerName, contactInfo, username, password, paymentMethod);
        }

        public void add()
        {
            reseller.add();
        }

        public void update()
        {
            reseller.update();
        }
        public void delete()
        {
            reseller.delete();
        }
        public DataTable select()
        {
            return reseller.select();
        }

        public string generateNewResellerID()
        {
            using (DataTable table = reseller.getTopDescResellerID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "RS";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "RS001";
            }
        }

        public DataTable checkLogin()
        {
            return reseller.checkLogin();
        }
    }
}
