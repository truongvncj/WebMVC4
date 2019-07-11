using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webmvc4.Areas.Temp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Temp/Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
