using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class CalculadorImpostos
    {

        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valorImposto = imposto.CalcularImposto(orcamento);
            Console.WriteLine(valorImposto);
        }

    }
}
