using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula06
{
    public class EnviarPorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por e-mail...");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
