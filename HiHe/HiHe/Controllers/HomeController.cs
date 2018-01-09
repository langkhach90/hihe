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
        public ActionResult Index(string sortOrder)
        {
            var productDao = new ProductDao();
            var listCategory = db.ProductCategories.Where(x => x.ParentID == null).ToList();
            var slide = db.Slides.Where(x => x.Status == true).ToList();
         //   ViewBag.CurentSort = sortOrder;
            var listNewProduct = productDao.ListNewProduct(4);
            var listFeatureProduct = productDao.ListFeatureProduct(4);
            ViewBag.NewProducts = listNewProduct;
            ViewBag.FeatureProducts = listFeatureProduct;
            ViewBag.Slides = slide;
            //var product = new List<Product>();
            //switch(sortOrder)
            //{
            //    case "new_products":
            //        product = listNewProduct;
            //        break;
            //    case "feature_product":
            //        product = listFeatureProduct;
            //        break;
            //    default:
            //        product = listNewProduct;
            //        break;
            //}
            return View();
        }
        public ActionResult mainMenu()
        {
            var menu = db.Menus.ToList();
            return PartialView(menu);
        }

    }
}