using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eduro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = GetViewData();
            ViewData["pathtovideo"] = "D:/App_Data/project2.mp4";

            return View();
        }

        private object GetViewData()
        {
            var textToRead = @"Alfabetul limbii române este 
                            totalitatea literelor folosite pentru scrierea limbii române. 
                            În prezent conține 31 de litere și folosește cele 26 de caractere ale alfabetului latin 
                            la care se adaugă o serie de 5 caractere suplimentare formate prin aplicarea de semne diacritice:";

            var test = 1;

            test++;

            return test;
        }

        public ActionResult Video()
        {
            return File(@"D:/App_Data/project2.mp4", "video/mp4");
        }

    }
}
