using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Accountant
    {
        public DTO_Accountant accountant;
        public DAL_Accountant()
        {
            accountant = new DTO_Accountant();
        }
        public DAL_Accountant(string accountantID, string accountantName, string contactInfo, string username, string password)
        {
            accountant = new DTO_Accountant(accountantID, accountantName, contactInfo, username, password);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Accountant VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                accountant.AccountantID, accountant.AccountantName, accountant.ContactInfo, accountant.Username, accountant.Password);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Accountant SET AccountantName = '{1}', ContactInfo = '{2}', Username = '{3}', Password = '{4}' WHERE AccountantID = '{0}'",
                accountant.AccountantID, accountant.AccountantName, accountant.ContactInfo, accountant.Username, accountant.Password);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Accountant WHERE AccountantID = '{0}'",
                accountant.AccountantID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Accountant";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescAccountantID()
        {
            string sql = "SELECT TOP 1 AccountantID FROM Accountant ORDER BY AccountantID DESC";
            return Connection.selectQuery(sql);
        }

        public DataTable checkLogin()
        {
            string sql = string.Format("SELECT AccountantName FROM Accountant WHERE Username = '{0}' AND Password = '{1}'"
                , accountant.Username, accountant.Password);
            return Connection.selectQuery(sql);
        }
    }
}
