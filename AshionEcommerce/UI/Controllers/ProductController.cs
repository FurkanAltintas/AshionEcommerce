using BLL.Abstract;
using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());

        // GET: Product
        [HttpGet]
        public ActionResult Brand(string brand)
        {
            ViewBag.Title = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(brand);
            return View(productManager.List(x => x.Brand.Name.ToLower() == brand).OrderByDescending(x => x.Id).ToList());
        }


        [HttpPost]
        public ActionResult Brand(string brand, string minamount, string maxamount, string[] cinsiyet, string color)
        {
            int min = Convert.ToInt16(minamount);
            int max = Convert.ToInt16(maxamount);

            return View(productManager.List(x => x.Price <= max && x.Price >= min && x.Color.Name == color));

        }

        public PartialViewResult New()
        {
            return PartialView(productManager.ListGender());
        }

        public ActionResult Detail(int id)
        {
            Session.Remove("Error"); //session silme

            //var indexOf = product.LastIndexOf("-");
            //var key = product.Substring(indexOf + 1); //id alma
            ////var name = product.Substring(0, indexOf); //ismi alma
            //int id = Convert.ToInt32(UI.Utils.Harfler.HarfSil(key)); //id alma

            var pro = productManager.GetBrand(id);

            if (pro != null)
                return View(pro);
            else
                Session["Error"] = "Error"; //session oluşturma
            return View();
        }

        public PartialViewResult RelatedProducts(int id)
        {
            var key = productManager.Related(id);
            var brand = key.Brand.Name;
            var gender = key.Gender.Name;
            var kind = key.Kind.Name;

            return PartialView(productManager.List(x => x.Id != id && x.Brand.Name == brand && x.Gender.Name == gender && x.Kind.Name == kind).Take(4).Reverse().ToList());
        }
    }
}