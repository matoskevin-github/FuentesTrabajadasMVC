using ListModelInASPNETMVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListModelInASPNETMVCEF.Controllers
{
    public class DetalleClienteController : Controller
    {
        private VentasBDEntities entities;

        public DetalleClienteController()
        {
            entities = new VentasBDEntities();
        }
        // GET: DetalleCliente
        public ActionResult Index()
        {
            List<DetalleClientes> listDetaClientes = entities.DetalleClientes.ToList();
            return View(listDetaClientes);
        }

        public ActionResult EliminarCliente(string IdCliente)
        {
            DetalleClientes detalle = entities.DetalleClientes.Find(Convert.ToInt32(IdCliente));
            entities.DetalleClientes.Remove(detalle);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}