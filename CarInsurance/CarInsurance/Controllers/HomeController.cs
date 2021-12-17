using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmtz1\source\repos\CarInsurance\CarInsurance\App_Data\Insurance.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}