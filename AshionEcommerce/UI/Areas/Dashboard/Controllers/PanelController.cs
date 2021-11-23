using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Areas.Dashboard.Controllers
{
    public class PanelController : Controller
    {
        // GET: Dashboard/Panel
        public ActionResult Index()
        {
            return View();
        }
    }
}