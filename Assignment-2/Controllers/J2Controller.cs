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
        /// <summary>
        /// This J2 problem is from Mathematics and Computing Contests CCC 2023 Problems and Tests
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// </summary>
        /// <param name="j2Class">
        ///     J2Class contains TotalNoofPeppers, TotalSHU, ErrorMessage and LstPeppers.
        ///     Also, it contains GetTotalSHU method.
        /// </param>
        /// <returns>Go to Index Page</returns>
        // GET: J2/Index
        public ActionResult Index(J2Class j2Class)
        {
            j2Class.TotalNoofPeppers = (j2Class.TotalNoofPeppers > 0) ? j2Class.TotalNoofPeppers : 1;
            return View(j2Class);
        }

        /// <summary>
        /// This J2 problem is from Mathematics and Computing Contests CCC 2023 Problems and Tests
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// </summary>
        /// <param name="j2Class">
        ///     J2Class contains TotalNoofPeppers, TotalSHU, ErrorMessage and LstPeppers.
        ///     Also, it contains GetTotalSHU method.
        /// </param>
        /// <returns>Go to Index Page</returns>
        [HttpPost]
        public ActionResult GetPoints(J2Class j2Class)
        {
            if (!j2Class.TotalNoofPeppers.Equals(j2Class.LstPeppers.Count))
            {
                j2Class.ErrorMessage = "Oppps!! Something went wrong...";
                return View(j2Class);
            }
            j2Class = j2Class.GetTotalSHU(j2Class);
            return View(j2Class);
        }
    }
}
