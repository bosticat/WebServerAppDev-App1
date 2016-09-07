using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WSAD_App1.Models.Account;

namespace WSAD_App1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return this.RedirectToAction("Login");
        }

        /// <summary>
        /// Create a user account for my application
        /// </summary>
        /// <returns>View result for Create User</returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Loggin users into the site
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Will post the entered data
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(AccountLoginViewModel login)
        {
            if (login.Username == "austin" && login.Password == "pass")
            {
                return Content("Hello " + login.Username + ". Welcome to the application");
            }
            else
            {
                return Content("<h1>GET OUT OF MY SITE</h1>");
            }
            //validate that the username and password pass(no empties)

            //open database connection

            //hash password

            //Query for username and password hash

            //if invalid, show error

            //if valid, redirect to home screen
        }

    }
}