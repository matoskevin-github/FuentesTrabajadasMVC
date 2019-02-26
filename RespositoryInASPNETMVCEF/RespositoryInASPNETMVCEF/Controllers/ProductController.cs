using RespositoryInASPNETMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RespositoryInASPNETMVCEF.Controllers
{
    public class ProductController : Controller
    {
        private ICRUDRepository<Product> repository;

        public ProductController()
        {
            repository = new CRUDRepository<Product>();
        }

        // GET: Product
        public ActionResult Index()
        {
            List<Product> listProducts = repository.findAll().ToList();
            return View(listProducts);
        }
    }
}