using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoEmAprovacao : EstadoOrcamento
    {
        private bool DescontoAplicado { get; set; }

        public EstadoEmAprovacao()
        {
            this.DescontoAplicado = false;
        }

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(! DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                this.DescontoAplicado = true;
            } else
            {
                Console.WriteLine("Desconto já foi aplicado.");
            }
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
