using ApiConciertosExamen.Models;
using ApiConciertosExamen.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiConciertosExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertosContoller : ControllerBase
    {
        private RepositoryConciertos repo;

        public ConciertosContoller(RepositoryConciertos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CategoriaEvento>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{idcategoria}")]
        public async Task<ActionResult<List<Evento>>> GetEventosCategoria(int idcategoria)
        {
            return await this.repo.GetEventosCategoriaAsync(idcategoria);
        }
    }
}
