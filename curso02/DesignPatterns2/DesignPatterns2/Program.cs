using System;
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
            /*
             * ------------------------------
             * AULA 01 - FACTORY
             * ------------------------------
             * 
             * IDbConnection conexao = new ConnectionFactory().getConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela"; */

            //AULA 02 - FLYWEIGHT
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notas.PegaNota("do"),
                notas.PegaNota("re"),
                notas.PegaNota("mi"),
                notas.PegaNota("fa"),
                notas.PegaNota("fa"),
                notas.PegaNota("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);

        }
    }
}
