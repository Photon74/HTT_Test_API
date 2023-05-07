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

        public int Create(Product data)
        {
            _context.Products.AddAsync(data);
            _context.SaveChangesAsync();
            return data.ProductId;
        }

        //public int Delete(int id)
        //{
        //    var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
        //    if (product == null)
        //    {
        //        throw new Exception("Product not found");
        //    }

        //    _context.Products.Remove(product);
        //    return _context.SaveChanges();
        //}

        public IList<Product> GetAll()
        {
            var productsList = _context.Products
                .Include(p => p.Category)
                .ToList();

            if (productsList.Count == 0)
            {
                throw new Exception("There are no products");
            }

            return productsList;
        }

        //public Product GetById(int id)
        //{
        //    var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
        //    if (product == null)
        //    {
        //        throw new Exception($"Product {id} not found");
        //    }

        //    return product;
        //}

        //public int Update(Product data)
        //{
        //    var product = _context.Products.FirstOrDefault(p => p.ProductId == data.ProductId);
        //    if (product == null)
        //    {
        //        throw new Exception($"Product {data.ProductId} not found");
        //    }

        //    _context.Products.Update(product);
        //    return _context.SaveChanges();
        //}
    }
}
