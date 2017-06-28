using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conta
    {

        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(double saldo, string titular)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }
}
