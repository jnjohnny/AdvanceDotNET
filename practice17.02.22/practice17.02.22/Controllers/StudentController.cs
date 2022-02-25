using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice17._02._22.Models;

namespace practice17._02._22.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("List","Person");
            }
            return View(s);
        }

        [HttpPost]
        public ActionResult Submit(Student s)
        {
            // ViewBag.Name=Request["Name"];

            /*  Student s = new Student();
              s.Name = Request["Name"];
              s.Id = Request["Id"];
              s.Dob = Request["Dob"];
              s.Email = Request["Email"];
            */

            /*  FormCollection form  -- ata upore boshbe
              Student s = new Student();
              s.Name = form["Name"];
              s.Id = form["Id"];
              s.Dob = form["Dob"];
              s.Email = form["Email"];

              */

            /* 
             string Name, string Id, string Dob, String Email -->upore boshbe
             Student s = new Student();
             s.Name = Name;
             s.Id = Id;
             s.Dob = Dob;
             s.Email = Email;

             */

            return View(s);
        }
    }
}