using HTT_Test_API.DTO;

namespace HTT_Test_API.Servises.Interfaces;
public interface IProductServise
{
    IList<ProductDto> GetAllProducts();
}