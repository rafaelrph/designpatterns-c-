using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Arrojado : Investimento
    {

        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }

        public double CalcularInvestimento(Conta conta)
        {
            int chance = random.Next(10);
            if (chance <= 2)
            {
                return conta.Saldo * 0.05;
            }
            else if (chance > 2 && chance <= 5)
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }

    }
}
