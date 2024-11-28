using Coffee_Ecommerce.WebApp.Features.Product.Create;
using Coffee_Ecommerce.WebApp.Features.Product.Delete;
using Coffee_Ecommerce.WebApp.Features.Product.GetAll;
using Coffee_Ecommerce.WebApp.Features.Product.GetByEstablishment;
using Coffee_Ecommerce.WebApp.Features.Product.GetById;
using Coffee_Ecommerce.WebApp.Features.Product.Update;

namespace Coffee_Ecommerce.WebApp.Features.Product
{
    public interface IProductClient
    {
        [Post("/api/Product")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Delete("/api/Product/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/Product/")]
        Task<GetAllResult> GetAllAsync();

        [Get("/api/Product/establishment/{id}")]
        Task<GetByEstablishmentResult> GetByEstablishmentAsync(Guid id);

        [Get("/api/Product/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Put("/api/Product/")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
    }
}