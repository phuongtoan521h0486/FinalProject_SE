using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Payment
    {
        DAL_Payment payment;

        public BUS_Payment()
        {
            payment = new DAL_Payment();
        }

        public BUS_Payment(string paymentID, decimal amount, DateTime paymentDate, string paymentStatus, string orderID, string resellerID)
        {
            payment = new DAL_Payment(paymentID, amount, paymentDate, paymentStatus, orderID, resellerID);
        }

        public void add()
        {
            payment.add();
        }

        public void update()
        {
            payment.update();
        }
        public void delete()
        {
            payment.delete();
        }
        public DataTable select()
        {
            return payment.select();
        }

        public string generateNewPaymentID()
        {
            using (DataTable table = payment.getTopDescPaymentID())
            {
                if (table.Rows.Count > 0)
                {
                    string lastID = table.Rows[0][0].ToString();
                    int number = Convert.ToInt32(lastID.Substring(2)) + 1;
                    int numberOfZero = 3 - number.ToString().Length;
                    string ID = "PY";
                    for (int i = 0; i < numberOfZero; i++)
                    {
                        ID += "0";
                    }
                    return ID + number.ToString();
                }
                return "PY001";
            }
        }
    }
}
