using DIMVCPracticeUpdated.Interfaces;
using DIMVCPracticeUpdated.Models;
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
            _session.SaveCredentialsInSession(new Credential() { RegisteredEmailId="14me272.varun@nitk.edu.in", Password="MrTaverekere" });
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = _session.Test();

            return View();
        }

        public ActionResult Contact()
        {
            Credential credential = _session.GetCredentialsStored();
            ViewBag.Message = _session.GetCredentialsStored();

            return View();
        }
    }
}