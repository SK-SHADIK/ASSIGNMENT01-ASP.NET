using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASSIGENMENT01.Controllers
{
    public class ProtfolioController : Controller
    {
        // GET: Protfolio
        public ActionResult Index()
        {
            ViewBag.Section = "19-39357-1";
            ViewBag.Section1 = "HASAN, SHADIK";
            ViewBag.Section2 = "shadikhasan7564@gmail.com";
            ViewBag.Section3 = "+8801799404026";
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Reference()
        {
            ViewBag.Section1 = "TANVIR AHMED";
            ViewBag.Section2 = "Lecturer, Department of Computer Science, AIUB";
            ViewBag.Section3 = " tanvir.ahmed@aiub.edu";

            ViewBag.Section4 = "MD. ISMAIL HOSSEN";
            ViewBag.Section5 = "Lecturer, Department of Computer Science, AIUB";
            ViewBag.Section6 = "ismail.hossen@aiub.edu";
            return View();
        }
    }
}