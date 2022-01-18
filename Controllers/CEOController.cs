using HotelWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebApplication.Controllers
{
    public class CEOController : Controller
    {

  

        // GET: CEO
        public ActionResult GetCEOName()
        {
            ViewBag.Name =CEO.CEOlist[CEO.CEOlist.Count-1];
            return View();
        }

        // GET: CEO/AllInfo
        public ActionResult AllInfo()
        {
            ViewBag.AllInfo =CEO.CEOlist[CEO.CEOlist.Count-1];
            return View();
        }

    


    }
}
