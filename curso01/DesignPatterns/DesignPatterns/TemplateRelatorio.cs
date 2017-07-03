using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TemplateRelatorio
    {

        protected abstract void Cabecalho();

        protected abstract void Rodape();

        protected abstract void Conteudo(IList<Conta> contas);

        public void Imprimir(IList<Conta> contas)
        {
            Cabecalho();
            Conteudo(contas);
            Rodape();
        }

    }
}
