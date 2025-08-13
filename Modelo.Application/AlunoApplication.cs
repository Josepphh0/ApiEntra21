using Modelo.Application.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Application
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno BuscarAluno(int id)
        {
            return _alunoRepositorio.BuscarId(id);
        }

        public string InserirAluno(Aluno aluno)
        {
            var mensagem = ValidarAluno(aluno);

            if (mensagem == "")
            {
                _alunoRepositorio.InserirAluno(aluno);
                mensagem = "Aluno inserido com sucesso!";
            }

            return mensagem;
        }

        public void ExcluirAluno(int id)
        {
            _alunoRepositorio.ExcluirAluno(id);
        }

        private string ValidarAluno(Aluno aluno)
        {
            string mensagem = "";
            if (!aluno .Nome.Any())
              mensagem = "Não é possivel inserir aluno sem nome";
            if (aluno.Idade < 0)
                mensagem = "Idade inválida";
            if (aluno.Cep.Length != 14)
                mensagem = "O cep deve possuir apenas 14 caracteres.";
            if (aluno.Nome.Length > 50)
                mensagem = "O nome deve possuir no máximo 50 caracteres.";
            return mensagem;
        }
    }
}
