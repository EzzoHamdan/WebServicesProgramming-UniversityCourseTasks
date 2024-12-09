using ConsumeStudentService.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeStudentService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentServiceClient studentServiceClient = new StudentServiceClient();

            Student student = studentServiceClient.GetStudent();
            var studentById = studentServiceClient.GetStudentById(2);

            double discount;
            if (student.City.Equals("Amman"))
            {
                discount = 0.15;
            }
            else if (student.City.Equals("Zarqa"))
            {
                discount = 0.10;
            }
            else
            {
                discount = 0.05;
            }

            ViewBag.name = student.Name;
            ViewBag.id = student.Id;
            ViewBag.city = student.City;
            //ViewBag.average = student.Average;
            //ViewBag.department = student.Department;
            ViewBag.discount = discount;
            ViewBag.studentByIdName = studentById.Name;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}