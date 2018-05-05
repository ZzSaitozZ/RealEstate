using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult ItemsFilter()
        {
            return View();
        }
    }
}