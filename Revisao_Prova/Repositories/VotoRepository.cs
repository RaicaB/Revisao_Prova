using Revisao_Prova.Models;
using Revisao_Prova.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Revisao_Prova.Repositories
{
    public class VotoRepository : IVotoRepository
    

    {
        private static List<Voto> votos = new List<Voto>(); // Lista em memória

        public void Registrar(Voto voto)
        {
            votos.Add(voto); // Adiciona voto
        }

        public List<Voto> ConsultarPorCandidato(int numeroCandidato)
        {
            // Filtra votos pelo número do candidato
            return votos.Where(v => v.NumeroCandidato == numeroCandidato).ToList();
        }
    }
}
