using BLL.Abstract;
using BLL.Concrete;
using DAL.EntityFramework;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        ProductManager productManager = new ProductManager(new EfProductRepository());

        // GET: Comment
        public PartialViewResult Index(int id)
        {
            return PartialView(commentManager.List(x => x.ProductId == id));
        }

        [HttpGet]
        public PartialViewResult Add(int ProductId)
        {
            return PartialView();
        }

        public ActionResult Add(Comment p)
        {
            p.CreateDate = DateTime.Now;
            var url = productManager.Get(p.ProductId).Url;
            commentManager.Add(p);
            return RedirectToAction("Detail", "Product", new { String = "", url = url }); ;
        }
    }
}