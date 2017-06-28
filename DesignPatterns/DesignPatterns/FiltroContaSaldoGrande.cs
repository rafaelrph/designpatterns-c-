using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class FiltroContaSaldoGrande : Filtro
    {

        public FiltroContaSaldoGrande(Filtro outroFiltro) : base (outroFiltro) { }
        public FiltroContaSaldoGrande() : base () { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = new List<Conta>();
            foreach(Conta conta in contas)
            {
                if(conta.Saldo > 500000)
                {
                    contasFiltradas.Add(conta);
                }
            }
            return contasFiltradas;
        }


    }
}
