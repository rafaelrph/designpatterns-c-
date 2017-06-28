using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Filtro
    {

        public Filtro OutroFiltro { get; set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public IList<Conta> FiltrarProximo(IList<Conta> contas)
        {
            if(OutroFiltro != null)
            {
                return OutroFiltro.Filtrar(contas);
            } else
            {
                return new List<Conta>();
            }
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

    }
}
