using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancocontexto;

        public AlunoRepositorio(BancoContexto bancocontexto)
        {
            _bancocontexto = bancocontexto;
        }

        public Aluno BuscarId(int id)
        {
            return _bancocontexto.Aluno.FirstOrDefault(x => x.Id == id);
        }

        public void InserirAluno(Aluno aluno)
        {
            _bancocontexto.Aluno.Add(aluno);
            _bancocontexto.SaveChanges();
        }

        public void ExcluirAluno(int id)
        {
            var aluno = BuscarId(id);
            _bancocontexto.Aluno.Remove(aluno);
            _bancocontexto.SaveChanges();
        }
    }
}
