﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NickAndArtie.Models;

namespace NickAndArtie.Controllers
{
    public class ContactUsController : Controller
    {
        private NickAndArtieDB db = new NickAndArtieDB();
        //
        // GET: /ContactUs/

        public ActionResult Index()
        {
            ViewBag.Podcasts = db.Podcasts.OrderByDescending(x => x.DatePublished).Take(5).ToList();
            return View();
        }

    }
}
