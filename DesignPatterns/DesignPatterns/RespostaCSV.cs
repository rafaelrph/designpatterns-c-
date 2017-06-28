using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RespostaCSV : Resposta
    {

        public Resposta OutraResposta { get; set; }

        public RespostaCSV()
        {
            this.OutraResposta = null;
        }

        public string ResponderRequisicao(Conta conta, Requisicao requisicao)
        {
            if(requisicao.Formato == Formato.CSV)
            {
                return conta.Titular + ";" + conta.Saldo + ";";
            }
            else if(OutraResposta != null)
            {
                return OutraResposta.ResponderRequisicao(conta, requisicao);
            }
            else
            {
                throw new Exception("Formato inválido");
            }
            
        }

    }
}
