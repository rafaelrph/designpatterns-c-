﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.05 + CalcularOutroImposto(orcamento);
            } 
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.07 + CalcularOutroImposto(orcamento);
            } else
            {
                return (orcamento.Valor * 0.08) + 30 + CalcularOutroImposto(orcamento);
            }
        }
    }
}
