using DIMVCPracticeUpdated.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIMVCPracticeUpdated.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserSession _session;
        public HomeController(IUserSession session)
        {
            _session = session;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _session.Test();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = _session.Test();

            return View();
        }
    }
}