using appControlAlumnos.AccesoDatos;
using appControlAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appControlAlumnos.LogicaNegocio
{
    public class AlumnoCursoBO
    {

        public AlumnoCursoBE getEntidadAlumnoCurso(AlumnoBE oAlumnoBE)
        {
            AlumnoCursoDAO oAlumnoCursoDAO = new AlumnoCursoDAO();
            return oAlumnoCursoDAO.getEntidadAlumnoCurso(oAlumnoBE);
        }
    }
}
