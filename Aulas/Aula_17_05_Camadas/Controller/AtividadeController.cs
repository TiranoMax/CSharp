using Aula_17_05_Camadas.Model;
using System.Collections.Generic;

namespace Aula_17_05_Camadas.Controller
{
    class AtividadeController
    {

        //simulando tabela
        public List<Atividade> ListarAtividades { get; set; }

        //Salvar
        public void Salvar (Atividade atividade)
        {
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
    }
}
