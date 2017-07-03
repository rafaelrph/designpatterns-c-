using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            if(ExisteItem("CANETA", orcamento) && ExisteItem("LAPIS", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return Proximo.CalcularDesconto(orcamento);
        }

        public bool ExisteItem(string nomeItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if(item.Nome.Equals(nomeItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
