using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental1.Models;

namespace MovieRental1.Controllers
{
    public class catController : Controller
    {
        private MovieRentalEntities db = new MovieRentalEntities();

        // GET: Cat
        public ActionResult Index()
        {
            var Yes = from a in db.RentalRecords
                      join b in db.CustomerInfoes on a.CustomerID equals b.CustomerID
                      join c in db.Movies on a.MovieID equals c.MovieID
                      select new CatClass
                      {
                          newCustomer = b,
                          newMovie = c,
                          newRecord = a,
                      };

            return View(Yes);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catalog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalog/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalog/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalog/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}