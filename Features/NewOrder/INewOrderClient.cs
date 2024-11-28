using Coffee_Ecommerce.WebApp.Features.NewOrder.Create;
using Coffee_Ecommerce.WebApp.Features.NewOrder.Delete;
using Coffee_Ecommerce.WebApp.Features.NewOrder.GetByEstablishment;

namespace Coffee_Ecommerce.WebApp.Features.NewOrder
{
    public interface INewOrderClient
    {
        [Post("/api/NewOrder")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);
        
        [Delete("/api/NewOrder/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/NewOrder/establishment")]
        Task<GetByEstablishmentResult> GetByEstablishmentAsync();
    }
}
