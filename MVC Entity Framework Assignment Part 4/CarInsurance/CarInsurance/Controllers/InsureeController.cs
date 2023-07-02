using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private CarInsuranceContext db = new CarInsuranceContext();  

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,BirthDate,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal monthlyTotal = 50; // Base monthly total

                // Age calculations
                int age = DateTime.Now.Year - insuree.BirthDate.Year;
                if (age <= 18)
                {
                    monthlyTotal += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    monthlyTotal += 50;
                }
                else
                {
                    monthlyTotal += 25;
                }

                // Car year calculations
                if (insuree.CarYear < 2000)
                {
                    monthlyTotal += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    monthlyTotal += 25;
                }

                // Car make and model calculations
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    monthlyTotal += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        monthlyTotal += 25;
                    }
                }

                // Speeding ticket calculations
                monthlyTotal += 10 * insuree.SpeedingTickets;

                // DUI calculation
                if (insuree.DUI)
                {
                    monthlyTotal *= 1.25m;
                }

                // Coverage type calculation
                if (insuree.CoverageType == true)
                {
                    monthlyTotal *= 1.5m;
                }

                insuree.Quote = monthlyTotal; // Set the calculated quote

                // Save the insuree to the database
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
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
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,BirthDate,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
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

        public ActionResult Admin()
        {
            var quotes = db.Insurees.ToList();
            return View(quotes);
        }

    }
}
