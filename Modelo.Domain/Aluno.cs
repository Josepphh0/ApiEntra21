using System.Text.Json.Serialization;

namespace Modelo.Domain
{
    public class Aluno
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cep { get; set; }
    }
}
