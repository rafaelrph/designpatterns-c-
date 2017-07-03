﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().getConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela";

        }
    }
}
