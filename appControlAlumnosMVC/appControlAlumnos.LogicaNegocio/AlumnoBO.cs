using appControlAlumnos.AccesoDatos;
using appControlAlumnos.Entidades;
using System.Collections.Generic;
using System;

namespace appControlAlumnos.LogicaNegocio
{
    public class AlumnoBO
    {

        public List<AlumnoBE> getListAlumnos()
        {
            AlumnoDAO oAlumnoDAO = new AlumnoDAO();
            return oAlumnoDAO.getListadoAlumnos();
        }

        public void Guardar(AlumnoBE model)
        {
            throw new NotImplementedException();
        }
    }
}
