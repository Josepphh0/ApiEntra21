using Modelo.Domain;

namespace Modelo.Application.Interfaces
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);

        string InserirAluno(Aluno aluno);

        void ExcluirAluno(int id);
    }
}
