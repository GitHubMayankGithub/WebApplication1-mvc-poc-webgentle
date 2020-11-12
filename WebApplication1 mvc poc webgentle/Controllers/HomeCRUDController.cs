using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Model;
using MyApp.DB.DbOperations; 

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class HomeCRUDController : Controller
    {
        EmployeeRepository employeeRepository = null;

        public HomeCRUDController()
        {
            employeeRepository = new EmployeeRepository();
        }

        // GET: HomeCRUD
        public ActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult Create(EmployeeModel employeeModel)
        {
            if(ModelState.IsValid)
            {
                int id=employeeRepository.AddEmployee(employeeModel);

                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data added successfully !";
                }
            }
           
            return View();
        }

        public ActionResult GetAllRecords()
        {
            var result = employeeRepository.GetAllEmployees();
            return View(result);
        }

        public ActionResult Details(int id)
        {

            var employee = employeeRepository.GetEmployee(id);
            return View(employee);

        }
        
        public ActionResult DetailsNew(int id)
        {

            var employee = employeeRepository.GetEmployee(id);
            return View(employee);

        }
        
        public ActionResult Edit(int id)
        {

            var employee = employeeRepository.GetEmployee(id);
            return View(employee);

        }
        
        [HttpPost]
        public ActionResult Edit(EmployeeModel employeeModel)
        {
            if(ModelState.IsValid)
            {
                employeeRepository.UpdateEmployee(employeeModel.Id, employeeModel);
                return RedirectToAction("GetAllRecords");
            }

            return View();

        }

        public ActionResult Delete(int id)
        {

            var employee = employeeRepository.DeleteEmployee(id);
            return RedirectToAction("GetAllRecords");

        }



    }
}