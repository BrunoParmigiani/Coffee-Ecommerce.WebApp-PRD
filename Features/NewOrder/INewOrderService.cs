namespace Coffee_Ecommerce.WebApp.Features.NewOrder
{
    public interface INewOrderService
    {
        // 😂😂😂😭
        Task<bool> CreateAsync(Order.Create.CreateRequest request);
        Task<bool> DeleteAsync(Guid id);
        Task<List<Order.Create.CreateRequest>> GetByEstablishmentAsync();
    }
}
