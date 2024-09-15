using CBS.Services.ShoppingCartAPI.Models.Dto;

namespace CBS.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
