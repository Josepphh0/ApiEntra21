using Modelo.Domain;

namespace Modelo.Infra.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarId(int id);

        void InserirAluno(Aluno aluno);

        void ExcluirAluno(int id);
    }
}
