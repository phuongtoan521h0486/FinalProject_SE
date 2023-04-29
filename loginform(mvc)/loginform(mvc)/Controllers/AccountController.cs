using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loginform_mvc_.Models;
namespace loginform_mvc_.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data Source=LAPTOP-08KNRVNO\\SQLEXPRESS;database = WPF ; integrated security = SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(Account acc) { 
            connectionString(); ;
            con.Open();
            com.Connection = con;
            com.CommandText = "'select * from Accountant where username ='"+acc.Name+"'and password='"+acc.Password +"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                return View("Error");
            }
            con.Close();
            return View(); 
        }
    }
}