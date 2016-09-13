using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServerAppDev_App1.Models.Create;


namespace WebServerAppDev_App1.Controllers
{
    public class AccountCreateController : Controller
    {
        // GET: AccountCreate
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(AccountCreateViewModel createAccount)
        {
            return View();
        }
    }
}