using Coffee_Ecommerce.WebApp.Features.Order.Create;
using Coffee_Ecommerce.WebApp.Features.Order.GetById;
using Coffee_Ecommerce.WebApp.Features.Order.GetByUser;
using Coffee_Ecommerce.WebApp.Features.Order.GetPage;
using Coffee_Ecommerce.WebApp.Features.Order.Rate;
using Coffee_Ecommerce.WebApp.Features.Order.Update;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public interface IOrderClient
    {
        [Post("/api/Order")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Put("/api/Order")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);

        [Get("/api/Order/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Get("/api/Order/page")]
        Task<GetPageResult> GetPageAsync([Query] GetPageRequest request);

        [Get("/api/Order/user")]
        Task<GetByUserResult> GetByUserAsync([Query] GetPageRequest request);

        [Put("/api/Order/rate")]
        Task<RateResult> RateAsync([Body] RateRequest request);
    }
}
