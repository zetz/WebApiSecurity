using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApiSecurity.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string userId, string password)
        {
            if (userId.Equals(password))
            {
                FormsAuthentication.SetAuthCookie("Badri", false);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}