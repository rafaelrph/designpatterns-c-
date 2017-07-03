using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EstadoReprovado: EstadoOrcamento
    {

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Desconto não aplicável");
        }

        public void Aprovar(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está reprovado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está reprovado.");
        }
    }
}
