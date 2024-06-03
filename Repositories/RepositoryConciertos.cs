using ApiConciertosExamen.Data;
using ApiConciertosExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConciertosExamen.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }
        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<CategoriaEvento>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }
        public async Task<List<Evento>> GetEventosCategoriaAsync(int idcategoria)
        {
            return await this.context.Eventos
                                      .Where(e => e.IdCategoria == idcategoria)
                                      .ToListAsync();
        }
    }
}
