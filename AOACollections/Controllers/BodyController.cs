using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AOACollections.Controllers
{
    public class BodyController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}