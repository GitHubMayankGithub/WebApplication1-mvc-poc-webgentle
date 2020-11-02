using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_poc_webgentle.Models;

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public ActionResult MyIndex()
        {
           return View();
        }


        public ActionResult  Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        [HttpPost]
        public string Index(Employee emp)
        {
            return "hellow world";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Mayank";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Employee GetEmployee()
        {
            return new Employee()
            {
                name = "rahul",
                address = "allahabad",
            };
        }
    }
}