using BLL.Abstract;
using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class SizeController : Controller
    {

        SizeManager sizeManager = new SizeManager(new EfSizeRepository());
        ProductSizeManager productSizeManager = new ProductSizeManager(new EfProductSizeRepository());

        // GET: Size
        public PartialViewResult Index()
        {
            return PartialView(sizeManager.List());
        }

        public PartialViewResult ProductSize(int id)
        {
            return PartialView(productSizeManager.Size(id));
        }
    }
}