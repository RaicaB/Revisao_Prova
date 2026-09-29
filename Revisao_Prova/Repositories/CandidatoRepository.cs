using Revisao_Prova.Models;
using Revisao_Prova.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace Revisao_Prova.Repositories
{
    public class CandidatoRepository
    {
        private static List<Candidato> candidatos = new List<Candidato>(); // Lista em memória

        public void Adicionar(Candidato candidato)
        {
            // Regra de negócio: não permitir número duplicado
            if (candidatos.Any(c => c.Numero == candidato.Numero))
                throw new System.Exception("Já existe candidato com este número!");

            candidatos.Add(candidato); // Adiciona candidato
        }

        public List<Candidato> Listar()
        {
            return candidatos; // Retorna todos os candidatos
        }

        public Candidato BuscarPorNumero(int numero)
        {
            return candidatos.FirstOrDefault(c => c.Numero == numero); // Busca candidato pelo número
        }
    }
}
