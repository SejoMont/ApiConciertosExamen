using ApiConciertosExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConciertosExamen.Data
{
    public class ConciertosContext : DbContext
    {
        public ConciertosContext(DbContextOptions<ConciertosContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CategoriaEvento> Categorias { get; set; }
    }
}