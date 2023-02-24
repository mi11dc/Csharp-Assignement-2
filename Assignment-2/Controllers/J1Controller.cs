﻿using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class J1Controller : Controller
    {
        /// <summary>
        /// This J1 problem is from Mathematics and Computing Contests CCC 2023 Problems and Tests
        /// https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// </summary>
        /// <returns></returns>
        // GET: J1/index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetPoints(J1Class j1Class)
        {
            j1Class.TotalPoints = j1Class.DeliveryObsticalPoints(j1Class);
            return View(j1Class);
        }
    }
}