using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Payment
    {
        public DTO_Payment payment;
        public DAL_Payment()
        {
            payment = new DTO_Payment();
        }
        public DAL_Payment(string paymentID, decimal amount, DateTime paymentDate, string paymentStatus, string orderID, string resellerID)
        {
            payment = new DTO_Payment(paymentID, amount, paymentDate, paymentStatus, orderID, resellerID);
        }

        public void add()
        {
            string sql = string.Format("INSERT INTO Payment VALUES('{0}', '{1}', '{2}', {3}, '{4:yyyy-MM-dd}', '{5}')",
                payment.PaymentID, payment.OrderID, payment.ResellerID, payment.Amount, payment.PaymentDate, payment.PaymentStatus);
            Connection.actionQuery(sql);
        }

        public void update()
        {
            string sql = string.Format("UPDATE Payment SET OrderID = '{1}', ResellerID = '{2}', Amount = {3}, PaymentDate = '{4:yyyy-MM-dd}', PaymentStatus = '{5}' WHERE PaymentID = '{0}'",
                payment.PaymentID, payment.OrderID, payment.ResellerID, payment.Amount, payment.PaymentDate, payment.PaymentStatus);
            Connection.actionQuery(sql);
        }
        public void delete()
        {
            string sql = string.Format("DELETE FROM Payment WHERE PaymentID = '{0}'",
                payment.PaymentID);
            Connection.actionQuery(sql);
        }
        public DataTable select()
        {
            string sql = "SELECT * FROM Payment";
            return Connection.selectQuery(sql);
        }

        public DataTable getTopDescPaymentID()
        {
            string sql = "SELECT TOP 1 PaymentID FROM Payment ORDER BY PaymentID DESC";
            return Connection.selectQuery(sql);
        }
    }
}
