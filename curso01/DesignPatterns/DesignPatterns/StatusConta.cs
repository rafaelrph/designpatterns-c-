using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface StatusConta
    {
        void Sacar(Conta conta, double valor);
        void Depositar(Conta conta, double valor);
    }
}
