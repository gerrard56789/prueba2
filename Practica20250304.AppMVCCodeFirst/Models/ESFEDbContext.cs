using Microsoft.EntityFrameworkCore;
namespace Practica20250304.AppMVCCodeFirst.Models
{
    public class ESFEDbContext: DbContext
    {
        public ESFEDbContext(DbContextOptions<ESFEDbContext> options) : base(options) { }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
