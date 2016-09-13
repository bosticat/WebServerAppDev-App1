using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Windows.Forms;
using WebServerAppDev_App1.Models.Account;
using WebServerAppDev_App1.Models.Create;

namespace WebServerAppDev_App1.Controllers
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
            if ((login.Username != null && login.Username == "austin") && 
                (login.Password != null && login.Password == "pass"))
            {
                return Content("Hello " + login.Username + ". Welcome to the application");
            }
            else
            {
                return Content("<h1>GET OUT OF MY SITE</h1>");
            }

        }

        [HttpPost]
        public ActionResult Create(AccountCreateViewModel createAccount)
        {
            if (string.IsNullOrWhiteSpace(createAccount.FirstName))
            {
                MessageBox.Show("Please enter a First Name", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (string.IsNullOrWhiteSpace(createAccount.LastName))
            {
                MessageBox.Show("Please enter a Last Name", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (string.IsNullOrWhiteSpace(createAccount.EmailAddress) || !createAccount.EmailAddress.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (createAccount.Gender == null)
            {
                MessageBox.Show("Please select either Male/Female", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (string.IsNullOrWhiteSpace(createAccount.Username))
            {
                MessageBox.Show("Please enter a Username", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (string.IsNullOrWhiteSpace(createAccount.Password))
            {
                MessageBox.Show("Please enter a Password", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (string.IsNullOrWhiteSpace(createAccount.ConfirmPass))
            {
                MessageBox.Show("Please verify your password", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            if (!createAccount.Password.Equals(createAccount.ConfirmPass))
            {
                MessageBox.Show("Your passwords do not match. Try again.", "Account Submission",
                MessageBoxButtons.OKCancel);
                return View();
            }

            return Content("<h1>You have successfully created an account. Please verify the information.:</h1> "
                + "<br>" +
                "<h3>First Name: </h3>" + createAccount.FirstName.ToString() + "<br>" +
                "<h3>Last Name: </h3>" + createAccount.LastName  + "<br>" +
                "<h3>Email: </h3>" + createAccount.EmailAddress + "<br>" +
                "<h3>Gender: </h3>" + createAccount.Gender.ToString() + "<br>" +
                "<h3>Username: </h3>" + createAccount.Username
                );
        }

    }
}