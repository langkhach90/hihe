using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace HiHe.Controllers
{
    public class ProductController : Controller
    {
        private HiHeConText db = new HiHeConText();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Categories()
        {
            var categories = db.ProductCategories.ToList();
            return PartialView(categories);
        }
        //public List<Product> ListNewProduct(int top)
        //{
        //    return db.Products.OrderByDescending(x => x.CreateDate).Take(top).ToList();
        //}
        //public List<Product> ListFeatureProduct(int top)
        //{
        //    return db.Products.Where(x=>x.TopHot != null).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        //}
        public ActionResult ProductCategory(long Id)
        {
            return View();
        }
        public ActionResult Detail(long id)
        {
            var details = db.Products.Find(id);
            return View(details);
        }
    }
}