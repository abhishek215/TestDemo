﻿using ProjectDatabaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourismMVCWebsite.Controllers
{
   [Authorize]
    public class UserController : Controller
    {
        // GET: User
        private TourismWebsiteDBEntities db = new TourismWebsiteDBEntities();
        public ActionResult Index()
        {
            
            return View(db.Packages.ToList());
        }

       
    }
}