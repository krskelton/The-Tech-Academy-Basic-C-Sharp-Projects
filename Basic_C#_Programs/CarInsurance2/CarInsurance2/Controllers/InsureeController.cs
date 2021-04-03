using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree table)
        {
            decimal quote = 50m;
            //Figure out the users age
            var today = DateTime.Today;
            int age = today.Year - table.DateOfBirth.Year;
            //add to quote amount based on age
            if (age <= 18)
            {
                quote += 100;
            }
            else if (age >= 19 && age <= 25)
            {
                quote += 50;
            }
            else if (age > 25)
            {
                quote += 25;
            }

            //add to quote total based on Car's year
            if (table.CarYear < 2000)
            {
                quote += 25;
            }
            else if (table.CarYear > 2015)
            {
                quote += 25;
            }

            //add to total if car's make is a porsche
            if (table.CarMake == "Porsche")
            {
                quote += 25;
                //add total if the car's make is also a 911 Carrera
                if (table.CarModel == "911 Carrera")
                {
                    quote += 25;
                }
            }

            //add $10 to the total for every speeding ticket the user has
            for (int i = 0; i < table.SpeedingTickets; i++)
            {
                quote += 10;
            }

            //if the user has had a DUI add 25% to the total
            if (table.DUI)
            {
                decimal twentyFivePercent = quote * .25m;
                quote += twentyFivePercent;
            }

            //if it's full coverage, add 50% to the total
            if (table.CoverageType)
            {
                decimal fiftyPercent = quote * .5m;
                quote += fiftyPercent;
            }

            //map Quote to the quote we determined here
            table.Quote = quote;

            if (ModelState.IsValid)
            {
                db.Insurees.Add(table);
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
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
    }
}
