using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVapp.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult CV()
        {
            return View();
        }
    }
}