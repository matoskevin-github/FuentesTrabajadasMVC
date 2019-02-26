using appControlAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace appControlAlumnos.AccesoDatos
{
    public class CursoDAO
    {
        public List<CursoBE> getListadoCursos()
        {
            var listResult = new List<CursoBE>();
            try
            {
                using (SqlConnection sqlCnx = DBUtils.GetDBConnection())
                {
                    sqlCnx.Open();
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "SP_SEL_LISTADO_DE_CURSOS";
                        sqlCmd.Connection = sqlCnx;
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var oCursoBE = new CursoBE();
                                oCursoBE.IdCurso = Convert.ToInt32(reader["IdCurso"]);
                                oCursoBE.Nombre = Convert.ToString(reader["Nombre"]);
                           listResult.Add(oCursoBE);
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
