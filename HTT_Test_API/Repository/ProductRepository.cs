using HTT_Test_API.Models;
using HTT_Test_API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HTT_Test_API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppContext _context;

        public ProductRepository(AppContext context)
        {
            _context = context;
        }

        public IList<Product> GetAll()
        {
            var productsList = _context.Products
                .Include(p => p.Category)
                .ToList();

            return productsList.Count == 0 
                ? throw new Exception("There are no products") 
                : productsList;
        }
    }
}
