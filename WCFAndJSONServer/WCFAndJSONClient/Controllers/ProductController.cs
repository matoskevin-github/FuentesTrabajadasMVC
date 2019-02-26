using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFAndJSONClient.Models;

namespace WCFAndJSONClient.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductServiceClient psc = new ProductServiceClient();
            ViewBag.product = psc.find();
            ViewBag.listProducts = psc.findAll();
            return View();
        }
    }
}