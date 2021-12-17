using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mmtz1\source\repos\CarInsurance\CarInsurance\App_Data\Insurance.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote_")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote_")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Get_Quote([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")]Table table)
        {
            if (ModelState.IsValid)
            {
                int quote = 50;

                var age = DateTime.Now.Year - table.DateOfBirth.Year;

                if(age < 18)
                {
                    quote = quote + 100;
                }
                else if (age > 25)
                {
                    quote = quote + 25;
                }
                else if (age > 18 || age < 25)
                {
                    quote = quote + 50;
                }
                if (table.CarYear < 2000)
                {
                    quote = quote + 25;
                }
                else if (table.CarYear > 2015)
                {
                    quote = quote + 25;
                }
                if (table.CarMake == "Porsche")
                {
                    quote = quote + 25;
                }
                if (table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
                {
                    quote = quote + 25;
                }
                if (table.SpeedingTickets > 0)
                {
                    quote = quote + (10 * table.SpeedingTickets);
                }
                if (table.DUI == true)
                {
                    quote = quote + (quote / 4);
                }
                if (table.CoverageType == true)
                {
                    quote = quote + (quote / 2);
                }
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }
        [HttpPost]
        public ActionResult Generate(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool coverageType, decimal Quote)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth.ToString()) || string.IsNullOrEmpty(carYear.ToString()) || string.IsNullOrEmpty(carMake.ToString()) || string.IsNullOrEmpty(carModel.ToString()) || string.IsNullOrEmpty(speedingTickets.ToString()) || string.IsNullOrEmpty(Quote.ToString()))
            {
                return View("~/Views/Shared/DataErrorInfoModelValidatorProvider.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var insuree = new Table();
                    insuree.FirstName = firstName;
                    insuree.LastName = lastName;
                    insuree.EmailAddress = emailAddress;
                    insuree.DateOfBirth = dateOfBirth;
                    insuree.CarYear = carYear;
                    insuree.CarMake = carMake;
                    insuree.CarModel = carModel;
                    insuree.DUI = dui;
                    insuree.SpeedingTickets = speedingTickets;
                    insuree.CoverageType = coverageType;
                    insuree.Quote_ = Calculate(dateOfBirth, carYear, carMake, carModel, dui, speedingTickets, coverageType);

                    db.Tables.Add(insuree);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }

        private decimal Calculate(DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool coverageType)
        {
            throw new NotImplementedException();
        }
    }
}
