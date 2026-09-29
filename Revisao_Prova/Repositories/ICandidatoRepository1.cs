using Revisao_Prova.Models;

namespace Revisao_Prova.Repositories
{
    public interface ICandidatoRepository1
    {
        void Adicionar(Candidato candidato);
        Candidato BuscarPorNumero(int numero);
        List<Candidato> Listar();
    }
}