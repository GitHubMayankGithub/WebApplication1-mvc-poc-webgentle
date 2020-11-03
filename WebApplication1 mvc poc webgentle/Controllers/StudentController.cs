using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_poc_webgentle.Models;


namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// by befault get http verb
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult StudentProfile(int id)
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult createProfile(Student student)
        {
            return View();
        }
        
        [HttpPut]
        public ActionResult updateProfile(int id,Student student)
        {
            return View();
        }
        
        public ActionResult deleteProfile(int id)
        {
            return View();
        }
    }
}