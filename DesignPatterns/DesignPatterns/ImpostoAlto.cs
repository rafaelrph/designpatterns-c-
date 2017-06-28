using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ImpostoAlto : Imposto
    {

        public ImpostoAlto(Imposto outroImposto) : base(outroImposto) { }
        public ImpostoAlto() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularOutroImposto(orcamento);
        }

    }
}
