using System.ComponentModel.DataAnnotations;
using Microsoft.OpenApi.MicrosoftExtensions;



namespace Revisao_Prova.Models
{
    public class Voto
    { 
        
        [Required] // RA do aluno é obrigatório
        public string RaAluno { get; set; }

        [Required] // Data do voto é obrigatória
        public DateTime DataVoto { get; set; }

        [Required] // Número do candidato escolhido é obrigatório
        public int NumeroCandidato { get; set; }
    }
}
 
