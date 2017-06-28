using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoAprovado: EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprovar(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está aprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está aprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoFinalizado();
        }
    }
}
