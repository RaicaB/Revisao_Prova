using Microsoft.AspNetCore.Mvc;
using Revisao_Prova.Models;
using Revisao_Prova.Repositories;

namespace Revisao_Prova.Controllers
{
    public class VotoControllers

    {
        [ApiController]
        [Route("api/[controller]")] // Rota: /api/votos
        public class VotosController : ControllerBase
        {
            private readonly IVotoRepository _repo;

            public VotosController(IVotoRepository repo)
            {
                _repo = repo;
            }

            [HttpPost] // POST - registrar voto
            public IActionResult Post([FromBody] Voto voto)
            {
                if (!ModelState.IsValid) // Validações dos atributos
                    return BadRequest(ModelState);

                _repo.Registrar(voto); // Registra voto
                return Ok("Voto registrado com sucesso!");
            }

            [HttpGet("{numeroCandidato}")] // GET - consultar votos por candidato
            public IActionResult Get(int numeroCandidato)
            {
                return Ok(_repo.ConsultarPorCandidato(numeroCandidato)); // Retorna votos do candidato
            }
        }
    }
}
