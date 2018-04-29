using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Areas.Details.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details/Details
        public ActionResult Items()
        {
            return View();
        }
    }
}