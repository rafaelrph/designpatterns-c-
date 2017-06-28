using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface Resposta
    {

        Resposta OutraResposta { get; set; }

        string ResponderRequisicao(Conta conta, Requisicao requisicao);

    }
}
