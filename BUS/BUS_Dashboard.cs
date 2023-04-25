using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class BUS_Dashboard
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int NumResellers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        public BUS_Dashboard() { }
        private void GetNumberItems()
        {
            using (var cn = new SqlConnection(Connection.strConn))
            {
                cn.Open();
                using(var cm = new SqlCommand())
                {
                    cm.Connection = cn;
                    cm.CommandText = "SELECT COUNT(ResellerID) FROM Reseller";
                    NumResellers = (int)cm.ExecuteScalar();

                    cm.CommandText = "SELECT COUNT(SupplierID) FROM Supplier";
                    NumSuppliers = (int)cm.ExecuteScalar();

                    cm.CommandText = "SELECT COUNT(ProductID) FROM Product";
                    NumProducts = (int)cm.ExecuteScalar();

                    cm.CommandText = @"SELECT COUNT(OrderID) FROM [Order] " +
                                    "WHERE DateOrdered BETWEEN @fromDate and @toDate";
                    cm.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    cm.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)cm.ExecuteScalar();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            using (var cn = new SqlConnection(Connection.strConn))
            {
                cn.Open();
                using (var cm = new SqlCommand())
                {
                    cm.Connection = cn;
                    cm.CommandText = @"SELECT DateOrdered, sum(OrderItem.Quantity * OrderItem.Price) AS 'TotalAmount'
                                        FROM[Order], [OrderItem]
                                        WHERE DateOrdered BETWEEN @fromDate AND @toDate AND[Order].OrderID = OrderItem.OrderID
                                        GROUP BY DateOrdered";
                    cm.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    cm.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = cm.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while(reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                        
                    }
                    TotalProfit = TotalRevenue * 0.05m; // 10%
                    reader.Close();

                    if(numberDays <= 30)
                    {
                        foreach(var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate() {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                    orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week" + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    else if (numberDays <= 365 * 2)
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")): order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();

            using (var cn = new SqlConnection(Connection.strConn))
            {
                cn.Open();
                using (var cm = new SqlCommand())
                {
                    SqlDataReader reader;
                    cm.Connection = cn;
                    cm.CommandText = @"SELECT TOP 5 P.ProductName, SUM(OrderItem.Quantity) AS Q
                                      FROM OrderItem
                                      INNER JOIN Product P ON P.ProductID = OrderItem.ProductID
                                      INNER JOIN[Order] O ON O.OrderID = OrderItem.OrderID
                                      WHERE DateOrdered BETWEEN @fromDate AND @toDate
                                      GROUP BY P.ProductName
                                      ORDER BY Q DESC";
                    cm.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    cm.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = cm.ExecuteReader();
                    while(reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                }
            }
        }
        public bool loadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}