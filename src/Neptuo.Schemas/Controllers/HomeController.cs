using Neptuo.Schemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neptuo.Schemas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SchemaDataService dataService = new SchemaDataService(Request.MapPath(SchemaDataService.DataUri));
            return View(dataService.Get());
        }
    }
}