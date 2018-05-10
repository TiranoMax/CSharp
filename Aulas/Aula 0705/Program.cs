using System;

namespace Aula_0705
{
    class Program{

        static void Main(string[] args){

            int a = 10;
            int b = 20;

            Console.WriteLine("Hello World");
            Console.WriteLine("soma entre A e B: "+(a + b));

            if (Console.CapsLock)
                Console.WriteLine("capslock ativado");
            else
                Console.WriteLine("capslock desativado");

            do {

                a += 5;
                Console.WriteLine(a);
    
            } while (a != 20);


            Console.ReadKey();
            

        }
    }
}
