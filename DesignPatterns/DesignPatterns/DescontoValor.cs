using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoValor : Desconto
    {
        public Desconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if(orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.CalcularDesconto(orcamento);
        }

    }
}
