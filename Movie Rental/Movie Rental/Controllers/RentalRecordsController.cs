using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Movie_Rental;

namespace Movie_Rental.Controllers
{
    public class RentalRecordsController : Controller
    {
        private MovieRentalEntities db = new MovieRentalEntities();

        // GET: RentalRecords
        public ActionResult Index()
        {
            var rentalRecords = db.RentalRecords.Include(r => r.CustomerInfo).Include(r => r.Movy);
            return View(rentalRecords.ToList());
        }

        // GET: RentalRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalRecord rentalRecord = db.RentalRecords.Find(id);
            if (rentalRecord == null)
            {
                return HttpNotFound();
            }
            return View(rentalRecord);
        }

        // GET: RentalRecords/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.CustomerInfoes, "CustomerID", "CustomerName");
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName");
            return View();
        }

        // POST: RentalRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RentalID,MovieID,CustomerID,RentalDate,DueDate,ReturnDate")] RentalRecord rentalRecord)
        {
            if (ModelState.IsValid)
            {
                db.RentalRecords.Add(rentalRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.CustomerInfoes, "CustomerID", "CustomerName", rentalRecord.CustomerID);
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", rentalRecord.MovieID);
            return View(rentalRecord);
        }

        // GET: RentalRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalRecord rentalRecord = db.RentalRecords.Find(id);
            if (rentalRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.CustomerInfoes, "CustomerID", "CustomerName", rentalRecord.CustomerID);
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", rentalRecord.MovieID);
            return View(rentalRecord);
        }

        // POST: RentalRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RentalID,MovieID,CustomerID,RentalDate,DueDate,ReturnDate")] RentalRecord rentalRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentalRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.CustomerInfoes, "CustomerID", "CustomerName", rentalRecord.CustomerID);
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", rentalRecord.MovieID);
            return View(rentalRecord);
        }

        // GET: RentalRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentalRecord rentalRecord = db.RentalRecords.Find(id);
            if (rentalRecord == null)
            {
                return HttpNotFound();
            }
            return View(rentalRecord);
        }

        // POST: RentalRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RentalRecord rentalRecord = db.RentalRecords.Find(id);
            db.RentalRecords.Remove(rentalRecord);
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
