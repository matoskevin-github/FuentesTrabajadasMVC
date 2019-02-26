using DeleteMultipleASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeleteMultipleASPNETMVC.Controllers
{
    public class ProductController : Controller
    {
        private EmpresaBDEntities entities = new EmpresaBDEntities();
        
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.listProduct = entities.Product.ToList();
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Index(FormCollection formCollection)
        {
            string[] ids = formCollection["productId"].Split(new char[] {',' });
            foreach (var item in ids)
            {
                var product = entities.Product.Find(Convert.ToInt32(item));
                entities.Product.Remove(product);
                entities.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}