using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_poc_webgentle.Models;
namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class NewHomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// using post parametrs
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        [HttpPost]
        public string PostUsingParameters(string firstName, string lastName)
        {
            return "From Parameters " + firstName + "  " + lastName + " ";
        }

        /// <summary>
        /// using request paramter
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName=Request["firstName"];
            string lastName = Request["lastName"];
            return "From PostUsingRequest " + firstName + "  " + lastName + " ";
        }
        
        
        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName= form["firstName"];
            string lastName = form["lastName"];
            return "From PostUsingFormCollection " + firstName + "  " + lastName + " ";
        }

        //4th CASE IS USING STRONGLY BINDING TO POPST DATA FROM VIEW TO CONTROLLER. BY CREATING MODEL.
        /// <summary>
        /// PostUsingStronglyBinding
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public string PostUsingStronglyBinding(NewEmployee emp)
        {
            return "From PostUsingStronglyBinding " + emp.firstName + "  " + emp.lastName + " ";
        }

    }
}