using System;

namespace Aula_10_05_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Marcos"; // set
            string nomeCliente = cliente.Nome; // get

            cliente.Cpf = "12345678901";// set
            string cpfCliente = cliente.Cpf; //get

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Cpf);

            //utilizando os construtores parametrizados
            Cliente cliente1 = new Cliente("Jaque"); //nome
            Console.WriteLine(cliente1.Nome);

            Cliente cliente2 = new Cliente("Iara", "1234"); //nome, cpf
            cliente2.DataNasc = new DateTime(1998, 08, 12);
            Console.WriteLine(cliente2.Nome + "; Data Nascimento: " + cliente2.DataNasc);
            Console.WriteLine(cliente2.Nome + "; Data Nascimento: " + cliente2.DataQueNasceu);
            

            //Pessoa p = new Pessoa(); ERRO: classes abstratas não podem ser instanciadas


            Console.ReadKey();

        }
    }
}
