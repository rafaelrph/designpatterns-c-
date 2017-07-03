using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {

        public double Valor { get; set; }
        public List<Item> Itens { get; set; }
        public EstadoOrcamento EstadoAtual { get; set; }
        
        public Orcamento(double valor)
        {
            this.Valor = valor;
            Itens = new List<Item>();
            this.EstadoAtual = new EstadoEmAprovacao();
        }

    }
}
