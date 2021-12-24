using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProductsById(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
