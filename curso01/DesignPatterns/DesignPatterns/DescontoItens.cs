using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoItens : Desconto
    {

        public Desconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if(orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.CalcularDesconto(orcamento);
        }

    }
}
