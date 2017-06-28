using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TemplateDescontoCondicional : Imposto
    {

        public TemplateDescontoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateDescontoCondicional() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            if(DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalcularOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalcularOutroImposto(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
