using Microsoft.AspNetCore.Mvc;
using Revisao_Prova.Models;
using Revisao_Prova.Repositories;

namespace Revisao_Prova.Controllers

{
    [ApiController]
    [Route("api/[controller]")] // Rota: /api/candidatos
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatoRepository _repo; // Injeção de dependência

        public CandidatosController(ICandidatoRepository repo)
        {
            _repo = repo;
        }

        [HttpPost] // POST - cadastrar candidato
        public IActionResult Post([FromBody] Candidato candidato)
        {
            if (!ModelState.IsValid) // Validações dos atributos
                return BadRequest(ModelState);

            try
            {
                _repo.Adicionar(candidato); // Adiciona candidato
                return Ok("Candidato cadastrado com sucesso!");
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message); // Retorna erro se número duplicado
            }
        }

        [HttpGet] // GET - listar candidatos
        public IActionResult Get()
        {
            return Ok(_repo.Listar()); // Retorna lista de candidatos
        }
    }
}
