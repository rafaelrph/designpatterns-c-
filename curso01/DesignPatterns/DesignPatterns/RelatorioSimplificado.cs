using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RelatorioSimplificado : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Banco Alura");
            Console.WriteLine("Relatório Simplificado");
            Console.WriteLine("--------------------");
        }

        protected override void Conteudo(IList<Conta> contas)
        {
            foreach(Conta conta in contas)
            {
                Console.WriteLine("CONTA DE " + conta.Titular.ToUpper());
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("84-85656-56565");
        }

    }
}
