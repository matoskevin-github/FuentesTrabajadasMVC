using appControlAlumnos.AccesoDatos;
using appControlAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appControlAlumnos.LogicaNegocio
{
    public class CursoBO
    {
        public List<CursoBE> getListadoCursos()
        {
            CursoDAO oCursoDAO = new CursoDAO();
            return oCursoDAO.getListadoCursos();
        }
    }
}
