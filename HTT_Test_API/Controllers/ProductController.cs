using HTT_Test_API.DTO;
using HTT_Test_API.Servises.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HTT_Test_API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductServise _productServise;

    public ProductController(IProductServise productServise)
    {
        _productServise = productServise;
    }

    [HttpGet]
    public ActionResult<IList<ProductDto>> GetProducts()
    {
        var productsList = _productServise.GetAllProducts();
        return Ok(productsList);
    }
}
