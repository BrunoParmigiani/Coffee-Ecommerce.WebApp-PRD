using Coffee_Ecommerce.WebApp.Features.Order.GetMessages;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public interface IOrderMessageClient
    {
        [Get("/api/OrderMessages")]
        Task<GetMessagesResult> GetMessagesAsync(Guid orderId);
    }
}
