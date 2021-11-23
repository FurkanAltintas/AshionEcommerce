using BLL.Concrete;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CollectionController : Controller
    {
        CollectionManager collectionManager = new CollectionManager(new EfCollectionRepository());
        // GET: Collection
        public PartialViewResult Index()
        {
            return PartialView(collectionManager.List());
        }
    }
}