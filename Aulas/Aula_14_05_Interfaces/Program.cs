using System;


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

            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for(int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
