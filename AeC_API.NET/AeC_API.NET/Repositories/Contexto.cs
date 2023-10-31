using Microsoft.EntityFrameworkCore;

namespace AeC_API.NET.Repositories
{
    public class Contexto : DbContext
    {
        public DbSet<Repositories.Entities.Clima> clima { get; set; }
        public DbSet<Repositories.Entities.Log> log { get; set; }

        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        {
        }        
    }
}
