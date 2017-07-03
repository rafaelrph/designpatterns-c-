using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class StatusPositivo : StatusConta
    {
        public void Sacar(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if(conta.Saldo < 0)
            {
                conta.StatusAtual = new StatusNegativo();
            }
        }

        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

    }
}
