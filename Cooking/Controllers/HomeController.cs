using Cooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "cooking.";
            ResturantDto model = new ResturantDto();
            model.name = "Cat cafe";
            return View(model);
        }
        public ActionResult test()
        {
            ViewBag.Message = "cooking.";
            ResturantDto model = new ResturantDto();
            model.name = "Cat cafe";
            return View(model);
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

    }
}