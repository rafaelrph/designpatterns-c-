using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RealizadorInvestimentos
    {

        public void RealizarInvestimento(Conta conta, Investimento investimento)
        {
            double resultado = investimento.CalcularInvestimento(conta);
            Console.WriteLine("INVESTIMENTO = " + resultado);
        }

    }
}
