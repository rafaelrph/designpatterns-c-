using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class FiltroContaSaldoPequeno : Filtro
    {

        public FiltroContaSaldoPequeno(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroContaSaldoPequeno() : base () { }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = new List<Conta>();
            foreach(Conta conta in contas)
            {
                if(conta.Saldo < 100)
                {
                    contasFiltradas.Add(conta);
                }
            }

            return contasFiltradas;
        }

    }
}
