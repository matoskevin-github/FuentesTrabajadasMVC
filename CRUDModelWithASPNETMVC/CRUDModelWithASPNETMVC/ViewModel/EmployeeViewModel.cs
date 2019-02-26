using CRUDModelWithASPNETMVC.Models;
using System.Collections.Generic;

namespace CRUDModelWithASPNETMVC.ViewModel
{
    public class EmployeeViewModel
    {
        public Empleado objEmpleado { get; set; }
        public List<Empleado> lstEmpleado { get; set; }
    }
}