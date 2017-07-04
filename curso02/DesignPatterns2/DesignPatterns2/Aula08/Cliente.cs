using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Aula08
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public int idade { get; set; }

        public Cliente(string nome, string email, int idade)
        {
            this.nome = nome;
            this.email = email;
            this.idade = idade;
        }
    }
}
