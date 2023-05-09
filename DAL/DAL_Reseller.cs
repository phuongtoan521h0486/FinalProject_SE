using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Reseller
    {
        public DTO_Reseller reseller;
        public DAL_Reseller()
        {
            reseller = new DTO_Reseller();
        }
        public DAL_Reseller(string resellerID, string resellerName, string contactInfo, string username, string password, string paymentMethod)
        {
            reseller = new DTO_Reseller(resellerID, resellerName, contactInfo, username, password, paymentMethod);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Reseller VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                reseller.ResellerID, reseller.ResellerName, reseller.ContactInfo, reseller.Username, reseller.Password, reseller.PaymentMethod);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Reseller SET ResellerName = '{1}', ContactInfo = '{2}', Username = '{3}', Password = '{4}', PaymentMethod = '{5}' WHERE ResellerID = '{0}'",
                reseller.ResellerID, reseller.ResellerName, reseller.ContactInfo, reseller.Username, reseller.Password, reseller.PaymentMethod);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Reseller WHERE ResellerID = '{0}'",
                reseller.ResellerID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Reseller";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescResellerID()
        {
            string sql = "SELECT TOP 1 ResellerID FROM Reseller ORDER BY ResellerID DESC";
            return Connection.selectQuery(sql);
        }

        public DataTable checkLogin()
        {
            string sql = string.Format("SELECT ResellerName FROM Reseller WHERE username = '{0}' AND password = '{1}'",
                reseller.Username, reseller.Password);
            return Connection.selectQuery(sql);
        }
    }
}
