using SistemaDeAcademia.Enum;

namespace SistemaDeAcademia.Models
{
    public class InstituicaoModel
    {
        public int Id { get; set; }
        public string NomePropietario { get; set; }
        public string CPF { get; set; }
        public string NomeInstituicao { get; set; }
        public EstadoEnum Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
    }
}
