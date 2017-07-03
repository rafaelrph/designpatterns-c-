using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RespostaJSON : Resposta
    {

        public Resposta OutraResposta { get; set; }

        public RespostaJSON()
        {
            this.OutraResposta = null;
        }

        public string ResponderRequisicao(Conta conta, Requisicao requisicao)
        {
            if(requisicao.Formato == Formato.JSON)
            {
                return "conta { titular: " + conta.Titular + ", saldo: " + conta.Saldo + "}";
            }
            else if(OutraResposta != null)
            {
                return OutraResposta.ResponderRequisicao(conta, requisicao);
            } else
            {
                throw new Exception("Formato inválido");
            }
        }

    }
}
