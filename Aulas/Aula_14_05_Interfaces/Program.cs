using System;
using System.Collections.Generic;

namespace Aula_14_05_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Console.WriteLine("Velocidade Inicial: " + car.Velocidade);
            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();
            Console.WriteLine("Velocidade Atual: " + car.Velocidade);


            Console.WriteLine("\n\n");


            Onibus bus = new Onibus();

            Console.WriteLine("Velocidade Inicial: " + bus.Velocidade);
            bus.Acelerar();
            bus.Acelerar();
            bus.Desacelerar();
            Console.WriteLine("Velocidade Atual: " + bus.Velocidade);

            Console.WriteLine("\n\n");

            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());

            Console.WriteLine();
            AcelerarBastante(bus);
            Console.WriteLine(bus.ImprimirInfo());

            Console.WriteLine();
            CriarRelacionamentos();

            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for(int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }

        static void CriarRelacionamentos()
        {
            Carro c = new Carro();
            c.Modelo = "corsa";

            Marca m = new Marca();
            m.Nome = "Chevrolet";
            c._Marca = m;

            //criando e armazenando rodas

            c.Rodas = new List<Roda>();
            Roda r1 = new Roda();
            c.Rodas.Add(r1);

            for (int i = 0; i < 3; i++)
            {
                c.Rodas.Add(r1);
            }

            Console.WriteLine("QTD rodas: " + c.Rodas.Count);


            Onibus o = new Onibus();
            c.Modelo = "3100";
            o._Marca = m;

        }
    }
}
