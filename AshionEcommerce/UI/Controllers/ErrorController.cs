﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}