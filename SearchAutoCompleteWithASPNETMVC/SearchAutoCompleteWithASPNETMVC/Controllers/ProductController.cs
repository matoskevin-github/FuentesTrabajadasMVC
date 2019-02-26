using SearchAutoCompleteWithASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchAutoCompleteWithASPNETMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Search(string term)
        {
            ProductModel model = new ProductModel();
            return Json(model.Search(term),JsonRequestBehavior.AllowGet);
        }
    }
}