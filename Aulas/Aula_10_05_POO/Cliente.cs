using System;

namespace Aula_10_05_POO
{
    class Cliente : Pessoa
    {

        public DateTime DataNasc { get; set; }

        // "ctor" é um snippet para a criacao do construtor

        public Cliente()
        {

        }

        public Cliente(string nome): base(nome){

        }

        public Cliente(string nome, string cpf) : base(nome, cpf)
        {
                
        }
        
    }
}
