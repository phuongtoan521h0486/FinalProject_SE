using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormLoginWeb.Models;
using DTO;
using System.Configuration;
using System.Data.SqlClient;

namespace FormLoginWeb.Controllers
{
    public class ResellerController : Controller
    {
        public static string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString.ToString();
        // GET: Reseller
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(DTO_Reseller account)
        {
            using (var cn = new SqlConnection(strConn))
            {
                cn.Open();
                using (var cm = new SqlCommand())
                {
                    cm.Connection = cn;

                    cm.CommandText = "SELECT * FROM Reseller WHERE Username = @Username AND Password = @Password";
                    cm.Parameters.Add("@Username", System.Data.SqlDbType.VarChar).Value = account.Username;
                    cm.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = account.Password;
                    using (SqlDataReader dr = cm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return View("Success");
                        }
                        else
                        {
                            return View("Error");
                        }
                    }
                }
            }
            
        }
    }
}