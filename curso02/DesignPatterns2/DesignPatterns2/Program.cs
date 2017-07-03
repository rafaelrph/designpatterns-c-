using DesignPatterns2.Aula03;
using DesignPatterns2.Aula06;
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

            /**
             * ------------------------------
             * AULA 02 - FLYWEIGHT
             * ------------------------------
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
            piano.Toca(musica); */

            /**
             * ----------------------------
             * AULA 03 - MEMENTO
             * ----------------------------
             * 
            Contrato contrato = new Contrato(DateTime.Now, "Fulano de Tal", TipoContrato.Novo);
            Console.WriteLine(contrato.Tipo);

            Historico historico = new Historico();
            historico.Adiciona(new Estado(new Contrato(contrato.Data, contrato.Cliente, contrato.Tipo)));

            contrato.Avanca();
            historico.Adiciona(new Estado(new Contrato(contrato.Data, contrato.Cliente, contrato.Tipo)));
            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(new Estado(new Contrato(contrato.Data, contrato.Cliente, contrato.Tipo)));
            Console.WriteLine(contrato.Tipo);

            Console.WriteLine("Histórico 0: " + historico.Pega(0).Contrato.Tipo);
            Console.WriteLine("Histórico 1: " + historico.Pega(1).Contrato.Tipo); */


            IEnviador enviadorEmail = new EnviarPorEmail();
            IMensagem mensagem = new MensagemCliente("Fulano de Tal Cliente");
            enviadorEmail.Enviar(mensagem);

            IEnviador enviadorSms = new EnviarPorSMS();
            enviadorSms.Enviar(mensagem);

            IMensagem mensagemAdm = new MensagemAdministrativa("Fulano Admin");
            enviadorSms.Enviar(mensagemAdm);

            Console.ReadKey();

        }
    }
}
