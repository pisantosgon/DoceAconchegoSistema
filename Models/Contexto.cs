using Microsoft.EntityFrameworkCore;

namespace Doceaconchego.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions <Contexto> options) : base(options)
        {
        
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Clientehasvendas> Clientehasvendas { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Subcategoria> Subcategoria { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<vendedor> vendedor { get; set; }





    }
}
