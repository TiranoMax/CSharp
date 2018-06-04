using Aula_17_05_Camadas.Model;
using System.Collections.Generic;
using System.Linq;

namespace Aula_17_05_Camadas.Controller
{
    class AtividadeController
    {

        //simulando tabela
        private static List<Atividade> ListarAtividades { get; set; }


        private static int ultimoIdUtilizado = 1;

        static AtividadeController()
        {
            ListarAtividades = new List<Atividade>();
        }


        //Salvar
        public void Salvar (Atividade atividade)
        {
            atividade.AtividadeId = ultimoIdUtilizado++;
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

        public List<Atividade> BuscarAtividadePorNome(string Nome)
        {
            IEnumerable<Atividade> atividadeSelecionadas = new List<Atividade>();

            atividadeSelecionadas = from x in ListarAtividades
                                    where x.Nome.ToLower().Contains(Nome.ToLower())
                                    select x;

            return atividadeSelecionadas.ToList();
    
        }


        public List<Atividade> ListarAtividadeAtivosOrInativos(bool ativo)
        {
            IEnumerable<Atividade> atividadeSelecionadas = new List<Atividade>();

            atividadeSelecionadas = from x in ListarAtividades
                                    where x.Ativo == ativo
                                    select x;



            return atividadeSelecionadas.ToList();
        }
    }
}
