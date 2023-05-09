using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Accountant
    {
        DAL_Accountant accountant;

        public BUS_Accountant()
        {
            accountant = new DAL_Accountant();
        }

        public BUS_Accountant(string accountantID, string accountantName, string contactInfo, string username, string password)
        {
            accountant = new DAL_Accountant(accountantID, accountantName, contactInfo, username, password);
        }

        public void add()
        {
            accountant.add();
        }

        public void update()
        {
            accountant.update();
        }
        public void delete()
        {
            accountant.delete();
        }
        public DataTable select()
        {
            return accountant.select();
        }

        public string generateNewAccountantID()
        {
            using (DataTable table = accountant.getTopDescAccountantID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "AC";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "AC001";
            }   
        }

        public DataTable checkLogin()
        {
            return accountant.checkLogin();
        }
    }
}
