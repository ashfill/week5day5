using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental1.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index(string q)
        {
            var persons = from p in db.people select p;
            if {
                persons = persons.Where(p => p.First.Contains(q));
            }
            return View();
        }
    }
}