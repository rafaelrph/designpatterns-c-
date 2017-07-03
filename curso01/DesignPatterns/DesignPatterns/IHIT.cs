using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IHIT : TemplateDescontoCondicional
    {

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return existemItensIguais(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return 100 + orcamento.Valor * 0.13;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        public bool existemItensIguais(Orcamento orcamento)
        {
            for (int i = 0; i < orcamento.Itens.Count; i++)
            {
                for (int j = 0; j < orcamento.Itens.Count; j++)
                {
                    if (orcamento.Itens.ElementAt(i).Nome.Equals(orcamento.Itens.ElementAt(j).Nome) && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
