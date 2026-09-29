using Revisao_Prova.Models;
using System.Collections.Generic;

namespace Revisao_Prova.Repositories
{
    public interface ICandidatoRepository
    {
        void Adicionar(Candidato candidato); // Adiciona candidato
        List<Candidato> Listar(); // Lista todos os candidatos
        Candidato BuscarPorNumero(int numero); // Busca candidato pelo número
    }
}
