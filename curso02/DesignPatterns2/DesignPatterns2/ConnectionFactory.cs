using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    public class ConnectionFactory
    {
        public IDbConnection getConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id = root; Password = pass; Server = localhost; Database = banco";
            conexao.Open();
            return conexao;
        }
    }
}
