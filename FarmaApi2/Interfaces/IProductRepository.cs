using FarmaApi2.DTOs;
using FarmaApi2.Entity;

namespace FarmaApi2.Interfaces
{
    public interface IProductRepository
    {
        public Product CreateProduct(CreateProductDTO dto);
        public List<Product> GetProducts();
    }
}