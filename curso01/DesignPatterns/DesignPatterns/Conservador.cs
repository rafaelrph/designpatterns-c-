using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conservador : Investimento
    {

        public double CalcularInvestimento(Conta conta)
        {
            return conta.Saldo * 0.008;
        }

    }
}
