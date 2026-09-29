using System.ComponentModel.DataAnnotations;

namespace Revisao_Prova.Models
    // comentários adicionados para explicar o código e auxiliar na compreensão do mesmo
{
    public class Candidato
    {
        [Required] // Campo obrigatório
        [StringLength(50, MinimumLength = 3)] // Nome entre 3 e 50 caracteres
        public string Nome { get; set; }

        [Required] // Campo obrigatório
        [EmailAddress] // Validação de e-mail válido
        public string Email { get; set; }

        [Required] // Campo obrigatório
        [Range(1, 8)] // Turma entre 1 e 8
        public int Turma { get; set; }

        [Required] // Campo obrigatório
        [StringLength(500)] // Máximo de 500 caracteres
        public string DescricaoProposta { get; set; }

        [Required] // Campo obrigatório
        [Range(10, 99)] // Número do candidato entre 10 e 99
        public int Numero { get; set; }
    }
}
