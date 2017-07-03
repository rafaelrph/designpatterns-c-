using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula06
{
    public class MensagemCliente: IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public void Enviar()
        {
            this.Enviador.Enviar(this);
        }

        public string Formatar()
        {
            return string.Format("Mensagem sendo enviada para o cliente {0}", this.nome);
        }
    }
}
