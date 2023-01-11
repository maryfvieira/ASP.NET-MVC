using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuario { get; set; }

        internal void Adicionar(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }
    }
}
