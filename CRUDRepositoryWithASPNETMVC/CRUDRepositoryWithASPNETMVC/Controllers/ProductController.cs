using CRUDRepositoryWithASPNETMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDRepositoryWithASPNETMVC.Controllers
{
    public class ProductController : Controller
    {
        private ICRUDRepository<Product> productCRUDRepository = new CRUDRepository<Product>();
        // GET: Account

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.products = productCRUDRepository.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("Add", new Product());
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            productCRUDRepository.create(product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            productCRUDRepository.delete(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View("Edit", productCRUDRepository.find(Id));
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productCRUDRepository.update(product);
            return RedirectToAction("Index");
        }

    }
}