using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class GenderController : Controller
    {
        GenderManager genderManager = new GenderManager(new EfGenderRepository());

        // GET: Gender
        public PartialViewResult Index()
        {
            return PartialView(genderManager.List());
        }
    }
}