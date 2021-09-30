using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAula2809
{
    public class Conexao
    {
        private static string strCon = @"Server=tcp:aw-server0409.database.windows.net,1433;Initial Catalog=db_livraria;Persist Security Info=False;User ID=cloudadmin;Password=Ymm67480;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private static SqlConnection connection = null;

        public static SqlConnection ObterConexao()
        {
            SqlConnection connection = new SqlConnection(strCon);

            try
            {
                connection.Open();
            }
            catch (SqlException sqle)
            {
                connection = null;
            }

            return connection;
        }

        public static void FecharConexao()
        {
            if (connection != null)
            {
                connection.Close();
            }


        }
    }
}
