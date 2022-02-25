using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practice17._02._22.Models;

namespace practice17._02._22.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Home()
        {
             ViewBag.Name = "Mawa";
              ViewBag.ID = 112;
              ViewData["DOB"]= DateTime.Now;

            Person p = new Person();
            p.Name = "Sornale";
            p.ID = 132;
            p.Dob = DateTime.Now; 

            
            return View(p);
        }

        public ActionResult List()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                var p = new Person
                {
                    ID = i + 1,
                    Name = "Person" + (i + 1),
                    Dob = DateTime.Now

                };
                persons.Add(p);

            }
            return View(persons);
        }
    }
}