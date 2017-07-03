using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula06
{
    public class EnviarPorSMS : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por SMS...");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
