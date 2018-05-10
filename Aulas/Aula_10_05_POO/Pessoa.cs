using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_05_POO
{
    class Pessoa {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {//Construtor vazio

        }

        public Cliente(string nome)
        {

            Nome = nome;

        }

        public Cliente(string nome, string cpf)
        {

            Nome = nome;
            Cpf = cpf;

        }


    }
}
