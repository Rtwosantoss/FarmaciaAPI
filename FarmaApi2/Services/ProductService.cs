using FarmaApi2.DTOs;
using FarmaApi2.Entity;
using FarmaApi2.Interfaces;

namespace FarmaApi2.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }
        public Product CreateProduct(CreateProductDTO dto)
        {
            Product product = _productRepository.CreateProduct(dto);

            return product;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = _productRepository.GetProducts();

            return products;
        }
    }
}
