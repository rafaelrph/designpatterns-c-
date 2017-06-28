using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
     public class RelatorioCompleto : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Banco Alura");
            Console.WriteLine("Rua Tal, Natal-RN");
            Console.WriteLine("--------------------");
            Console.WriteLine("RELATÓRIO COMPLETO");
            Console.WriteLine("--------------------");
        }

        protected override void Conteudo(IList<Conta> contas)
        {
            foreach(Conta conta in contas)
            {
                Console.WriteLine("Titular: " + conta.Titular + " - Saldo: R$ " + conta.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("(84)90909-9999");
            Console.WriteLine("--------------------");
        }

    }
}
