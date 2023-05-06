using HTT_Test_API.Models;

namespace HTT_Test_API.Repository
{
    public class ProductRepository : IRepository<Product, int>
    {
        private readonly AppContext _context;
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(AppContext context, ILogger<ProductRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task<int> Create(Product data)
        {
            _context.Products.Add(data);
            _context.SaveChanges();
            return data.Id;
        }

        public int Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                _logger.LogError("Product not found");
                throw new Exception("Product not found");
            }

            _context.Products.Remove(product);
            return _context.SaveChanges();
        }

        public IList<Product> GetAll()
        {
            var productsList = _context.Products.ToList();
            if (productsList.Count == 0)
            {
                _logger.LogError("There are no products");
                throw new Exception("There are no products");
            }

            return productsList;
        }

        public Product GetById(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                _logger.LogError($"Product {id} not found");
                throw new Exception($"Product {id} not found");
            }

            return product;
        }

        public int Update(Product data)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == data.Id);
            if (product == null)
            {
                _logger.LogError($"Product {data.Id} not found");
                throw new Exception($"Product {data.Id} not found");
            }

            _context.Products.Update(product);
            return _context.SaveChanges();
        }
    }
}
