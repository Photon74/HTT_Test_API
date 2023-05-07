using HTT_Test_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_Test_API
{
    public class AppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category{Id=1, Name="Фрукты"},
                    new Category{Id=2, Name="Овощи"},
                    new Category{Id=3, Name="Мясо"},
                    new Category{Id=4, Name="Алкоголь"}
                });


            modelBuilder.Entity<Product>().HasData(
                new Product[]
                {
                    new Product{ProductId=1, ProductName="Клубника", CategoryId=1 },
                    new Product{ProductId=2, ProductName="Вишня", CategoryId=1 },
                    new Product{ProductId=3, ProductName="Крыжовник", CategoryId=1 },
                    new Product{ProductId=4, ProductName="Помидоры", CategoryId=2 },
                    new Product{ProductId=5, ProductName="Огурцы", CategoryId=2 },
                    new Product{ProductId=6, ProductName="Лук", CategoryId=2 },
                    new Product{ProductId=7, ProductName="Свинина", CategoryId=3 },
                    new Product{ProductId=8, ProductName="Говядина", CategoryId=3 },
                    new Product{ProductId=9, ProductName="Курица", CategoryId=3 },
                    new Product{ProductId=10, ProductName="Пиво", CategoryId=4 },
                    new Product{ProductId=11, ProductName="Водка", CategoryId=4 },
                    new Product{ProductId=12, ProductName="Коньяк", CategoryId=4 },
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
