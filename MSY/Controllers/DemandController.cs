﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MSY.Controllers
{
    public class DemandController : Controller
    {
        // GET: Demand
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddParticipant()
        {
            return View();
        }
    }
}