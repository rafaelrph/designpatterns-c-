using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoEmAprovacao : EstadoOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoAprovado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoReprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            Console.WriteLine("O orçamento não pode ser finalizado antes de ser Aprovado.");
        }
    }
}
