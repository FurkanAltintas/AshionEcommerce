﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class DiscountController : Controller
    {
        // GET: Discount
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}