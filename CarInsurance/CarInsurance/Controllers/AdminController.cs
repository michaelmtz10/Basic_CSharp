using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var client = (from c in db.Tables
                              select c).ToList();
                var Tables = new List<Table>();
                foreach (var person in client)
                {
                    var insuree = new Table();
                    insuree.Id = person.Id;
                    insuree.FirstName = person.FirstName;
                    insuree.LastName = person.LastName;
                    insuree.EmailAddress = person.EmailAddress;
                    insuree.Quote_ = person.Quote_;
                    Tables.Add(insuree);
                }
                return View(Tables);
            }
 
        }
    }
}