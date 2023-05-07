using HTT_Test_API.Repository;
using HTT_Test_API.Repository.Interfaces;
using HTT_Test_API.Servises;
using HTT_Test_API.Servises.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HTT_Test_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppContext>(options =>
                options.UseSqlServer(builder.Configuration["ConnectionStrings:SqlServerConnection"]));

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductServise, ProductServise>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}