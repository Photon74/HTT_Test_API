using HTT_Test_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_Test_API
{
    public class AppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
