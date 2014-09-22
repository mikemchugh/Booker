using Booker.Domain.Entities;
using System.Data.Entity;

namespace Booker.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
