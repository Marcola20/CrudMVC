using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=CrudMVC.db");
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
