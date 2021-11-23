using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        BrandManager brandManager = new BrandManager(new EfBrandRepository());

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Brand()
        {
            return PartialView(brandManager.List());
        }
    }
}