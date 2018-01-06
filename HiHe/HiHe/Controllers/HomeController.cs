using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace HiHe.Controllers
{
    public class HomeController : Controller
    {
        private HiHeConText db = new HiHeConText();
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.NewProducts = productDao.ListNewProduct(4);
            ViewBag.FeatureProducts = productDao.ListFeatureProduct(4);
            return View();
        }
        public ActionResult mainMenu()
        {
            var menu = db.Menus.ToList();
            return PartialView(menu);
        }

    }
}