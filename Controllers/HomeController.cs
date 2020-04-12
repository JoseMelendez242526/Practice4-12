using _420practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _420practice.Controllers
{
    public class HomeController : Controller
    {
        FighterInfoEntry db;

        public HomeController()
        {
            db = new FighterInfoEntry();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult FighterDisplay()
        {
            var model = db.SeedDatabase(); 
            return View(model);
        }
    }
}