using HTT_Test_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_Test_API.Repository
{
    public class CategoryRepository : IRepository<Category, int>
    {
        private readonly AppContext _context;
        private readonly ILogger _logger;

        public CategoryRepository(AppContext context, ILogger logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<int> Create(Category data)
        {
            await _context.Categories.AddAsync(data);
            await _context.SaveChangesAsync();
            return data.Id;
        }

        public async Task<int> Delete(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                _logger.LogError("Category not found");
                throw new Exception($"Category {id} not found");
            }

            _context.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<IList<Category>> GetAll()
        {
            var categoryList = await _context.Categories.ToListAsync();
            if (categoryList == null)
            {
                _logger.LogError("There are no categories");
                throw new Exception("There are no categories");
            }

            return categoryList;
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                _logger.LogError("Category not found");
                throw new Exception($"Category {id} not found");
            }

            return category;
        }

        public async Task<int> Update(Category data)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == data.Id);
            if (category == null)
            {
                _logger.LogError($"Category {data.Id} not found");
                throw new Exception($"Category {data.Id} not found");
            }

            if (data == null)
            {

            }

            _context.Categories.Update(category);
            return await _context.SaveChangesAsync();
        }
    }
}
