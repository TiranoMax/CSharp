using System;

namespace Aula_17_05_Camadas.View
{
    class AtividadeView
    {

        public int ExibirMenu()
        {
            Console.WriteLine("========================");
            Console.WriteLine("= Escolha uma opção:   =");
            Console.WriteLine("= 1) Criar Atividade   =");
            Console.WriteLine("= 2) Listar Atividade  =");
            Console.WriteLine("= 3) Buscar Atividade  =");
            Console.WriteLine("= 4) Editar Atividade  =");
            Console.WriteLine("= 5) Excluir Atividade =");
            Console.WriteLine("========================");

            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

    }
}
