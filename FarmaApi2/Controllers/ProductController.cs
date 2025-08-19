using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FarmaApi2.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

       [HttpGet(Name = "GetProducts")]
       public IActionResult GetProducts()
        {
            List<Product> products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost(Name = "CreateProducts")]
        public IActionResult CreateProducts(CreateProductDTO dto)
        {
            var products = _productService.CreateProduct(dto);
            return Ok(products);
        }
    }
}
