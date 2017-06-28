using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICPP : TemplateDescontoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemValorAlto(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        public bool TemItemValorAlto(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
