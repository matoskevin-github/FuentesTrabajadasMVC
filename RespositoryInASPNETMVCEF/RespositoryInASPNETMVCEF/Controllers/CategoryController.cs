using RespositoryInASPNETMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RespositoryInASPNETMVCEF.Controllers
{
    public class CategoryController : Controller
    {
        private ICRUDRepository<Category> repository;

        public CategoryController()
        {
            repository = new CRUDRepository<Category>();
        }

        // GET: Category
        public ActionResult Index()
        {
            List<Category> listCategories = repository.findAll().ToList();

            return View(listCategories);
        }
    }
}