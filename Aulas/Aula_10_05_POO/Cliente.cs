using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_05_POO
{
    class Cliente
    {
        //atributo
        private string nome;
        private string cpf;
        
        //propriedade
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
