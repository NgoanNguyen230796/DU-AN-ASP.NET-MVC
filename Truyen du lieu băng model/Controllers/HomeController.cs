using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Truyen_du_lieu_băng_model.Models;
namespace Truyen_du_lieu_băng_model.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Student stu = new Student
            {
                Id = "A01",
                Grade = 7.5F,
                Name = "Phan Duy Phương"
            };
            return View(stu);
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