using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Get.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }

        public string DataHoraAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}