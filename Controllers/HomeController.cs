using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoUIDropDownListApp.Models;

namespace KendoUIDropDownListApp.Controllers
{
    public class HomeController : Controller
    {
        public Data.CanvasAPI.CanvasAPIEntities canEnt = new Data.CanvasAPI.CanvasAPIEntities();
        public Data.Registrar.RegistrarEntities regEnt = new Data.Registrar.RegistrarEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetStudents()
        {
            var students = canEnt.v_studentsAll.Select(x => new StudentModel
            {
                studentname = x.studentname,
                emaddr = x.emaddr
            });

            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}
