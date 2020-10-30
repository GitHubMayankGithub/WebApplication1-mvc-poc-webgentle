using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public string  Index()
        {
            return "hellow world";
        }

        public string Name()
        {
            return "Mayank";
        }
    }
}