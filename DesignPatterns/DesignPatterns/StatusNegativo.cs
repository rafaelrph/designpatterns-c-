using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class StatusNegativo : StatusConta
    {
        public void Sacar(Conta conta, double valor)
        {
            Console.WriteLine("Saldo insuficiente");
        }

        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if(conta.Saldo > 0)
            {
                conta.StatusAtual = new StatusPositivo();
            }
        }

    }
}
