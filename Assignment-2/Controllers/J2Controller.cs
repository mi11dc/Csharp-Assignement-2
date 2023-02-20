using Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class J2Controller : Controller
    {
        // GET: J2/Index
        public ActionResult Index(int TotalNoofPeppers = 0)
        {
            J2Class model = new J2Class();
            model.TotalNoofPeppers = TotalNoofPeppers;
            return View(model);
        }

        [HttpGet]
        public ActionResult GetPoints(int totalPoints)
        {
            ViewData["points"] = totalPoints;
            return View();
        }

        [HttpPost]
        public ActionResult GetPoints(J2Class j2Class)
        {
            int totalPoints = j2Class.TotalSHUValues(j2Class);
            return RedirectToAction("GetPoints", "J2", new { totalPoints });
        }
    }
}
