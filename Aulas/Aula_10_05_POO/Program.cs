using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        }
    }
}
