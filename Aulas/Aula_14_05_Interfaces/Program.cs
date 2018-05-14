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

            Onibus bus = new Onibus();

            Console.WriteLine("Velocidade Inicial: " + bus.Velocidade);
            bus.Acelerar();
            bus.Acelerar();
            bus.Desacelerar();
            Console.WriteLine("Velocidade Atual: " + bus.Velocidade);

            Console.ReadKey();


        }
    }
}
