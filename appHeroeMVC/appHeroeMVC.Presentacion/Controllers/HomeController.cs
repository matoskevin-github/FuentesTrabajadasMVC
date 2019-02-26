using appHeroeMVC.Entidades.Modelo;
using appHeroeMVC.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appHeroeMVC.Presentacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HeroeBO oHeroeBO = new HeroeBO();
            List<Heroe> lista = oHeroeBO.getListaHeroes();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}