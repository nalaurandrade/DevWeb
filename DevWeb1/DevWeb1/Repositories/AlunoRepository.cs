using DevWeb1.Models;

namespace DevWeb1.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> ListaAlunos = new List<Aluno>();
        public void Atualizar(Aluno aluno)
        {
            var resultado = ObterPorRa(aluno.RA);
            if (resultado != null)
            {
                ListaAlunos.Remove(resultado);
                ListaAlunos.Add(aluno);
            }

        }
        public void Cadastrar(Aluno aluno)
        {
            ListaAlunos.Add(aluno);
        }

        public void Deletar(string ra)
        {
            var resultado = ObterPorRa(ra);
            ListaAlunos.Remove(resultado);
        }

        public Aluno ObterPorRa(string ra)
        {
            return ListaAlunos.FirstOrDefault(a => a.RA == ra);
        }

        public List<Aluno> ObterTodos()
        {
            return ListaAlunos;
        }
    }
}
