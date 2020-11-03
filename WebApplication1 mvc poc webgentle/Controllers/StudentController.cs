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
        
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        } 
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddress);
        }

        private List<Student> Students()
        {
            return new List<Student>()
            {
            new Student()
            {
                Id = 1,
                Name = "ayan",
                Address = new Address()
                {
                    Hno = 123,
                    Address1 = "lane-A",
                    city = "pune"
                }

            },
            new Student()
            {
                Id = 2,
                Name = "ayan2",
                Class = "a",
                Address = new Address()
                {
                    Hno = 123,
                    Address1 = "lane-A",
                    city = "pune"
                }

            } ,
            new Student()
            {
                Id = 3,
                Name = "ayan3",
                Class = "a",
                Address = new Address()
                {
                    Hno = 123,
                    Address1 = "lane-A",
                    city = "pune"
                }

            },   new Student()
            {
                Id = 4,
                Name = "ayan4",
                Class = "a",
                Address = new Address()
                {
                    Hno = 123,
                    Address1 = "lane-A",
                    city = "pune"
                }

            }
            };
            
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