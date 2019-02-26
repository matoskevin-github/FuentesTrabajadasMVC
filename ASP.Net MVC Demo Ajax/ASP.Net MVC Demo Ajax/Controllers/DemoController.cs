using ASP.Net_MVC_Demo_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_MVC_Demo_Ajax.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ViewResult Index()
        {
            return View();
        }

        public ContentResult HelloAjax()
        {
            return Content("Hello Ajax", "text/plain");
        }

        public ContentResult Sumar(int a, int b)
        {
            return Content((a + b).ToString(), "text/plain");
        }

        public JsonResult DisplayObject()
        {
            Product p1 = new Product("pr1","Name 1",1000);
  
            return Json(p1, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DisplayListObject()
        {
            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product("pr1", "Name 1", 1000));
            listProducts.Add(new Product("pr2", "Name 2", 2000));
            listProducts.Add(new Product("pr3", "Name 3", 3000));
            return Json(listProducts, JsonRequestBehavior.AllowGet);
        }

    }
}