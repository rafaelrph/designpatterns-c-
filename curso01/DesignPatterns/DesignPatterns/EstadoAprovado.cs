using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoAprovado: EstadoOrcamento
    {
        private bool DescontoAplicado { get; set; }

        public EstadoAprovado()
        {
            this.DescontoAplicado = false;
        }

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if(! DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                this.DescontoAplicado = true;
            } else
            {
                Console.WriteLine("Desconto já foi aplicado.");
            }
            
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
