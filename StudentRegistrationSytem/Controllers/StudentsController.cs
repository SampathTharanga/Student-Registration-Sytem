using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistrationSytem.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        //Student Registration
        public ActionResult Index()
        {
            return View();
        }

        //GET: Students/Student
        public ActionResult Student()
        {
            return View();
        }
    }
}
