using Microsoft.EntityFrameworkCore;
using NSE.Catalogo.API.Models;

namespace NSE.Catalogo.API.Data
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
