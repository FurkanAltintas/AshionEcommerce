using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ColorController : Controller
    {
        ColorManager colorManager = new ColorManager(new EfColorRepository());

        // GET: Color
        public PartialViewResult Index()
        {
            return PartialView(colorManager.List());
        }
    }
}