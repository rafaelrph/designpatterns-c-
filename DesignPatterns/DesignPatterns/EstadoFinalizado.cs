using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoFinalizado: EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Desconto não aplicável");
        }

        public void Aprovar(Orcamento orcamento)
        {
            Console.Write("O orçamento já está finalizado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            Console.Write("O orçamento já está finalizado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            Console.Write("O orçamento já está finalizado.");
        }
    }
}
