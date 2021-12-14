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
        public ActionResult Admin()
        {
            string queryString = "Select * From Table";

            List<Table> tables = new List<Table>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Table table = new Table();

                    table.Id = Convert.ToInt32(reader["Id"]);
                    table.FirstName = reader["FirstName"].ToString();
                    table.LastName = reader["LastName"].ToString();
                    table.EmailAddress = reader["EmailAddress"].ToString();
                    table.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    table.CarYear = Convert.ToInt32(reader["CarYear"]);
                    table.CarMake = reader["CarMake"].ToString();
                    table.CarModel = reader["CarModel"].ToString();
                    table.DUI = Convert.ToBoolean(reader["DUI"]);
                    table.SpeedingTickets = Convert.ToInt32(reader["SpeedingTickets"]);
                    table.CoverageType = Convert.ToBoolean(reader["CoverageType"]);
                    table.Quote_ = Convert.ToDecimal(reader["Quote_"]);

                    tables.Add(table);
                }
                connection.Close();
            }
            return View(tables);
        }
    }
}