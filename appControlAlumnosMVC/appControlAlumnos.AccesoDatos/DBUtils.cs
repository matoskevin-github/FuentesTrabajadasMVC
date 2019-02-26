using System.Configuration;
using System.Data.SqlClient;

namespace appControlAlumnos.AccesoDatos
{
    public static class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = ConfigurationManager.AppSettings["keyDataSource"];
            string database = ConfigurationManager.AppSettings["keyDatabase"];
            string username = ConfigurationManager.AppSettings["keyUsuario"];
            string password = ConfigurationManager.AppSettings["keyPassword"];

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}

