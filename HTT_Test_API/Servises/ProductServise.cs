using HTT_Test_API.DTO;
using HTT_Test_API.Repository.Interfaces;
using HTT_Test_API.Servises.Interfaces;

namespace HTT_Test_API.Servises;

public class ProductServise : IProductServise
{
    private readonly IProductRepository _productRepository;

    public ProductServise(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IList<ProductDto> GetAllProducts()
    {
        var products = _productRepository.GetAll();
        var productsDto = new List<ProductDto>();

        foreach (var product in products)
        {
            productsDto.Add(new ProductDto
            {
                ProductName = product.ProductName,
                CategoryName = product.Category?.Name ?? "Без категории",
            });
        }

        return productsDto;
    }
}
