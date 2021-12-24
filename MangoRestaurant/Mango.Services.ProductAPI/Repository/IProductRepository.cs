using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>>GetProducts();
        Task<IEnumerable<ProductDto>> GetProductsById(int ProductId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<ProductDto> DeleteProduct(int productId);


    }
}
