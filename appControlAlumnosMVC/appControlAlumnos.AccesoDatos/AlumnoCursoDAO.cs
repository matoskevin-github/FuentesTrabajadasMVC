using appControlAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appControlAlumnos.AccesoDatos
{
    public class AlumnoCursoDAO
    {

        public AlumnoCursoBE getEntidadAlumnoCurso(AlumnoBE oAlumnoBE)
        {
            var entityResult = new AlumnoCursoBE();          
            List<CursoBE> lstCurso = new List<CursoBE>();
            try
            {
                using (SqlConnection sqlCnx = DBUtils.GetDBConnection())
                {
                    sqlCnx.Open();
                    using (SqlCommand sqlCmd = new SqlCommand())
                    {
                        sqlCmd.CommandText = "SP_SEL_ALUMNO_CURSO";
                        sqlCmd.Connection = sqlCnx;
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add("IdAlumno", SqlDbType.Int).Value = oAlumnoBE.IdAlumno;
                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AlumnoBE eAlumno = new AlumnoBE();
                                eAlumno.IdAlumno = Convert.ToInt32(reader["IdAlumno"]);
                                eAlumno.Nombre = Convert.ToString(reader["Nombre"]);
                                eAlumno.Apellido = Convert.ToString(reader["Apellido"]);
                                entityResult.oAlumnoBE = eAlumno;
                            }

                            reader.NextResult();

                            while (reader.Read())
                            {
                                CursoBE eCursoBE = new CursoBE();
                               eCursoBE.IdCurso = Convert.ToInt32(reader["IdCurso"]);
                                eCursoBE.Nombre = Convert.ToString(reader["Nombre"]);
                                lstCurso.Add(eCursoBE);
                            }

                            entityResult.oCursoBE = lstCurso;
                        }
                    }
                    sqlCnx.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entityResult;
        }
    }
}
