using Cooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cooking.Controllers
{
    public class DinnerController : Controller
    {
        // GET: Lunch
        public ActionResult Index()
        {

            DinnerDto model = new DinnerDto();
            model.name = "Dinner";


            return View(model);

        }

    }
}