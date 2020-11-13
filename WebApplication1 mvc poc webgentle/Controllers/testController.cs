using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            return View();
        }
    }
}