using Aula_17_05_Camadas.Controller;
using Aula_17_05_Camadas.Model;
using System;

namespace Aula_17_05_Camadas.View
{
    class AtividadeView
    {

        public void ExibirMenu()
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
            switch (opcao)
            {
                case 1:
                    CriarAtividade();
                    break;

                default:
                    break;
            }


        }

        public void CriarAtividade()
        {
            Atividade atividade = new Atividade();

            Console.WriteLine("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;

            AtividadeController atividadeCtrl = new AtividadeController();
            atividadeCtrl.Salvar(atividade);
        }
    }
}
