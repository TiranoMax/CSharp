using Aula_17_05_Camadas.Controller;
using Aula_17_05_Camadas.Model;
using System;

namespace Aula_17_05_Camadas.View
{
    class AtividadeView
    {

        private AtividadeController atividadeCtrl;

        enum OpcoesMenu
        {
            CriarAtividade = 1,
            ListarAtividade = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5,
            Sair = 9
        }


        public AtividadeView()
        {
            atividadeCtrl = new AtividadeController();
        }




        public void ExibirMenu()
        {

            OpcoesMenu opcao = OpcoesMenu.Sair;
            

            do
            {

                Console.WriteLine("========================");
                Console.WriteLine("= Escolha uma opção:   =");
                Console.WriteLine("= 1) Criar Atividade   =");
                Console.WriteLine("= 2) Listar Atividade  =");
                Console.WriteLine("= 3) Buscar Atividade  =");
                Console.WriteLine("= 4) Editar Atividade  =");
                Console.WriteLine("= 5) Excluir Atividade =");
                Console.WriteLine("= 9) Sair              =");
                Console.WriteLine("========================");

                opcao = (OpcoesMenu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case OpcoesMenu.CriarAtividade:
                        CriarAtividade();
                        break;

                    case OpcoesMenu.ListarAtividade:
                        ListarAtividade();
                        break;
                        
                    case OpcoesMenu.BuscarAtividade:
                        BuscarAtividade();
                        break;

                    case OpcoesMenu.EditarAtividade:
                        EditarAtividade();
                        break;

                    case OpcoesMenu.ExcluirAtividade:
                        ExcluirAtividade();
                        break;

                    case OpcoesMenu.Sair:
                        break;
                
                default:
                        break;
                }

            } while (opcao != OpcoesMenu.Sair);

            


        }

        private void ExcluirAtividade()
        {
            ListarAtividade();
            Console.WriteLine("Digite o id da atividade que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());
            atividadeCtrl.Excluir(id);

        }

        private void EditarAtividade()
        {
            ListarAtividade();
            Console.WriteLine("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObeterDadosAtividade();

            atividadeCtrl.Editar(id, atividadeAtualizada);


        }

        private void BuscarAtividade()
        {
            
            Console.Write("Digite o id da Atividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeCtrl.BuscarPorID(id);

            if (atividade != null)
            {
                ExibirDetalhesAtividade(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada");
            }
            Console.ReadKey();
        }


        private void ListarAtividade()
        {

            foreach (Atividade atividade in atividadeCtrl.Listar())
            {
                ExibirDetalhesAtividade(atividade);

            }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();
        }

        
        private static void ExibirDetalhesAtividade(Atividade atividade)
        {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeId);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
        }

        
        public void CriarAtividade()
        {
            Atividade atividade = ObeterDadosAtividade();
            atividadeCtrl.Salvar(atividade);
        }


        private static Atividade ObeterDadosAtividade()
        {
            Atividade atividade = new Atividade();

            Console.WriteLine("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;
            return atividade;
        }
    }
}
