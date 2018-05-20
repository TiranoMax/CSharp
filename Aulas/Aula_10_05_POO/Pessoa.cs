namespace Aula_10_05_POO
{
    public abstract class Pessoa {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa()
        {//Construtor vazio

        }

        public  Pessoa(string nome)
        {

            Nome = nome;

        }

        public Pessoa(string nome, string cpf)
        {

            Nome = nome;
            Cpf = cpf;

        }


        public  abstract string ImprimirInfo();
       
    }
}
