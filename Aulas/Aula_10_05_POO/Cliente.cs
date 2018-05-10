using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10_05_POO
{
    class Cliente : Pessoa
    {
        // "ctor" é um snippet para a criacao do construtor

        public Cliente()
        {

        }

        public Cliente(string nome): base(nome){

        }
        
    }
}
