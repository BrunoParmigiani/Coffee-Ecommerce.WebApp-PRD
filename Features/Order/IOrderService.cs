using Coffee_Ecommerce.WebApp.Features.Order.Create;
using Coffee_Ecommerce.WebApp.Features.Order.Update;
using Coffee_Ecommerce.WebApp.Features.Order.GetPage;
using Coffee_Ecommerce.WebApp.Features.Order.Rate;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public interface IOrderService
    {
        Task<OrderEntity> CreateAsync(CreateRequest request);
        Task<OrderEntity> UpdateAsync(UpdateRequest request);
        Task<OrderEntity> GetByIdAsync(Guid id);
        Task<List<OrderEntity>> GetPageAsync(GetPageRequest request);
        Task<List<OrderEntity>> GetByUserAsync(GetPageRequest request);
        Task<OrderEntity> RateAsync(RateRequest request);
        Task<List<OrderMessage>> GetMessagesAsync(Guid orderId);
    }
}
