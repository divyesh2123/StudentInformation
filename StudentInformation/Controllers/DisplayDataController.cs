using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInformation.Controllers
{
    public class DisplayDataController : Controller
    {
        // GET: DisplayData
        public ActionResult Index()
        {
            return View();
        }
    }
}