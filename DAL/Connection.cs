using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public static string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public static void actionQuery(string sql)
        {           
            using (SqlConnection cn = new SqlConnection(strConn))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
        }

        public static DataTable selectQuery(string sql)
        {
            using (SqlConnection cn = new SqlConnection(strConn))
            {
                cn.Open();
                SqlDataAdapter data = new SqlDataAdapter(sql, cn);
                DataTable table = new DataTable();
                data.Fill(table);
                return table;
            }            
        }
    }
}
