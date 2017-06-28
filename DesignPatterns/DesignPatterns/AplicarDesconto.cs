using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AplicarDesconto
    {

        public void CalcularDesconto(Orcamento orcamento)
        {
            Desconto descontoItens = new DescontoItens();
            Desconto descontoValor = new DescontoValor();
            Desconto descontoCasada = new DescontoPorVendaCasada();
            Desconto semDesconto = new SemDesconto();

            descontoItens.Proximo = descontoValor;
            descontoValor.Proximo = descontoCasada;
            descontoCasada.Proximo = semDesconto;

            Console.WriteLine("DESCONTO = " + descontoItens.CalcularDesconto(orcamento));

        }

    }
}
