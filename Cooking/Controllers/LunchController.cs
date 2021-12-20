using Cooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cooking.Controllers
{
    public class LunchController : Controller
    {
        // GET: Lunch
        public ActionResult Index()
        {

            LunchDto model = new LunchDto();
            model.name = "Lunch";
          

            return View(model);

        }

    }
}