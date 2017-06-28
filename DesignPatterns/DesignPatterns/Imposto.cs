using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Imposto
    {

        private Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null)
            {
                return 0;
            } 
            else
            {
                return OutroImposto.CalcularImposto(orcamento); 
            }
        }

        public abstract double CalcularImposto(Orcamento orcamento);

    }
}
