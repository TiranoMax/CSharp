using Aula_17_05_Camadas.Model;
using System.Collections.Generic;

namespace Aula_17_05_Camadas.Controller
{
    class AtividadeController
    {

        //simulando tabela
        public List<Atividade> ListarAtividades { get; set; }

        //Salvar
        public void salvar (Atividade atividade)
        {
            ListarAtividades.Add(atividade);
        }

        //Listar
        public List<Atividade> listar()
        {
            return ListarAtividades;
        }

        //Ler
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
        //Excluir
    }
}
