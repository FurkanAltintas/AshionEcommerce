using BLL.Concrete;
using DAL.EntityFramework;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        AuthorizationManager authorizationManager = new AuthorizationManager(new EfEmployeeRepository(), new EfUserRepository());
        UserManager userManager = new UserManager(new EfUserRepository());

        // GET: Accont
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User p)
        {
            if (authorizationManager.UserLog(p))
            {
                FormsAuthentication.SetAuthCookie(p.Email, false);
                Session["Email"] = p.Email;
                return RedirectToAction("", "");
            }
            else
            {
                ViewBag.Error = "Mail veya şifre hatalı";
                return View(p);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User p)
        {
            p.CreateDate = DateTime.Now;
            userManager.Add(p);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult LoginEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginEmployee(Employee p)
        {
            if (authorizationManager.EmployeeLog(p))
            {
                FormsAuthentication.SetAuthCookie(p.Email, false);
                Session["Email"] = p.Email;
                return RedirectToAction("Index", "Panel", new { Area = "Dashboard" });
            }
            else
            {
                ViewBag.Error = "Email veya parola hatalı";
                return View(p);
            }
        }
    }
}