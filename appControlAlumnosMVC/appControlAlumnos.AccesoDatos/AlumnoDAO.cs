using appControlAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace appControlAlumnos.AccesoDatos
{
    public class AlumnoDAO
    {

        public List<AlumnoBE> getListadoAlumnos()
        {
            var listResult = new List<AlumnoBE>();
            try
            {
                using (SqlConnection sqlCnx = DBUtils.GetDBConnection())
                {
                    sqlCnx.Open();
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "SP_SEL_LISTADO_DE_ALUMNOS";
                        sqlCmd.Connection = sqlCnx;
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var oAlumnoBE = new AlumnoBE();
                                oAlumnoBE.IdAlumno = Convert.ToInt32(reader["IdAlumno"]);
                                oAlumnoBE.Nombre = Convert.ToString(reader["Nombre"]);
                                oAlumnoBE.Apellido = Convert.ToString(reader["Apellido"]);
                                listResult.Add(oAlumnoBE);
                            }
                        }
                    }
                    sqlCnx.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listResult;
        }
    }
}
