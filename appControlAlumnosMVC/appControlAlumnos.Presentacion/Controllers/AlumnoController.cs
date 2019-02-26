using appControlAlumnos.Entidades;
using appControlAlumnos.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appControlAlumnos.Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            AlumnoBO oAlumnoBO = new AlumnoBO();
            List<AlumnoBE> lista = oAlumnoBO.getListAlumnos();
            return View(lista);
        }

        public ActionResult Ver(AlumnoBE AlumnoBE)
        {
            AlumnoCursoBO oAlumnoCursoBO = new AlumnoCursoBO();
            AlumnoCursoBE oAlumnoCursoBE = oAlumnoCursoBO.getEntidadAlumnoCurso(AlumnoBE);
            return View(oAlumnoCursoBE);
        }

        //Actualiza y Registra
        public ActionResult Registro(AlumnoBE AlumnoBE)
        {
            AlumnoBE oAlumnoBE = new AlumnoBE();

            if (AlumnoBE.IdAlumno > 0)
            {
                AlumnoCursoBO oAlumnoCursoBO = new AlumnoCursoBO();
                CursoBO oCursoBO = new CursoBO();
                ViewBag.ListaCursosAlumno = oCursoBO.getListadoCursos();  // devuelve todo los valores de la lista
                AlumnoCursoBE oAlumnoCursoBE = oAlumnoCursoBO.getEntidadAlumnoCurso(AlumnoBE);
                oAlumnoCursoBE.oCursoBE = oAlumnoCursoBE.oCursoBE.ToList(); // devuelve lista filtrada              

                oAlumnoBE = oAlumnoCursoBE.oAlumnoBE;
            }
            else
            {
                CursoBO oCursoBO = new CursoBO();
                oAlumnoBE.IdAlumno = 0;
                oAlumnoBE.Nombre = string.Empty;
                oAlumnoBE.Apellido = string.Empty;
                ViewBag.ListaCursosAlumno = oCursoBO.getListadoCursos();  // devuelve todo los valores de la lista
                oAlumnoBE.oCursoBE = new List<CursoBE>();
            }
            return View(oAlumnoBE);
        }

        [HttpPost]
        public ActionResult Guardar(AlumnoBE model, int[] cursos_seleccionados)
        {
            var respuesta = new ResponseModelBE
            {
                respuesta = true,
                redirect = "/" + RedirectToAction("Index").RouteValues["Controller"] + "/"+RedirectToAction("Index").RouteValues["action"],
                error = ""
            };
          
            model.oCursoBE = new List<CursoBE>();

            if (cursos_seleccionados != null)
            {
                foreach (var c in cursos_seleccionados)
                {
                    CursoBE oCursoBE = new CursoBE();
                    oCursoBE.IdCurso = c;
                    model.oCursoBE.Add(oCursoBE);
                }
                  
            }
            else
            {
                ModelState.AddModelError("cursos", "Debe seleccionar por lo menos un curso");
                respuesta.respuesta = false;
                respuesta.error = "Debe seleccionar por lo menos un curso";
            }

            if (ModelState.IsValid)
            {
                AlumnoBO oAlumnoBO = new AlumnoBO();
                oAlumnoBO.Guardar(model);
            }

           return Json(respuesta);

        }
    }
}