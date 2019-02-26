using CRUDModelWithASPNETMVC.Models;
using CRUDModelWithASPNETMVC.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace CRUDModelWithASPNETMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private VentasBDEntities entities;

        public EmployeeController()
        {
            entities = new VentasBDEntities();
        }

        // GET: Employee
        public ActionResult Index()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel();            
            viewModel.lstEmpleado = entities.Empleado.ToList<Empleado>();
            return View(viewModel);
        }
    }
}