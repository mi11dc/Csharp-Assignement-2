using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        // GET: J3
        //public ActionResult Index(J3Class j3Class)
        //{
        //    j3Class.NoofPeople = (j3Class.NoofPeople > 0) ? j3Class.NoofPeople : 1;
        //    return View(j3Class);
        //}

        [HttpPost]
        public J3Class GetAvailableDays(J3Class j3Class)
        {
            if (!j3Class.NoofPeople.Equals(j3Class.Availibilities.Count))
            {
                j3Class.ErrorMessage = "Oppps!! Something went wrong...";
                return j3Class;
            }
            j3Class.SuggestedEventDay = j3Class.GetAvailableDays(j3Class.Availibilities);
            return j3Class;
        }
    }
}