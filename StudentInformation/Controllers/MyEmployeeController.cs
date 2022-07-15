using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Controllers
{
    public class MyEmployeeController : Controller
    {
        // GET: MyEmployee
        public ActionResult Index()
        {
            return View();
        }
    }
}