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
        public ActionResult Index(J2Class j2Class)
        {
            j2Class.TotalNoofPeppers = (j2Class.TotalNoofPeppers > 0) ? j2Class.TotalNoofPeppers : 1;
            return View(j2Class);
        }

        [HttpPost]
        public ActionResult GetPoints(J2Class j2Class)
        {
            if (!j2Class.TotalNoofPeppers.Equals(j2Class.LstPeppers.Count))
            {
                j2Class.ErrorMessage = "Oppps!! Something went wrong...";
                return View(j2Class);
            }
            j2Class = j2Class.getTotalSHU(j2Class);
            return View(j2Class);
        }
    }
}
