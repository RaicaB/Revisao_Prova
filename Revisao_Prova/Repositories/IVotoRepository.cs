using Revisao_Prova.Models;

namespace Revisao_Prova.Repositories

{
    public interface IVotoRepository
    {
        void Registrar(Voto voto); // Registra um voto
        List<Voto> ConsultarPorCandidato(int numeroCandidato); // Consulta votos de um candidato
    }
}
