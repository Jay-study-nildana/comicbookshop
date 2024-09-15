using CBS.Services.OrderAPI.Models.Dto;

namespace CBS.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
