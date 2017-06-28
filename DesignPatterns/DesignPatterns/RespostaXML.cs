using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RespostaXML : Resposta
    {

        public Resposta OutraResposta { get; set; }

        public RespostaXML()
        {
            this.OutraResposta = null;
        }

        public string ResponderRequisicao(Conta conta, Requisicao requisicao)
        {
            if(requisicao.Formato == Formato.XML)
            {
                return "<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>";
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
