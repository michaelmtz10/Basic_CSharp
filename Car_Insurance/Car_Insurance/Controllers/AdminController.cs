using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Insurance.Models;

namespace Car_Insurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var client = (from c in db.Insurees
                              select c).ToList();
                var Tables = new List<Insuree>();
                foreach (var person in client)
                {
                    var insuree = new Insuree();
                    insuree.Id = person.Id;
                    insuree.FirstName = person.FirstName;
                    insuree.LastName = person.LastName;
                    insuree.EmailAddress = person.EmailAddress;
                    insuree.Quote = person.Quote;
                    Tables.Add(insuree);
                }
                return View(Tables);
            }
        }
    }
}