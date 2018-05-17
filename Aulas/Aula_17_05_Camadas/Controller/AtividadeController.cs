using Aula_17_05_Camadas.Model;
using System.Collections.Generic;

namespace Aula_17_05_Camadas.Controller
{
    class AtividadeController
    {

        //simulando tabela
        private static List<Atividade> ListarAtividades { get; set; }

        static AtividadeController()
        {
            ListarAtividades = new List<Atividade>();
        }


        //Salvar
        public void Salvar (Atividade atividade)
        {
            atividade.AtividadeId = ListarAtividades.Count + 1;
            ListarAtividades.Add(atividade);
        }

        //Listar
        public List<Atividade> Listar()
        {
            return ListarAtividades;
        }

        //BuscarPorID
        public Atividade BuscarPorID(int id)
        {
            foreach(Atividade a in ListarAtividades)
            {
                if(a.AtividadeId == id)
                {
                    return a;
                }
            }
            return null;
        }
        //Editar
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);

            if (atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);

            if (atividade != null)
            {
                ListarAtividades.Remove(atividade);
            }
        }
    }
}
